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
    class 存款
    {
        public 存款()
        {
        }
        //活期添加
        public void money_add(SQL sq, string id,string money,string lx,DateTime dt)
        {
            string update_message = "";
            string insert_message = "";
            string[] st;
            try
            {
                insert_message = "insert into 存款信息(存款id,存款数额,存款类型,存款时间) values(@0,@1,@2,@3)";
                st = new string[]{id,money,lx};
                sq.sql_insert(insert_message,4,4,st,dt);
                
            }
            catch(Exception ie)
            {
                MessageBox.Show(ie.Message);   
                }
        }
      
    }
}
