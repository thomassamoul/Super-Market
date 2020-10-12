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
    class ClsSupplier
    {
        ClsAccess classAccess = new ClsAccess();
        DataTable dt;

        public DataTable SuppMaxID()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("MaxSuppId", null);
            return dt;
        }

        public DataTable GetAllSupplies()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("GetAllSupplies", null);
            return dt;
        }

        public DataTable SearchAllSupplies(string search)
        {
            dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = search;

            dt = classAccess.SelectData("SearchAllSupplies", param);
            return dt;
        }

        public void AddSupplier(int SuppId, string SuppName, string SuppPhone, string SuppEmail, string SuppCompany, string SuppAddress, DateTime SuppDateAdd, string SuppUserAdd)
        {

            classAccess.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@SuppId", SqlDbType.Int);
            param[0].Value = SuppId;

            param[1] = new SqlParameter("@SuppName", SqlDbType.NVarChar, 50);
            param[1].Value = SuppName;

            param[2] = new SqlParameter("@SuppPhone", SqlDbType.NVarChar, 30);
            param[2].Value = SuppPhone;

            param[3] = new SqlParameter("@SuppEmail", SqlDbType.NVarChar, 30);
            param[3].Value = SuppEmail;

            param[4] = new SqlParameter("@SuppCompany", SqlDbType.NVarChar, 50);
            param[4].Value = SuppCompany;

            param[5] = new SqlParameter("@SuppAddress", SqlDbType.NVarChar, 100);
            param[5].Value = SuppAddress;

            param[6] = new SqlParameter("@SuppDateAdd", SqlDbType.Date);
            param[6].Value = SuppDateAdd;

            param[7] = new SqlParameter("@SuppUserAdd", SqlDbType.NVarChar, 50);
            param[7].Value = SuppUserAdd;

            classAccess.ExecuteCommand("AddSuplier", param);

            classAccess.Close();

        }

        public void UpdateSupplier(int SuppId, string SuppName, string SuppPhone, string SuppEmail, string SuppCompany, string SuppAddress, DateTime SuppDateAdd, string SuppUserAdd)
        {

            classAccess.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@SuppId", SqlDbType.Int);
            param[0].Value = SuppId;

            param[1] = new SqlParameter("@SuppName", SqlDbType.NVarChar, 50);
            param[1].Value = SuppName;

            param[2] = new SqlParameter("@SuppPhone", SqlDbType.NVarChar, 30);
            param[2].Value = SuppPhone;

            param[3] = new SqlParameter("@SuppEmail", SqlDbType.NVarChar, 30);
            param[3].Value = SuppEmail;

            param[4] = new SqlParameter("@SuppCompany", SqlDbType.NVarChar, 50);
            param[4].Value = SuppCompany;

            param[5] = new SqlParameter("@SuppAddress", SqlDbType.NVarChar, 100);
            param[5].Value = SuppAddress;

            param[6] = new SqlParameter("@SuppDateAdd", SqlDbType.Date);
            param[6].Value = SuppDateAdd;

            param[7] = new SqlParameter("@SuppUserAdd", SqlDbType.NVarChar, 50);
            param[7].Value = SuppUserAdd;

            classAccess.ExecuteCommand("UpdateSuplier", param);

            classAccess.Close();

        }

        public void DeleteSupplier(int SuppId)
        {

            classAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SuppId", SqlDbType.Int);
            param[0].Value = SuppId;


            classAccess.ExecuteCommand("DeleteSupplier", param);

            classAccess.Close();

        }

    }
}
