namespace Bank_savings_system
{
    partial class 注册界面
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
            this.button_注册 = new System.Windows.Forms.Button();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_注册
            // 
            this.button_注册.Location = new System.Drawing.Point(48, 227);
            this.button_注册.Name = "button_注册";
            this.button_注册.Size = new System.Drawing.Size(75, 23);
            this.button_注册.TabIndex = 0;
            this.button_注册.Text = "注册";
            this.button_注册.UseVisualStyleBackColor = true;
            this.button_注册.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_返回
            // 
            this.button_返回.Location = new System.Drawing.Point(256, 227);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(75, 23);
            this.button_返回.TabIndex = 1;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密  码：";
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Location = new System.Drawing.Point(167, 67);
            this.textBox_用户名.Multiline = true;
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(164, 21);
            this.textBox_用户名.TabIndex = 4;
            // 
            // textBox_密码
            // 
            this.textBox_密码.Location = new System.Drawing.Point(167, 141);
            this.textBox_密码.Multiline = true;
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(164, 21);
            this.textBox_密码.TabIndex = 5;
            // 
            // 注册界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 303);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.textBox_用户名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.button_注册);
            this.Name = "注册界面";
            this.Text = "注册界面";
            this.Load += new System.EventHandler(this.注册界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_注册;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_密码;
    }
}