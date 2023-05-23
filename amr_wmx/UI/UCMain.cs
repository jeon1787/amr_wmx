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
            timer1.Enabled = true;
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
            string engState = "Stopped";
            string commState = "Stopped";
            string button1Text = "ON";
            string button2Text = "ON";

            switch (engStatue.State)
            {
                case EngineState.Idle:
                    engState = "Idle";
                    break;
                case EngineState.Running:
                    engState = "Running";
                    button1Text = "OFF";
                    break;
                case EngineState.Communicating:
                    engState = "Communicating";
                    commState = "Communicating";
                    button1Text = "OFF";
                    button2Text = "OFF";
                    break;
                case EngineState.Shutdown:
                    engState = "Shutdown";
                    break;
                case EngineState.Unknown:
                    engState = "Unknown";
                    break;
                default:
                    engState = "Unknown";
                    commState = "Unknown";
                    break;
            }
            textBox1.Text = engState;
            textBox2.Text = commState;
            button1.Text = button1Text;
            button2.Text = button2Text;
        }
    }
}
