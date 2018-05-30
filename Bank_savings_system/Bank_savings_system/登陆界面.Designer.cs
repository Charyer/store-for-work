namespace Bank_savings_system
{
    partial class 登陆界面
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
            this.button_登陆 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label_注册 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_登陆
            // 
            this.button_登陆.Location = new System.Drawing.Point(150, 252);
            this.button_登陆.Name = "button_登陆";
            this.button_登陆.Size = new System.Drawing.Size(75, 23);
            this.button_登陆.TabIndex = 0;
            this.button_登陆.Text = "登陆";
            this.button_登陆.UseVisualStyleBackColor = true;
            this.button_登陆.Click += new System.EventHandler(this.button_登陆_Click);
            // 
            // button_退出
            // 
            this.button_退出.Location = new System.Drawing.Point(303, 246);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(75, 23);
            this.button_退出.TabIndex = 1;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label_注册
            // 
            this.label_注册.AutoSize = true;
            this.label_注册.Location = new System.Drawing.Point(458, 257);
            this.label_注册.Name = "label_注册";
            this.label_注册.Size = new System.Drawing.Size(53, 12);
            this.label_注册.TabIndex = 3;
            this.label_注册.Text = "注册用户";
            this.label_注册.Click += new System.EventHandler(this.label_注册_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "密  码：";
            // 
            // textBox_密码
            // 
            this.textBox_密码.Location = new System.Drawing.Point(303, 123);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(196, 21);
            this.textBox_密码.TabIndex = 6;
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Location = new System.Drawing.Point(303, 65);
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(196, 21);
            this.textBox_用户名.TabIndex = 7;
            // 
            // 登陆界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 313);
            this.Controls.Add(this.textBox_用户名);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_注册);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_登陆);
            this.Name = "登陆界面";
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.登陆界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_登陆;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Label label_注册;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.TextBox textBox_用户名;
    }
}