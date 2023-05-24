namespace amr_wmx.UI
{
    partial class UCServoControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_encoder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_speed = new System.Windows.Forms.TextBox();
            this.tb_accel = new System.Windows.Forms.TextBox();
            this.tb_jerk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.servoOnOff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.manualStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(338, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encoder";
            // 
            // tb_encoder
            // 
            this.tb_encoder.Location = new System.Drawing.Point(425, 24);
            this.tb_encoder.Name = "tb_encoder";
            this.tb_encoder.Size = new System.Drawing.Size(85, 21);
            this.tb_encoder.TabIndex = 2;
            this.tb_encoder.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(336, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(425, 56);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(85, 21);
            this.tb_command.TabIndex = 4;
            this.tb_command.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(77, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(77, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accel(Decel)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(77, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jerk";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(183, 24);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(85, 21);
            this.tb_speed.TabIndex = 8;
            this.tb_speed.Text = "0";
            // 
            // tb_accel
            // 
            this.tb_accel.Location = new System.Drawing.Point(183, 56);
            this.tb_accel.Name = "tb_accel";
            this.tb_accel.Size = new System.Drawing.Size(85, 21);
            this.tb_accel.TabIndex = 9;
            this.tb_accel.Text = "0";
            // 
            // tb_jerk
            // 
            this.tb_jerk.Location = new System.Drawing.Point(183, 88);
            this.tb_jerk.Name = "tb_jerk";
            this.tb_jerk.Size = new System.Drawing.Size(85, 21);
            this.tb_jerk.TabIndex = 10;
            this.tb_jerk.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(205, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jog";
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(70, 265);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(100, 50);
            this.plusButton.TabIndex = 13;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusButton_MouseDown);
            this.plusButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusButton_MouseUp);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(265, 265);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(100, 50);
            this.minusButton.TabIndex = 14;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusButton_MouseDown);
            this.minusButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusButton_MouseUp);
            // 
            // servoOnOff
            // 
            this.servoOnOff.Location = new System.Drawing.Point(528, 13);
            this.servoOnOff.Name = "servoOnOff";
            this.servoOnOff.Size = new System.Drawing.Size(63, 36);
            this.servoOnOff.TabIndex = 15;
            this.servoOnOff.Text = "ON";
            this.servoOnOff.UseVisualStyleBackColor = true;
            this.servoOnOff.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(461, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Servo";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // manualStop
            // 
            this.manualStop.Location = new System.Drawing.Point(518, 265);
            this.manualStop.Name = "manualStop";
            this.manualStop.Size = new System.Drawing.Size(100, 50);
            this.manualStop.TabIndex = 17;
            this.manualStop.Text = "Manual Stop";
            this.manualStop.UseVisualStyleBackColor = true;
            this.manualStop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.servoOnOff);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 55);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AxisStatus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(74, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Axis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_speed);
            this.groupBox2.Controls.Add(this.tb_accel);
            this.groupBox2.Controls.Add(this.tb_jerk);
            this.groupBox2.Controls.Add(this.tb_command);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_encoder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 133);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JogCommand";
            // 
            // UCServoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.manualStop);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.label7);
            this.Name = "UCServoControl";
            this.Size = new System.Drawing.Size(690, 380);
            this.Load += new System.EventHandler(this.UCServoControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_encoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.TextBox tb_accel;
        private System.Windows.Forms.TextBox tb_jerk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button servoOnOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button manualStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
