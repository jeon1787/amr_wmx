using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMX3ApiCLR;

namespace amr_wmx.UI
{
    public partial class UCServoControl : UserControl
    {
        public UCServoControl()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void UCServoControl_Load(object sender, EventArgs e)
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            string[] comboList = new string[axesStatus.Length];
            for (int i = 0; i < axesStatus.Length; i++)
            {
                comboList[i] = string.Format("Axis{0}", Convert.ToString(i));    
                //comboBox1.Items.Add(i);
            }
            comboBox1.Items.AddRange(comboList);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ServoStatusRefresh();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ServoStatusUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ServoStatusUpdate();
        }

        private void ServoStatusUpdate()
        {
            if (comboBox1.SelectedIndex == -1) return;

            try
            {
                // button Text Update
                var axesStatus = AClassSupporter.manualController.GetAxesStatus();
                var axisStatus = axesStatus[comboBox1.SelectedIndex];
                if (axisStatus.ServoOn)
                {
                    btn_servo.Text = "OFF";
                }
                else
                {
                    btn_servo.Text = "ON";
                }


                // encoder, command Text Update
                tb_encoder.Text = axisStatus.ActualPos.ToString();
                tb_command.Text = axisStatus.PosCmd.ToString();


                // Positive Limit, Negative Limit, Home Switch
                btn_pot.BackColor = axisStatus.PositiveLS ? Color.Yellow : Color.Gray;
                btn_not.BackColor = axisStatus.NegativeLS ? Color.Yellow : Color.Gray;
                btn_org.BackColor = axisStatus.HomeSwitch ? Color.Yellow : Color.Gray;
            }
            catch (IndexOutOfRangeException e) 
            { 
                Console.WriteLine(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            if (axesStatus[comboBox1.SelectedIndex].ServoOn)
            {
                // Servo OFF
                AClassSupporter.manualController.SetServoOn(comboBox1.SelectedIndex, false);            
            }
            else
            {
                // Servo ON
                AClassSupporter.manualController.SetServoOn(comboBox1.SelectedIndex, true);            
            }
        }

        private void plusButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("plusdown");
                AClassSupporter.manualController.StartJog(
                    comboBox1.SelectedIndex, 
                    Convert.ToDouble(tb_speed.Text),
                    Convert.ToDouble(tb_accel.Text),
                    Convert.ToDouble(tb_accel.Text),
                    Convert.ToDouble(tb_jerk.Text),
                    Convert.ToDouble(tb_jerk.Text));
            }
        }

        private void minusButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("minusdown");
                AClassSupporter.manualController.StartJog(
                    comboBox1.SelectedIndex,
                    -Convert.ToDouble(tb_speed.Text),
                    Convert.ToDouble(tb_accel.Text),
                    Convert.ToDouble(tb_accel.Text),
                    Convert.ToDouble(tb_jerk.Text),
                    Convert.ToDouble(tb_jerk.Text));
            }
        }

        private void plusButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("plusUp");
                AClassSupporter.manualController.StopMotion(comboBox1.SelectedIndex);
            }
        }

        private void minusButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("minusUp");
                AClassSupporter.manualController.StopMotion(comboBox1.SelectedIndex);
            }
        }

        private bool checkServoStatus()
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            var isServoOn = axesStatus[comboBox1.SelectedIndex].ServoOn;

            if (!isServoOn)
            {
                UDialog dialog = new UDialog();
                dialog.ShowDialog();
                return false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StopMotion(comboBox1.SelectedIndex);
        }

    }
}
