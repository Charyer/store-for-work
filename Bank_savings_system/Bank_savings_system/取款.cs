using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank_savings_system
{
    class 取款
    {
        public 取款()
        {
        }
        //添加取款信息
        public void money_add(SQL sq,string id,string money,DateTime dt)
        {
            string gg = "";
            string[] st;
            try
            {
                gg = "insert into 取款信息(取款id,取款金额,取款时间) values(@0,@1,@2)";
                st = new string[] { id, money };
                sq.sql_insert(gg, 3, 3, st, dt);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

        }
    }
}
