using Super_Market.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market.classes
{
    class ClsItemsCompany
    {
        ClsAccess clsAccess = new ClsAccess();
        DataTable dt;

        public DataTable GetAllItemsCompany()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("GetAllItemsCompany", null);
            return dt;

        }

        public void InsertItemsCompany(int ItemId, string CoName, string CoPhone, string CoAddress)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@CoName", SqlDbType.NVarChar, 50);
            param[1].Value = CoName;

            param[2] = new SqlParameter("@CoPhone", SqlDbType.NVarChar, 30);
            param[2].Value = CoPhone;

            param[3] = new SqlParameter("@CoAddress", SqlDbType.NVarChar, 100);
            param[3].Value = CoAddress;

            clsAccess.ExecuteCommand("InsertItemsCompany", param);

            clsAccess.Close();
        }

        public void UpdateItemsCompany(int ItemId, string CoName, string CoPhone, string CoAddress)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@CoName", SqlDbType.NVarChar, 50);
            param[1].Value = CoName;

            param[2] = new SqlParameter("@CoPhone", SqlDbType.NVarChar, 30);
            param[2].Value = CoPhone;

            param[3] = new SqlParameter("@CoAddress", SqlDbType.NVarChar, 100);
            param[3].Value = CoAddress;

            clsAccess.ExecuteCommand("UpdateItemsCompany", param);

            clsAccess.Close();
        }

        public void DeleteItemsCompany(int ItemId)
        {
            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            clsAccess.ExecuteCommand("DeleteItemsCompany", param);

            clsAccess.Close();
        }

    }

}
