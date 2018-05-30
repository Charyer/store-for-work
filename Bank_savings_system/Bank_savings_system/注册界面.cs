using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_savings_system
{
    public partial class 注册界面 : Form
    {
        private SQL s;
        private user u;
        public 注册界面(SQL s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            u = new user();
            try
            {
                if (textBox_用户名.TextLength < 1)
                {
                    MessageBox.Show("用户名不能为空，请输入用户名");
                }
                else
                    if (textBox_密码.TextLength < 1)
                    {
                        MessageBox.Show("密码不能为空，请输入密码");
                    }
                        else
                        if (textBox_密码.TextLength > 16)
                        {
                            MessageBox.Show("密码长度大于16，请重新输入密码");
                        }
                        else
                            if (u.user_save(s, textBox_用户名.Text.Trim()))
                            {
                                MessageBox.Show("用户名已存在,请重新用户名");
                            }
                            else
                            {
                                u.user_add(s, textBox_用户名.Text.Trim(), textBox_密码.Text.Trim());
                            }
            }
            catch (Exception eg)
            {
                MessageBox.Show(eg.Message);
            }

        }

        private void 注册界面_Load(object sender, EventArgs e)
        {

        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
