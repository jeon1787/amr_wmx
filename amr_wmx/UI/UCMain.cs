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
    public partial class UCMain : UserControl
    {
        EngineStatus engStatue;
        

        public UCMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engStatue = AClassSupporter.controller.GetEngineStatus();
            if (null != engStatue)
            {
                if (EngineState.Running == engStatue.State || EngineState.Communicating == engStatue.State)
                {
                    AClassSupporter.controller.StopEngine();
                }
                else
                {
                    AClassSupporter.controller.StartEngine();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engStatue = AClassSupporter.controller.GetEngineStatus();
            if (null != engStatue)
            {
                if (EngineState.Communicating == engStatue.State)
                {
                    AClassSupporter.controller.StopCommunication();
                }
                else
                {
                    AClassSupporter.controller.StartCommunication();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Engine State
            engStatue = AClassSupporter.controller.GetEngineStatus();
            if (null != engStatue)
            {
                textBox1.Text = engStatue.State.ToString();

                // Communication State
                if (EngineState.Communicating == engStatue.State)
                {
                    textBox2.Text = "Communicating";
                }
                else
                {
                    textBox2.Text = "Uncommunicating";
                }
            }
            else
            {
                textBox1.Text = "DeviceNotExist";
                textBox2.Text = "DeviceNotExist";
            }
        }
    }
}
