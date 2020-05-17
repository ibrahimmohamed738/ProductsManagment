using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductMangmentSystem.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN (string Username, string Password) 
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID",SqlDbType.NVarChar,50);
            param[0].Value = Username;

            param[1] = new SqlParameter("@PASSWORD", SqlDbType.NVarChar, 50);
            param[1].Value = Password;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN",param);
            DAL.Close();

            return dt;
        }
    }
}
