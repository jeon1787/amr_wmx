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
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_servo = new System.Windows.Forms.Button();
            this.lb_servo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_axis = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_not = new System.Windows.Forms.Label();
            this.btn_not = new System.Windows.Forms.Button();
            this.lb_org = new System.Windows.Forms.Label();
            this.btn_org = new System.Windows.Forms.Button();
            this.lb_pot = new System.Windows.Forms.Label();
            this.btn_pot = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 20);
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
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encoder";
            // 
            // tb_encoder
            // 
            this.tb_encoder.Location = new System.Drawing.Point(83, 58);
            this.tb_encoder.Name = "tb_encoder";
            this.tb_encoder.Size = new System.Drawing.Size(85, 21);
            this.tb_encoder.TabIndex = 2;
            this.tb_encoder.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(219, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(306, 58);
            this.tb_command.Name = "tb_command";
            this.tb_command.Size = new System.Drawing.Size(85, 21);
            this.tb_command.TabIndex = 4;
            this.tb_command.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accel(Decel)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jerk";
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(119, 67);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(85, 21);
            this.tb_speed.TabIndex = 8;
            this.tb_speed.Text = "0";
            // 
            // tb_accel
            // 
            this.tb_accel.Location = new System.Drawing.Point(119, 105);
            this.tb_accel.Name = "tb_accel";
            this.tb_accel.Size = new System.Drawing.Size(85, 21);
            this.tb_accel.TabIndex = 9;
            this.tb_accel.Text = "0";
            // 
            // tb_jerk
            // 
            this.tb_jerk.Location = new System.Drawing.Point(119, 142);
            this.tb_jerk.Name = "tb_jerk";
            this.tb_jerk.Size = new System.Drawing.Size(85, 21);
            this.tb_jerk.TabIndex = 10;
            this.tb_jerk.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(122, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jog";
            // 
            // btn_plus
            // 
            this.btn_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus.Location = new System.Drawing.Point(12, 318);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(100, 50);
            this.btn_plus.TabIndex = 13;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plusButton_MouseDown);
            this.btn_plus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plusButton_MouseUp);
            // 
            // btn_minus
            // 
            this.btn_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus.Location = new System.Drawing.Point(160, 318);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(100, 50);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minusButton_MouseDown);
            this.btn_minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minusButton_MouseUp);
            // 
            // btn_servo
            // 
            this.btn_servo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_servo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servo.Location = new System.Drawing.Point(222, 13);
            this.btn_servo.Name = "btn_servo";
            this.btn_servo.Size = new System.Drawing.Size(63, 36);
            this.btn_servo.TabIndex = 15;
            this.btn_servo.Text = "ON";
            this.btn_servo.UseVisualStyleBackColor = false;
            this.btn_servo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_servo
            // 
            this.lb_servo.AutoSize = true;
            this.lb_servo.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_servo.Location = new System.Drawing.Point(167, 22);
            this.lb_servo.Name = "lb_servo";
            this.lb_servo.Size = new System.Drawing.Size(49, 16);
            this.lb_servo.TabIndex = 16;
            this.lb_servo.Text = "Servo";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_stop
            // 
            this.btn_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stop.Location = new System.Drawing.Point(275, 318);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 50);
            this.btn_stop.TabIndex = 17;
            this.btn_stop.Text = "Manual Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_pot);
            this.groupBox1.Controls.Add(this.lb_pot);
            this.groupBox1.Controls.Add(this.btn_org);
            this.groupBox1.Controls.Add(this.lb_org);
            this.groupBox1.Controls.Add(this.btn_not);
            this.groupBox1.Controls.Add(this.lb_not);
            this.groupBox1.Controls.Add(this.tb_command);
            this.groupBox1.Controls.Add(this.lb_axis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_encoder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lb_servo);
            this.groupBox1.Controls.Add(this.btn_servo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 91);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AxisStatus";
            // 
            // lb_axis
            // 
            this.lb_axis.AutoSize = true;
            this.lb_axis.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_axis.Location = new System.Drawing.Point(6, 22);
            this.lb_axis.Name = "lb_axis";
            this.lb_axis.Size = new System.Drawing.Size(38, 16);
            this.lb_axis.TabIndex = 17;
            this.lb_axis.Text = "Axis";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_speed);
            this.groupBox2.Controls.Add(this.tb_accel);
            this.groupBox2.Controls.Add(this.tb_jerk);
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 212);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JogCommand";
            // 
            // lb_not
            // 
            this.lb_not.AutoSize = true;
            this.lb_not.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_not.Location = new System.Drawing.Point(339, 22);
            this.lb_not.Name = "lb_not";
            this.lb_not.Size = new System.Drawing.Size(39, 16);
            this.lb_not.TabIndex = 18;
            this.lb_not.Text = "NOT";
            // 
            // btn_not
            // 
            this.btn_not.BackColor = System.Drawing.Color.Gray;
            this.btn_not.Location = new System.Drawing.Point(384, 15);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(31, 29);
            this.btn_not.TabIndex = 19;
            this.btn_not.UseVisualStyleBackColor = false;
            // 
            // lb_org
            // 
            this.lb_org.AutoSize = true;
            this.lb_org.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_org.Location = new System.Drawing.Point(437, 22);
            this.lb_org.Name = "lb_org";
            this.lb_org.Size = new System.Drawing.Size(40, 16);
            this.lb_org.TabIndex = 20;
            this.lb_org.Text = "ORG";
            // 
            // btn_org
            // 
            this.btn_org.BackColor = System.Drawing.Color.Gray;
            this.btn_org.Location = new System.Drawing.Point(482, 15);
            this.btn_org.Name = "btn_org";
            this.btn_org.Size = new System.Drawing.Size(31, 29);
            this.btn_org.TabIndex = 21;
            this.btn_org.UseVisualStyleBackColor = false;
            // 
            // lb_pot
            // 
            this.lb_pot.AutoSize = true;
            this.lb_pot.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_pot.Location = new System.Drawing.Point(537, 22);
            this.lb_pot.Name = "lb_pot";
            this.lb_pot.Size = new System.Drawing.Size(38, 16);
            this.lb_pot.TabIndex = 22;
            this.lb_pot.Text = "POT";
            // 
            // btn_pot
            // 
            this.btn_pot.BackColor = System.Drawing.Color.Gray;
            this.btn_pot.Location = new System.Drawing.Point(582, 15);
            this.btn_pot.Name = "btn_pot";
            this.btn_pot.Size = new System.Drawing.Size(31, 29);
            this.btn_pot.TabIndex = 23;
            this.btn_pot.UseVisualStyleBackColor = false;
            // 
            // UCServoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
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
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_servo;
        private System.Windows.Forms.Label lb_servo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_axis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_not;
        private System.Windows.Forms.Button btn_pot;
        private System.Windows.Forms.Label lb_pot;
        private System.Windows.Forms.Button btn_org;
        private System.Windows.Forms.Label lb_org;
        private System.Windows.Forms.Button btn_not;
    }
}
