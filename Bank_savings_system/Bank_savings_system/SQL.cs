using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Bank_savings_system
{
    public class SQL
    {
        public string sql_coon;
        public SqlConnection sql_ct;
        public SqlCommand cmd;
        public SqlDataAdapter custDA;
        public DataSet custDS;
        public SqlParameter pa;
        public SqlDataReader sr;
        public string a;
        public SQL()
        {
            this.sql_coon = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=bank;User id=sa;PWD=sa";
        }
        //开启数据库
        public void sql_start()
        {
            sql_ct = new SqlConnection(sql_coon);
            sql_ct.Open();
        }
        //计数
        public string get_sum(string get)
        {
            string nr = "";
            int x=0;
            try
            {
                
                nr = "select * from " + get + "";
                cmd = new SqlCommand(nr,sql_ct);
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    x++;
                }
                sr.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return x.ToString();
        }
        //添加数据
        public void sql_insert(string insert,int num,string[] xg)
        {
            try
            {
                cmd = new SqlCommand(insert, sql_ct);
                for (int i = 0; i < num; i++)
                {
                    a = '@' + i.ToString();
                    pa = new SqlParameter(a, xg[i]);
                    cmd.Parameters.Add(pa);
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
            }
           
        }
        //
        public void sql_insert(string insert, int num, int wz, string[] xg, DateTime dt)
        {
            try
            {

                cmd = new SqlCommand(insert, sql_ct);
                for (int i = 0; i < num; i++)
                {
                    a = '@' + i.ToString();
                    if (i == wz-1)
                    {
                        pa = new SqlParameter(a, dt);
                    }
                    else
                        pa = new SqlParameter(a, xg[i]);
                    cmd.Parameters.Add(pa);

                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
        //查找数据
        public DataSet sql_select(string select)
        {
            DataSet dt = new DataSet();
            try
            {
                cmd = new SqlCommand(select, sql_ct);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt,"table0");
                dap.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
        public string  sql_select(string select,string l)
        {
            DataSet dt = new DataSet();
            string s = "";
            try
            {
                cmd = new SqlCommand(select, sql_ct);
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                dap.Fill(dt, "table0");
                s = dt.Tables[0].Rows[0][l].ToString();
                dap.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return s;
        }
        //删除数据
        public void sql_delete(string delete,int num,string[] xg)
        {
            try
            {
                cmd = new SqlCommand(delete, sql_ct);
                for (int i = 0; i < num; i++)
                {
                    a = '@' + i.ToString();
                    pa = new SqlParameter(a, xg[i]);
                    cmd.Parameters.Add(pa);
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //更新数据
        public void sql_update(string updata,int num,string[] xg)
        {
            try
            {
                cmd = new SqlCommand(updata, sql_ct);
                for (int i = 0; i < num; i++)
                {
                    a = '@' + i.ToString();
                    pa = new SqlParameter(a, xg[i]);
                    cmd.Parameters.Add(pa);
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //
        public void sql_update(string updata)
        {
            try
            {
                cmd = new SqlCommand(updata, sql_ct);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //关闭数据库
        public void sql_end()
        {
            sql_ct.Close();
        }
        //
                   
    }
}
