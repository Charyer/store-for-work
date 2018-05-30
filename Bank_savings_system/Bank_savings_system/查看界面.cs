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
    public partial class 查看界面 : Form
    {
        private SQL sq;
        private string id;
        public 查看界面(SQL sq,string id)
        {
            InitializeComponent();
            this.sq = sq;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查看界面_Load(object sender, EventArgs e)
        {
        
            listBox1.Items.Add("存款");
            listBox1.Items.Add("取款");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds;
            string select_message="";
            try
            {
                if (listBox1.SelectedItem.ToString() == "存款")
                {
                    select_message = "select * from 存款信息 where 存款id=" + id + "";
                    ds = sq.sql_select(select_message);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    if (listBox1.SelectedItem.ToString() == "取款")
                    {
                        select_message = "select * from 取款信息 where 取款id=" + id + "";
                        ds = sq.sql_select(select_message);
                        dataGridView1.DataSource = ds.Tables[0];
                       
                    }

            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}
