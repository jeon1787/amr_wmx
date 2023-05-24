namespace amr_wmx.UI
{
    partial class UCMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_engine = new System.Windows.Forms.Button();
            this.btn_comm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(79, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Communication";
            // 
            // btn_engine
            // 
            this.btn_engine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_engine.Location = new System.Drawing.Point(449, 53);
            this.btn_engine.Name = "btn_engine";
            this.btn_engine.Size = new System.Drawing.Size(80, 30);
            this.btn_engine.TabIndex = 2;
            this.btn_engine.Text = "ON";
            this.btn_engine.UseVisualStyleBackColor = true;
            this.btn_engine.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_comm
            // 
            this.btn_comm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comm.Location = new System.Drawing.Point(449, 91);
            this.btn_comm.Name = "btn_comm";
            this.btn_comm.Size = new System.Drawing.Size(80, 30);
            this.btn_comm.TabIndex = 3;
            this.btn_comm.Text = "ON";
            this.btn_comm.UseVisualStyleBackColor = true;
            this.btn_comm.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "None";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(204, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "None";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_comm);
            this.Controls.Add(this.btn_engine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(690, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_engine;
        private System.Windows.Forms.Button btn_comm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
