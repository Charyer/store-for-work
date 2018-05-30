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
    class 用户账户
    {
        public 用户账户()
        {
        }
        //
        public bool user_save(SQL sq, string id)
        {
            SqlCommand cmd;
            SqlDataReader sdr;
            cmd = new SqlCommand("select * from 用户账户 where id='" +id+ "'", sq.sql_ct);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            bool bl = false;
            if (sdr.HasRows)
            {
                bl = true;
            }
            sdr.Close();
            cmd.Dispose();

            return bl;
        }
        //获取账户信息
        public DataSet user_get(SQL sq,string id)
        {
            DataSet ds = new DataSet();
            string select_message = "";
            try
            {
                select_message = "select * from 用户账户 where id="+id+"";
                ds=sq.sql_select(select_message);
            }
            catch (Exception eaxz)
            {
                MessageBox.Show(eaxz.Message);
            }
            return ds;
        }
        //添加账户
        public void user_add(SQL sq,string id,string name)
        {
            string add_message = "";
            string[] st;
            try
            {
                add_message = "insert into 用户账户 values(@0,@1,@2,@3)";
                st = new string[]{id,name,"0","0"};
                sq.sql_insert(add_message,4,st);
            }
            catch (Exception exa)
            {
                MessageBox.Show(exa.Message);
            }
        }
        //更改账户
        public void user_update(SQL sq, string id, string dx, string nr)
        {
            string update_message = "";
            string[] st;
            try
            {
                update_message = "update 用户账户 set " + dx + "=" + nr + " where id = " + id + "";
                sq.sql_update(update_message);
            }
            catch (Exception exaz)
            {
                MessageBox.Show(exaz.Message);
            }
        }
        //添加存款
        public void user_update_add(SQL sq, string id, string dx, string add_m)
        {
            string update_message = "";
            string m = "";
            string selete_message = "";
            try
            {
                selete_message = "select * from 用户账户 where id ="+id+"";
                m = (int.Parse(add_m) + int.Parse(sq.sql_select(selete_message,dx))).ToString();
                update_message = "update 用户账户 set " + dx + "=" +m+ " where id = " + id + "";
                sq.sql_update(update_message);
            }
            catch (Exception exaz)
            {
                MessageBox.Show(exaz.Message);
            }
        }  
        //减少存款
        public void user_update_less(SQL sq, string id, string dx, string add_m)
        {
            string update_message = "";
            string m = "";
            string selete_message = "";
            try
            {
                selete_message = "select * from 用户账户 where id="+id+"";
                m = (int.Parse(sq.sql_select(selete_message,dx))-int.Parse(add_m)).ToString();
                update_message = "update 用户账户 set " + dx + "=" + m + " where id = " + id + "";
                sq.sql_update(update_message);
              
            }
            catch (Exception exaz)
            {
                MessageBox.Show(exaz.Message);
            }
        }  
    }
}
