﻿namespace Bank_savings_system
{
    partial class 取款界面
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
            this.button_取款 = new System.Windows.Forms.Button();
            this.textBox_取款金额 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_返回 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_取款
            // 
            this.button_取款.Location = new System.Drawing.Point(35, 206);
            this.button_取款.Name = "button_取款";
            this.button_取款.Size = new System.Drawing.Size(75, 23);
            this.button_取款.TabIndex = 0;
            this.button_取款.Text = "取款";
            this.button_取款.UseVisualStyleBackColor = true;
            this.button_取款.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_取款金额
            // 
            this.textBox_取款金额.Location = new System.Drawing.Point(113, 76);
            this.textBox_取款金额.Name = "textBox_取款金额";
            this.textBox_取款金额.Size = new System.Drawing.Size(100, 21);
            this.textBox_取款金额.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "取款金额";
            // 
            // button_返回
            // 
            this.button_返回.Location = new System.Drawing.Point(137, 206);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(75, 23);
            this.button_返回.TabIndex = 4;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // 取款界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 261);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_取款金额);
            this.Controls.Add(this.button_取款);
            this.Name = "取款界面";
            this.Text = "取款界面";
            this.Load += new System.EventHandler(this.取款界面_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_取款;
        private System.Windows.Forms.TextBox textBox_取款金额;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_返回;
    }
}