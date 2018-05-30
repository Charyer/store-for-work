namespace Bank_savings_system
{
    partial class 存款界面
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_存款项目 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_金额 = new System.Windows.Forms.TextBox();
            this.button_确定存款 = new System.Windows.Forms.Button();
            this.button_返回 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_利率 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_利率)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择你要存款的项目:";
            // 
            // comboBox_存款项目
            // 
            this.comboBox_存款项目.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_存款项目.FormattingEnabled = true;
            this.comboBox_存款项目.Location = new System.Drawing.Point(165, 72);
            this.comboBox_存款项目.Name = "comboBox_存款项目";
            this.comboBox_存款项目.Size = new System.Drawing.Size(121, 20);
            this.comboBox_存款项目.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入您要存款的金额:";
            // 
            // textBox_金额
            // 
            this.textBox_金额.Location = new System.Drawing.Point(165, 135);
            this.textBox_金额.Name = "textBox_金额";
            this.textBox_金额.Size = new System.Drawing.Size(121, 21);
            this.textBox_金额.TabIndex = 3;
            // 
            // button_确定存款
            // 
            this.button_确定存款.Location = new System.Drawing.Point(50, 227);
            this.button_确定存款.Name = "button_确定存款";
            this.button_确定存款.Size = new System.Drawing.Size(75, 23);
            this.button_确定存款.TabIndex = 6;
            this.button_确定存款.Text = "确定存款";
            this.button_确定存款.UseVisualStyleBackColor = true;
            this.button_确定存款.Click += new System.EventHandler(this.button_确定存款_Click);
            // 
            // button_返回
            // 
            this.button_返回.Location = new System.Drawing.Point(190, 222);
            this.button_返回.Name = "button_返回";
            this.button_返回.Size = new System.Drawing.Size(75, 23);
            this.button_返回.TabIndex = 7;
            this.button_返回.Text = "返回";
            this.button_返回.UseVisualStyleBackColor = true;
            this.button_返回.Click += new System.EventHandler(this.button_返回_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "利率表";
            // 
            // dataGridView_利率
            // 
            this.dataGridView_利率.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_利率.Location = new System.Drawing.Point(314, 72);
            this.dataGridView_利率.Name = "dataGridView_利率";
            this.dataGridView_利率.RowTemplate.Height = 23;
            this.dataGridView_利率.Size = new System.Drawing.Size(300, 178);
            this.dataGridView_利率.TabIndex = 9;
            // 
            // 存款界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 257);
            this.Controls.Add(this.dataGridView_利率);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_返回);
            this.Controls.Add(this.button_确定存款);
            this.Controls.Add(this.textBox_金额);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_存款项目);
            this.Controls.Add(this.label1);
            this.Name = "存款界面";
            this.Text = "存款界面";
            this.Load += new System.EventHandler(this.存款界面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_利率)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_存款项目;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_金额;
        private System.Windows.Forms.Button button_确定存款;
        private System.Windows.Forms.Button button_返回;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView_利率;
    }
}