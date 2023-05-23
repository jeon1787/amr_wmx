using amr_wmx.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amr_wmx
{
    public partial class MainForm : Form
    {
        private UserControl uc_last;
        private UCMain ucMain;
        private UCServoControl ucServoControl;
        private WMXController controller;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ucMain = new UCMain();
            ucServoControl = new UCServoControl();
            SetContents(ucMain);

            controller = WMXController.GetInstance();
        }

        public void SetContents(UserControl uc)
        {
            if (uc == uc_last) return;
            if (null != uc_last) uc_last.Hide();

            uc_last = uc;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Show();
            uc.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetContents(ucMain);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetContents(ucServoControl);
        }
    }
}
