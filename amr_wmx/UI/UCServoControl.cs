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
            ServoButtonTextRefresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ServoButtonTextRefresh();
        }

        private void ServoButtonTextRefresh()
        {
            var axesStatus = AClassSupporter.manualController.GetAxesStatus();
            if (axesStatus[comboBox1.SelectedIndex].ServoOn)
            {
                servoOnOff.Text = "OFF";
            }
            else
            {
                servoOnOff.Text = "ON";
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

        private void plusButton_Click(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StartJog(
                comboBox1.SelectedIndex, 
                Convert.ToInt32(speedValue),
                Convert.ToInt32(accelValue),
                Convert.ToInt32(accelValue),
                Convert.ToInt32(jerkValue),
                Convert.ToDouble(jerkValue));
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            AClassSupporter.manualController.StartJog(
                comboBox1.SelectedIndex,
                -Convert.ToInt32(speedValue),
                Convert.ToInt32(accelValue),
                Convert.ToInt32(accelValue),
                Convert.ToInt32(jerkValue),
                Convert.ToDouble(jerkValue));
        }
    }
}
