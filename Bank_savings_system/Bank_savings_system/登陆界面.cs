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
    public partial class 登陆界面 : Form
    {
        private SQL sq;
        private string id;
        private string user_name,user_mima;
        
        public 登陆界面()
        {
            InitializeComponent();
        }

        private void 登陆界面_Load(object sender, EventArgs e)
        {
            sq = new SQL();
            sq.sql_start();
        }

        private void label_注册_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            注册界面 s = new 注册界面(sq);
            s.ShowDialog();
            this.Visible = true;
        }

        private void button_登陆_Click(object sender, EventArgs e)
        {
            user s = new user();
            用户账户 gg = new 用户账户();
            user_name = textBox_用户名.Text.Trim();
            user_mima = textBox_密码.Text.Trim();
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
                        if (!s.user_save(sq, textBox_用户名.Text.Trim()))
                        {
                            MessageBox.Show("用户名错误,请输入正确的用户名");
                        }
                        else
                        {
                            this.Visible = false;
                            textBox_用户名.Text = "";
                            textBox_密码.Text = "";
                            if (s.user_land(sq, user_name, user_mima))
                            {
                                id = sq.sql_select("select * from 用户 where 用户名=" + user_name + "", "id");
                                if (!gg.user_save(sq, id))
                                {
                                    gg.user_add(sq, id, id);
                                }
                                主界面 f = new 主界面(sq, id, this);
                                f.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("密码错误");
                                this.Visible = true;
                            }
                        }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
