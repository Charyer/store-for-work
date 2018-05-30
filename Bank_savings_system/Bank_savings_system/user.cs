using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Bank_savings_system
{
    class user
    {
        private SqlDataReader sdr;
        private SqlCommand cmd;
        public user()
        {

        }
        //用户存在
        public bool user_save(SQL sq, string txt_name)
        {
            cmd = new SqlCommand("select * from 用户 where 用户名='"+txt_name.ToString()+"'", sq.sql_ct);
            sdr = cmd.ExecuteReader();
            string id="";
            sdr.Read();
            bool bl=false;
            if(sdr.HasRows)
            {
                bl = true;
            }
            sdr.Close();
            cmd.Dispose();

            return bl;
        }
        //获取id
        public string  get_id(SQL sq,string txt_name)
        {
            cmd = new SqlCommand("select * from 用户 where 用户名='"+txt_name.ToString()+"'", sq.sql_ct);
            sdr = cmd.ExecuteReader();
            string id="";
            while (sdr.Read())
            {
                sdr.GetName(0);
                id = sdr.GetValue(0).ToString();
            }
            sdr.Close();
            cmd.Dispose();

            return id;
        }
        //添加用户
        public void user_add(SQL sq,string name,string mima)
        {
            string add_message="";
            string sum="";
            string[] st;
            try
            {
                sum = (int.Parse(sq.get_sum("用户"))+1).ToString();
                add_message = "insert into 用户(id,用户名,密码) values(@0,@1,@2)";
                st = new string[] {sum,name,mima};
                sq.sql_insert(add_message, 3, st);
                MessageBox.Show("注册成功");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //删除用户
        public void user_delete(SQL sq, string name,string leixing)
        {
          
        }
        //登陆用户
        public bool user_land(SQL sq,string txt_name, string txt_mima)
        {
            cmd = new SqlCommand("select * from 用户 where 用户名='" + txt_name.Trim() + "' and 密码='" + txt_mima.Trim() + "'", sq.sql_ct);
            sdr = cmd.ExecuteReader();
            bool x = false;
            try
            {
                sdr.Read();
                if (sdr.HasRows)
                {
                    x = true;
                }
                else
                    x = false;
                sdr.Close();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return x;
        }
    }
}
