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
            }
            comboBox.Items.AddRange(comboList);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServoStatusUpdate();
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ServoStatusUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ServoStatusUpdate();
        }

        private void ServoStatusUpdate()
        {
            if (comboBox.SelectedIndex == -1) return;

            try
            {
                // Servo State update
                var axesStatus = AClassSupporter.statusController.GetAxesStatus();
                var axisStatus = axesStatus[comboBox.SelectedIndex];
                if (axisStatus.ServoOn)
                {
                    btn_servo.Text = "OFF";
                    btn_servo.BackColor = Color.Yellow;
                }
                else
                {
                    btn_servo.Text = "ON";
                    btn_servo.BackColor= Color.White;
                }


                // Encoder, Command position update
                tb_encoder.Text = axisStatus.ActualPos.ToString();
                tb_command.Text = axisStatus.PosCmd.ToString();


                // Positive Limit, Negative Limit, Home Switch state update
                btn_pot.BackColor = axisStatus.PositiveLS ? Color.Yellow : Color.White;
                btn_not.BackColor = axisStatus.NegativeLS ? Color.Yellow : Color.White;
                btn_org.BackColor = axisStatus.HomeSwitch ? Color.Yellow : Color.White;
            }
            catch (IndexOutOfRangeException e) 
            { 
                Console.WriteLine(e.Message);
            }
        }

        private void btn_servo_Click(object sender, EventArgs e)
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            if (axesStatus[comboBox.SelectedIndex].ServoOn)
            {
                // Servo OFF
                AClassSupporter.manualController.SetServoOn(comboBox.SelectedIndex, false);            
            }
            else
            {
                // Servo ON
                AClassSupporter.manualController.SetServoOn(comboBox.SelectedIndex, true);            
            }
        }

        private bool checkServoStatus()
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            var isServoOn = axesStatus[comboBox.SelectedIndex].ServoOn;

            if (!isServoOn)
            {
                UDialog dialog = new UDialog();
                dialog.ShowDialog();
                return false;
            }
            return true;
        }

        #region VelMove Button Event
        private void btn_plus_velmove_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("plus down");
                AClassSupporter.manualController.VelMove(
                    comboBox.SelectedIndex, 
                    Convert.ToDouble(tb_vspeed.Text),
                    Convert.ToDouble(tb_vaccel.Text),
                    Convert.ToDouble(tb_vaccel.Text),
                    Convert.ToDouble(tb_vjerk.Text),
                    Convert.ToDouble(tb_vjerk.Text));
            }
        }

        private void btn_minus_velmove_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("minus down");
                AClassSupporter.manualController.VelMove(
                    comboBox.SelectedIndex,
                    -Convert.ToDouble(tb_vspeed.Text),
                    Convert.ToDouble(tb_vaccel.Text),
                    Convert.ToDouble(tb_vaccel.Text),
                    Convert.ToDouble(tb_vjerk.Text),
                    Convert.ToDouble(tb_vjerk.Text));
            }
        }

        private void btn_plus_velmove_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("plus up");
                AClassSupporter.manualController.StopMotion(comboBox.SelectedIndex);
            }
        }

        private void btn_minus_velmove_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("minus pp");
                AClassSupporter.manualController.StopMotion(comboBox.SelectedIndex);
            }
        }

        private void btn_vstop_Click(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StopMotion(comboBox.SelectedIndex);
        }
        #endregion

        #region RelMove Button Event
        private void btn_relmove_Click(object sender, EventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("relmove click");
                AClassSupporter.manualController.RelMove(
                    comboBox.SelectedIndex,
                    Convert.ToDouble(tb_rtarget.Text),
                    Convert.ToDouble(tb_rspeed.Text),
                    Convert.ToDouble(tb_raccel.Text),
                    Convert.ToDouble(tb_raccel.Text),
                    Convert.ToDouble(tb_rjerk.Text),
                    Convert.ToDouble(tb_rjerk.Text));
            }
        }

        private void btn_rstop_Click(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StopMotion(comboBox.SelectedIndex);
        }
        #endregion

        #region AbsMove Button Event
        private void btn_absmove_Click(object sender, EventArgs e)
        {
            if (checkServoStatus())
            {
                Console.WriteLine("absmove click");
                AClassSupporter.manualController.AbsMove(
                    comboBox.SelectedIndex,
                    Convert.ToDouble(tb_atarget.Text),
                    Convert.ToDouble(tb_aspeed.Text),
                    Convert.ToDouble(tb_aaccel.Text),
                    Convert.ToDouble(tb_aaccel.Text),
                    Convert.ToDouble(tb_ajerk.Text),
                    Convert.ToDouble(tb_ajerk.Text));
            }
        }

        private void btn_astop_Click(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StopMotion(comboBox.SelectedIndex);
        }
    }
    #endregion
}
