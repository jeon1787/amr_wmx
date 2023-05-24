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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_encoder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_vspeed = new System.Windows.Forms.TextBox();
            this.tb_vaccel = new System.Windows.Forms.TextBox();
            this.tb_vjerk = new System.Windows.Forms.TextBox();
            this.btn_plus_velmove = new System.Windows.Forms.Button();
            this.btn_minus_velmove = new System.Windows.Forms.Button();
            this.btn_servo = new System.Windows.Forms.Button();
            this.lb_servo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_vstop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pot = new System.Windows.Forms.Button();
            this.lb_pot = new System.Windows.Forms.Label();
            this.btn_org = new System.Windows.Forms.Button();
            this.lb_org = new System.Windows.Forms.Label();
            this.btn_not = new System.Windows.Forms.Button();
            this.lb_not = new System.Windows.Forms.Label();
            this.lb_axis = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tab_velmove = new System.Windows.Forms.TabPage();
            this.lb_jog = new System.Windows.Forms.Label();
            this.tab_relmove = new System.Windows.Forms.TabPage();
            this.tb_rtarget = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rstop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_rspeed = new System.Windows.Forms.TextBox();
            this.btn_relmove = new System.Windows.Forms.Button();
            this.tb_raccel = new System.Windows.Forms.TextBox();
            this.tb_rjerk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tab_absmove = new System.Windows.Forms.TabPage();
            this.tb_atarget = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_astop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_aspeed = new System.Windows.Forms.TextBox();
            this.btn_absmove = new System.Windows.Forms.Button();
            this.tb_aaccel = new System.Windows.Forms.TextBox();
            this.tb_ajerk = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabcontrol1.SuspendLayout();
            this.tab_velmove.SuspendLayout();
            this.tab_relmove.SuspendLayout();
            this.tab_absmove.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(50, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(101, 20);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encoder";
            // 
            // tb_encoder
            // 
            this.tb_encoder.Location = new System.Drawing.Point(83, 58);
            this.tb_encoder.Name = "tb_encoder";
            this.tb_encoder.ReadOnly = true;
            this.tb_encoder.Size = new System.Drawing.Size(85, 21);
            this.tb_encoder.TabIndex = 2;
            this.tb_encoder.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(219, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // tb_command
            // 
            this.tb_command.Location = new System.Drawing.Point(306, 58);
            this.tb_command.Name = "tb_command";
            this.tb_command.ReadOnly = true;
            this.tb_command.Size = new System.Drawing.Size(85, 21);
            this.tb_command.TabIndex = 4;
            this.tb_command.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(34, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(34, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Accel(Decel)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(34, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jerk";
            // 
            // tb_vspeed
            // 
            this.tb_vspeed.Location = new System.Drawing.Point(139, 14);
            this.tb_vspeed.Name = "tb_vspeed";
            this.tb_vspeed.Size = new System.Drawing.Size(85, 21);
            this.tb_vspeed.TabIndex = 8;
            this.tb_vspeed.Text = "0.0";
            // 
            // tb_vaccel
            // 
            this.tb_vaccel.Location = new System.Drawing.Point(139, 41);
            this.tb_vaccel.Name = "tb_vaccel";
            this.tb_vaccel.Size = new System.Drawing.Size(85, 21);
            this.tb_vaccel.TabIndex = 9;
            this.tb_vaccel.Text = "0.0";
            // 
            // tb_vjerk
            // 
            this.tb_vjerk.Location = new System.Drawing.Point(139, 68);
            this.tb_vjerk.Name = "tb_vjerk";
            this.tb_vjerk.Size = new System.Drawing.Size(85, 21);
            this.tb_vjerk.TabIndex = 10;
            this.tb_vjerk.Text = "0.0";
            // 
            // btn_plus_velmove
            // 
            this.btn_plus_velmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_plus_velmove.Location = new System.Drawing.Point(37, 166);
            this.btn_plus_velmove.Name = "btn_plus_velmove";
            this.btn_plus_velmove.Size = new System.Drawing.Size(100, 50);
            this.btn_plus_velmove.TabIndex = 13;
            this.btn_plus_velmove.Text = "+";
            this.btn_plus_velmove.UseVisualStyleBackColor = true;
            this.btn_plus_velmove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_plus_velmove_MouseDown);
            this.btn_plus_velmove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_plus_velmove_MouseUp);
            // 
            // btn_minus_velmove
            // 
            this.btn_minus_velmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minus_velmove.Location = new System.Drawing.Point(218, 166);
            this.btn_minus_velmove.Name = "btn_minus_velmove";
            this.btn_minus_velmove.Size = new System.Drawing.Size(100, 50);
            this.btn_minus_velmove.TabIndex = 14;
            this.btn_minus_velmove.Text = "-";
            this.btn_minus_velmove.UseVisualStyleBackColor = true;
            this.btn_minus_velmove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_minus_velmove_MouseDown);
            this.btn_minus_velmove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_minus_velmove_MouseUp);
            // 
            // btn_servo
            // 
            this.btn_servo.BackColor = System.Drawing.Color.White;
            this.btn_servo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servo.Location = new System.Drawing.Point(222, 13);
            this.btn_servo.Name = "btn_servo";
            this.btn_servo.Size = new System.Drawing.Size(63, 36);
            this.btn_servo.TabIndex = 15;
            this.btn_servo.Text = "ON";
            this.btn_servo.UseVisualStyleBackColor = false;
            this.btn_servo.Click += new System.EventHandler(this.btn_servo_Click);
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
            // btn_vstop
            // 
            this.btn_vstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vstop.Location = new System.Drawing.Point(536, 166);
            this.btn_vstop.Name = "btn_vstop";
            this.btn_vstop.Size = new System.Drawing.Size(100, 50);
            this.btn_vstop.TabIndex = 17;
            this.btn_vstop.Text = "Stop Move";
            this.btn_vstop.UseVisualStyleBackColor = true;
            this.btn_vstop.Click += new System.EventHandler(this.btn_vstop_Click);
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
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.lb_servo);
            this.groupBox1.Controls.Add(this.btn_servo);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 91);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AxisStatus";
            // 
            // btn_pot
            // 
            this.btn_pot.BackColor = System.Drawing.Color.White;
            this.btn_pot.Location = new System.Drawing.Point(582, 15);
            this.btn_pot.Name = "btn_pot";
            this.btn_pot.Size = new System.Drawing.Size(31, 29);
            this.btn_pot.TabIndex = 23;
            this.btn_pot.UseVisualStyleBackColor = false;
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
            // btn_org
            // 
            this.btn_org.BackColor = System.Drawing.Color.White;
            this.btn_org.Location = new System.Drawing.Point(482, 15);
            this.btn_org.Name = "btn_org";
            this.btn_org.Size = new System.Drawing.Size(31, 29);
            this.btn_org.TabIndex = 21;
            this.btn_org.UseVisualStyleBackColor = false;
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
            // btn_not
            // 
            this.btn_not.BackColor = System.Drawing.Color.White;
            this.btn_not.Location = new System.Drawing.Point(384, 15);
            this.btn_not.Name = "btn_not";
            this.btn_not.Size = new System.Drawing.Size(31, 29);
            this.btn_not.TabIndex = 19;
            this.btn_not.UseVisualStyleBackColor = false;
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
            this.groupBox2.Controls.Add(this.tabcontrol1);
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 277);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Move Command";
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tab_velmove);
            this.tabcontrol1.Controls.Add(this.tab_relmove);
            this.tabcontrol1.Controls.Add(this.tab_absmove);
            this.tabcontrol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol1.Location = new System.Drawing.Point(3, 17);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(678, 257);
            this.tabcontrol1.TabIndex = 24;
            // 
            // tab_velmove
            // 
            this.tab_velmove.Controls.Add(this.lb_jog);
            this.tab_velmove.Controls.Add(this.label3);
            this.tab_velmove.Controls.Add(this.btn_vstop);
            this.tab_velmove.Controls.Add(this.label4);
            this.tab_velmove.Controls.Add(this.btn_minus_velmove);
            this.tab_velmove.Controls.Add(this.tb_vspeed);
            this.tab_velmove.Controls.Add(this.btn_plus_velmove);
            this.tab_velmove.Controls.Add(this.tb_vaccel);
            this.tab_velmove.Controls.Add(this.tb_vjerk);
            this.tab_velmove.Controls.Add(this.label6);
            this.tab_velmove.Location = new System.Drawing.Point(4, 22);
            this.tab_velmove.Name = "tab_velmove";
            this.tab_velmove.Padding = new System.Windows.Forms.Padding(3);
            this.tab_velmove.Size = new System.Drawing.Size(670, 231);
            this.tab_velmove.TabIndex = 0;
            this.tab_velmove.Text = "Velocity Move";
            this.tab_velmove.UseVisualStyleBackColor = true;
            // 
            // lb_jog
            // 
            this.lb_jog.AutoSize = true;
            this.lb_jog.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_jog.Location = new System.Drawing.Point(163, 181);
            this.lb_jog.Name = "lb_jog";
            this.lb_jog.Size = new System.Drawing.Size(32, 16);
            this.lb_jog.TabIndex = 18;
            this.lb_jog.Text = "Jog";
            // 
            // tab_relmove
            // 
            this.tab_relmove.Controls.Add(this.tb_rtarget);
            this.tab_relmove.Controls.Add(this.label9);
            this.tab_relmove.Controls.Add(this.label5);
            this.tab_relmove.Controls.Add(this.btn_rstop);
            this.tab_relmove.Controls.Add(this.label7);
            this.tab_relmove.Controls.Add(this.tb_rspeed);
            this.tab_relmove.Controls.Add(this.btn_relmove);
            this.tab_relmove.Controls.Add(this.tb_raccel);
            this.tab_relmove.Controls.Add(this.tb_rjerk);
            this.tab_relmove.Controls.Add(this.label8);
            this.tab_relmove.Location = new System.Drawing.Point(4, 22);
            this.tab_relmove.Name = "tab_relmove";
            this.tab_relmove.Padding = new System.Windows.Forms.Padding(3);
            this.tab_relmove.Size = new System.Drawing.Size(670, 231);
            this.tab_relmove.TabIndex = 1;
            this.tab_relmove.Text = "Relative Move";
            this.tab_relmove.UseVisualStyleBackColor = true;
            // 
            // tb_rtarget
            // 
            this.tb_rtarget.Location = new System.Drawing.Point(139, 95);
            this.tb_rtarget.Name = "tb_rtarget";
            this.tb_rtarget.Size = new System.Drawing.Size(85, 21);
            this.tb_rtarget.TabIndex = 27;
            this.tb_rtarget.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(34, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Target";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(34, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Speed";
            // 
            // btn_rstop
            // 
            this.btn_rstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rstop.Location = new System.Drawing.Point(536, 166);
            this.btn_rstop.Name = "btn_rstop";
            this.btn_rstop.Size = new System.Drawing.Size(100, 50);
            this.btn_rstop.TabIndex = 25;
            this.btn_rstop.Text = "Stop Move";
            this.btn_rstop.UseVisualStyleBackColor = true;
            this.btn_rstop.Click += new System.EventHandler(this.btn_rstop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(34, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Accel(Decel)";
            // 
            // tb_rspeed
            // 
            this.tb_rspeed.Location = new System.Drawing.Point(139, 14);
            this.tb_rspeed.Name = "tb_rspeed";
            this.tb_rspeed.Size = new System.Drawing.Size(85, 21);
            this.tb_rspeed.TabIndex = 21;
            this.tb_rspeed.Text = "0.0";
            // 
            // btn_relmove
            // 
            this.btn_relmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relmove.Location = new System.Drawing.Point(37, 166);
            this.btn_relmove.Name = "btn_relmove";
            this.btn_relmove.Size = new System.Drawing.Size(100, 50);
            this.btn_relmove.TabIndex = 24;
            this.btn_relmove.Text = "Start Move";
            this.btn_relmove.UseVisualStyleBackColor = true;
            this.btn_relmove.Click += new System.EventHandler(this.btn_relmove_Click);
            // 
            // tb_raccel
            // 
            this.tb_raccel.Location = new System.Drawing.Point(139, 41);
            this.tb_raccel.Name = "tb_raccel";
            this.tb_raccel.Size = new System.Drawing.Size(85, 21);
            this.tb_raccel.TabIndex = 22;
            this.tb_raccel.Text = "0.0";
            // 
            // tb_rjerk
            // 
            this.tb_rjerk.Location = new System.Drawing.Point(139, 68);
            this.tb_rjerk.Name = "tb_rjerk";
            this.tb_rjerk.Size = new System.Drawing.Size(85, 21);
            this.tb_rjerk.TabIndex = 23;
            this.tb_rjerk.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(34, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Jerk";
            // 
            // tab_absmove
            // 
            this.tab_absmove.Controls.Add(this.tb_atarget);
            this.tab_absmove.Controls.Add(this.label10);
            this.tab_absmove.Controls.Add(this.label11);
            this.tab_absmove.Controls.Add(this.btn_astop);
            this.tab_absmove.Controls.Add(this.label12);
            this.tab_absmove.Controls.Add(this.tb_aspeed);
            this.tab_absmove.Controls.Add(this.btn_absmove);
            this.tab_absmove.Controls.Add(this.tb_aaccel);
            this.tab_absmove.Controls.Add(this.tb_ajerk);
            this.tab_absmove.Controls.Add(this.label13);
            this.tab_absmove.Location = new System.Drawing.Point(4, 22);
            this.tab_absmove.Name = "tab_absmove";
            this.tab_absmove.Padding = new System.Windows.Forms.Padding(3);
            this.tab_absmove.Size = new System.Drawing.Size(670, 231);
            this.tab_absmove.TabIndex = 2;
            this.tab_absmove.Text = "Absolute Move";
            this.tab_absmove.UseVisualStyleBackColor = true;
            // 
            // tb_atarget
            // 
            this.tb_atarget.Location = new System.Drawing.Point(139, 95);
            this.tb_atarget.Name = "tb_atarget";
            this.tb_atarget.Size = new System.Drawing.Size(85, 21);
            this.tb_atarget.TabIndex = 37;
            this.tb_atarget.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(34, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Target";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(34, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Speed";
            // 
            // btn_astop
            // 
            this.btn_astop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_astop.Location = new System.Drawing.Point(536, 166);
            this.btn_astop.Name = "btn_astop";
            this.btn_astop.Size = new System.Drawing.Size(100, 50);
            this.btn_astop.TabIndex = 35;
            this.btn_astop.Text = "Stop Move";
            this.btn_astop.UseVisualStyleBackColor = true;
            this.btn_astop.Click += new System.EventHandler(this.btn_astop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(34, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Accel(Decel)";
            // 
            // tb_aspeed
            // 
            this.tb_aspeed.Location = new System.Drawing.Point(139, 14);
            this.tb_aspeed.Name = "tb_aspeed";
            this.tb_aspeed.Size = new System.Drawing.Size(85, 21);
            this.tb_aspeed.TabIndex = 31;
            this.tb_aspeed.Text = "0.0";
            // 
            // btn_absmove
            // 
            this.btn_absmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_absmove.Location = new System.Drawing.Point(37, 166);
            this.btn_absmove.Name = "btn_absmove";
            this.btn_absmove.Size = new System.Drawing.Size(100, 50);
            this.btn_absmove.TabIndex = 34;
            this.btn_absmove.Text = "Start Move";
            this.btn_absmove.UseVisualStyleBackColor = true;
            this.btn_absmove.Click += new System.EventHandler(this.btn_absmove_Click);
            // 
            // tb_aaccel
            // 
            this.tb_aaccel.Location = new System.Drawing.Point(139, 41);
            this.tb_aaccel.Name = "tb_aaccel";
            this.tb_aaccel.Size = new System.Drawing.Size(85, 21);
            this.tb_aaccel.TabIndex = 32;
            this.tb_aaccel.Text = "0.0";
            // 
            // tb_ajerk
            // 
            this.tb_ajerk.Location = new System.Drawing.Point(139, 68);
            this.tb_ajerk.Name = "tb_ajerk";
            this.tb_ajerk.Size = new System.Drawing.Size(85, 21);
            this.tb_ajerk.TabIndex = 33;
            this.tb_ajerk.Text = "0.0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(34, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Jerk";
            // 
            // UCServoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCServoControl";
            this.Size = new System.Drawing.Size(690, 380);
            this.Load += new System.EventHandler(this.UCServoControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabcontrol1.ResumeLayout(false);
            this.tab_velmove.ResumeLayout(false);
            this.tab_velmove.PerformLayout();
            this.tab_relmove.ResumeLayout(false);
            this.tab_relmove.PerformLayout();
            this.tab_absmove.ResumeLayout(false);
            this.tab_absmove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_encoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_vspeed;
        private System.Windows.Forms.TextBox tb_vaccel;
        private System.Windows.Forms.TextBox tb_vjerk;
        private System.Windows.Forms.Button btn_plus_velmove;
        private System.Windows.Forms.Button btn_minus_velmove;
        private System.Windows.Forms.Button btn_servo;
        private System.Windows.Forms.Label lb_servo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_vstop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_axis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_not;
        private System.Windows.Forms.Button btn_pot;
        private System.Windows.Forms.Label lb_pot;
        private System.Windows.Forms.Button btn_org;
        private System.Windows.Forms.Label lb_org;
        private System.Windows.Forms.Button btn_not;
        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tab_velmove;
        private System.Windows.Forms.Label lb_jog;
        private System.Windows.Forms.TabPage tab_relmove;
        private System.Windows.Forms.TextBox tb_rtarget;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rstop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_rspeed;
        private System.Windows.Forms.Button btn_relmove;
        private System.Windows.Forms.TextBox tb_raccel;
        private System.Windows.Forms.TextBox tb_rjerk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tab_absmove;
        private System.Windows.Forms.TextBox tb_atarget;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_astop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_aspeed;
        private System.Windows.Forms.Button btn_absmove;
        private System.Windows.Forms.TextBox tb_aaccel;
        private System.Windows.Forms.TextBox tb_ajerk;
        private System.Windows.Forms.Label label13;
    }
}
