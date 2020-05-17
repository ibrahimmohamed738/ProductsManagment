using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ProductMangmentSystem.BL
{
    class CLS_PRODUCTS
    {
        public DataTable GetAllCategories()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_GetAllCategories", null);
            DAL.Close();

            return dt;
        }

        public void ADD_PRODUCT(int ID_Cat, string Product_Name, string ID_Product, int Qty, string Price, byte Img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_Cat;

            param[1] = new SqlParameter("@ID_PRODUCT", SqlDbType.NVarChar,50);
            param[1].Value = ID_Product;

            param[2] = new SqlParameter("@PRODUCT_NAME", SqlDbType.NVarChar,50);
            param[2].Value = Product_Name;

            param[3] = new SqlParameter("@QTY", SqlDbType.Int);
            param[3].Value = Qty;

            param[4] = new SqlParameter("@PRICE", SqlDbType.NVarChar,50);
            param[4].Value = Price;

            param[5] = new SqlParameter("@IMG", SqlDbType.Image);
            param[5].Value = Img;

            DAL.ExcuteCommand("SP_AddProduct", param);
            DAL.Close();
        }
    }
}
