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
    public partial class 存款界面 : Form
    {
        private string id;
        private SQL sq;
        主界面 f;
        public 存款界面(主界面 f,SQL sq,string id)
        {
            InitializeComponent();
            this.f = f;
            this.id = id;
            this.sq = sq;
        }

        private void button_返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 存款界面_Load(object sender, EventArgs e)
        {
            DataSet ds;
            string select_message = "select 存款类型,存款时长,存款利率 from 存款利率表";
            ds = sq.sql_select(select_message);
            for (int i = 0; i <ds.Tables[0].Rows.Count; i++)
            {
                comboBox_存款项目.Items.Add(ds.Tables[0].Rows[i]["存款类型"].ToString());
            }
            dataGridView_利率.DataSource = ds.Tables[0];
        }

        private void button_确定存款_Click(object sender, EventArgs e)
        {
            存款 c = new 存款();
            用户账户 f = new 用户账户();
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string g;
            if (comboBox_存款项目.Text.Trim().Equals("活期存款"))
            {
                g = "活期存款";
            }
            else
                g = "定期存款";
            try
            {
                if (comboBox_存款项目.Text.Length <= 0)
                {
                    MessageBox.Show("请选择您要存款的类型");
                }
                else
                    if (textBox_金额.Text.Length <= 0)
                    {
                        MessageBox.Show("输入您要存款的金额");
                    }
                    else
                        if (!(int.Parse(textBox_金额.Text) > 0))
                        {
                            MessageBox.Show("存款只能输入数字");
                        }
                        else
                        {
                            c.money_add(sq, id, textBox_金额.Text.Trim().ToString(), comboBox_存款项目.Text.Trim(), dt);
                            f.user_update_add(sq, id, g, textBox_金额.Text.Trim());
                            MessageBox.Show("您存取了"+comboBox_存款项目.Text+"" + textBox_金额.Text.Trim() + "元");
                        }
            }
            catch (Exception eeee)
            {
                MessageBox.Show(eeee.Message);
            }
        }
    }
}
