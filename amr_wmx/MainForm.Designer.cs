namespace amr_wmx
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_servo_control = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 380);
            this.panel1.TabIndex = 0;
            // 
            // btn_main
            // 
            this.btn_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_main.Location = new System.Drawing.Point(12, 65);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(92, 50);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "Main\r\n";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_servo_control
            // 
            this.btn_servo_control.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servo_control.Location = new System.Drawing.Point(12, 121);
            this.btn_servo_control.Name = "btn_servo_control";
            this.btn_servo_control.Size = new System.Drawing.Size(92, 50);
            this.btn_servo_control.TabIndex = 2;
            this.btn_servo_control.Text = "Servo\r\nControl";
            this.btn_servo_control.UseVisualStyleBackColor = true;
            this.btn_servo_control.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_servo_control);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_servo_control;
    }
}

