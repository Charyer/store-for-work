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
    public partial class 取款界面 : Form
    {
        private SQL sq;
        private string id;
        private 主界面 f;
        public 取款界面(SQL sq,string id,主界面 f)
        {
            InitializeComponent();
            this.sq = sq;
            this.id = id;
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            取款 f = new 取款();
            用户账户 g = new 用户账户();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            DataSet ds;
            try
            {
                if (!(int.Parse(textBox_取款金额.Text.Trim()) > 0))
                {
                    MessageBox.Show("请输入正确金额");
                }
                else
                {
                    ds = g.user_get(sq, id);
                    if ((int.Parse(ds.Tables[0].Rows[0]["活期存款"].ToString()) - int.Parse(textBox_取款金额.Text.Trim().ToString())) > 0)
                    {
                        f.money_add(sq, id, textBox_取款金额.Text.Trim().ToString(), dt);
                        g.user_update_less(sq, id, "活期存款", textBox_取款金额.Text.Trim());
                        MessageBox.Show("您取出了"+textBox_取款金额.Text.Trim()+"元");
                    }
                    else
                    {
                        MessageBox.Show("你的存款没这么多,请重新输入");
                    }
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void 取款界面_Load(object sender, EventArgs e)
        {
        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
