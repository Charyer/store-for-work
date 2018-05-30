namespace Bank_savings_system
{
    partial class 主界面
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_存款 = new System.Windows.Forms.Button();
            this.button_取款 = new System.Windows.Forms.Button();
            this.label_名称 = new System.Windows.Forms.Label();
            this.label_活期存款 = new System.Windows.Forms.Label();
            this.label_定期存款 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_记录 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_savings_system.Properties.Resources.pt_user;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(63, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "昵    称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "活期存款：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "定期存款：";
            // 
            // button_存款
            // 
            this.button_存款.Location = new System.Drawing.Point(44, 198);
            this.button_存款.Name = "button_存款";
            this.button_存款.Size = new System.Drawing.Size(158, 70);
            this.button_存款.TabIndex = 4;
            this.button_存款.Text = "存款";
            this.button_存款.UseVisualStyleBackColor = true;
            this.button_存款.Click += new System.EventHandler(this.button_存款_Click);
            // 
            // button_取款
            // 
            this.button_取款.Location = new System.Drawing.Point(44, 308);
            this.button_取款.Name = "button_取款";
            this.button_取款.Size = new System.Drawing.Size(159, 67);
            this.button_取款.TabIndex = 5;
            this.button_取款.Text = "取款";
            this.button_取款.UseVisualStyleBackColor = true;
            this.button_取款.Click += new System.EventHandler(this.button_取款_Click);
            // 
            // label_名称
            // 
            this.label_名称.AutoSize = true;
            this.label_名称.Location = new System.Drawing.Point(282, 39);
            this.label_名称.Name = "label_名称";
            this.label_名称.Size = new System.Drawing.Size(41, 12);
            this.label_名称.TabIndex = 11;
            this.label_名称.Text = "label7";
            // 
            // label_活期存款
            // 
            this.label_活期存款.AutoSize = true;
            this.label_活期存款.Location = new System.Drawing.Point(278, 85);
            this.label_活期存款.Name = "label_活期存款";
            this.label_活期存款.Size = new System.Drawing.Size(41, 12);
            this.label_活期存款.TabIndex = 12;
            this.label_活期存款.Text = "label8";
            // 
            // label_定期存款
            // 
            this.label_定期存款.AutoSize = true;
            this.label_定期存款.Location = new System.Drawing.Point(282, 135);
            this.label_定期存款.Name = "label_定期存款";
            this.label_定期存款.Size = new System.Drawing.Size(41, 12);
            this.label_定期存款.TabIndex = 13;
            this.label_定期存款.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "当前时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(352, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_记录
            // 
            this.button_记录.Location = new System.Drawing.Point(337, 198);
            this.button_记录.Name = "button_记录";
            this.button_记录.Size = new System.Drawing.Size(155, 70);
            this.button_记录.TabIndex = 18;
            this.button_记录.Text = "查看存款(取款)记录";
            this.button_记录.UseVisualStyleBackColor = true;
            this.button_记录.Click += new System.EventHandler(this.button_记录_Click);
            // 
            // button_退出
            // 
            this.button_退出.Location = new System.Drawing.Point(337, 308);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(155, 67);
            this.button_退出.TabIndex = 19;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // 主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 387);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_记录);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_定期存款);
            this.Controls.Add(this.label_活期存款);
            this.Controls.Add(this.label_名称);
            this.Controls.Add(this.button_取款);
            this.Controls.Add(this.button_存款);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "主界面";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.主界面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_存款;
        private System.Windows.Forms.Button button_取款;
        private System.Windows.Forms.Label label_名称;
        private System.Windows.Forms.Label label_活期存款;
        private System.Windows.Forms.Label label_定期存款;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_记录;
        private System.Windows.Forms.Button button_退出;
    }
}