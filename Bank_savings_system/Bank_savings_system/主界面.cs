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
    public partial class 主界面 : Form
    {
        private SQL sq;
        private string id;
        private 登陆界面 f;
        public 主界面(SQL sq,string id,登陆界面 f)
        {
            InitializeComponent();
            this.sq = sq;
            this.id = id;
            this.f = f;
        }

        private void 主界面_Load(object sender, EventArgs e)
        {
            用户账户 f = new 用户账户();
            DataSet ds = new DataSet();
            try
            {
                ds = f.user_get(sq, id);
                label_名称.Text = ds.Tables[0].Rows[0]["名称"].ToString();
                label_活期存款.Text = ds.Tables[0].Rows[0]["活期存款"].ToString();
                label_定期存款.Text = ds.Tables[0].Rows[0]["定期存款"].ToString();
            }
            catch (Exception eg)
            {
                MessageBox.Show(eg.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            int 年 = currentTime.Year;
            int 月 = currentTime.Month;
            int 日 = currentTime.Day;
            int 时 = currentTime.Hour;
            int 分 = currentTime.Minute;
            int 秒 = currentTime.Second;
            textBox1.Text = 年.ToString() + "年" + 月.ToString() + "月" + 日.ToString() + "日" + 时 + "时" + 分 + "分" + 秒 + "秒";
    
        }

        private void button_存款_Click(object sender, EventArgs e)
        {
            存款界面 f = new 存款界面(this,sq,id);
            f.ShowDialog();
            主界面_Load(sender, e);
        }

        private void button_记录_Click(object sender, EventArgs e)
        {
            查看界面 ff = new 查看界面(sq,id);
            ff.ShowDialog();
        }

        private void button_取款_Click(object sender, EventArgs e)
        {
            取款界面 g = new 取款界面(sq,id,this);
            g.ShowDialog();
            主界面_Load(sender, e);
        }

        private void button_退出_Click(object sender, EventArgs e)
        {
            this.Close();
            f.Visible = true;
        }
    }
}
