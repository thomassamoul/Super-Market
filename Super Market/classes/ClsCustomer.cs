using Super_Market.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Super_Market.classes
{
    class ClsCustomer
    {
        ClsAccess clsAccess = new ClsAccess();
        DataTable dt;

        public DataTable MaxCustId()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("MaxCustId", null);
            return dt;
        }

        public DataTable GetAllCustomers()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("GetAllCustomers", null);
            return dt;
        }

        public void InsertCustomer(int CusId, string CusName, string CusPhone, string CusEmail, string CusCompany, string CusAddress,
            DateTime CusDateAdd, byte[] CusImage, string CusUserAdd, string ImageState)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@CusId", SqlDbType.Int);
            param[0].Value = CusId;

            param[1] = new SqlParameter("@CusName", SqlDbType.NVarChar, 50);
            param[1].Value = CusName;

            param[2] = new SqlParameter("@CusPhone", SqlDbType.NVarChar, 30);
            param[2].Value = CusPhone;

            param[3] = new SqlParameter("@CusEmail", SqlDbType.NVarChar, 30);
            param[3].Value = CusEmail;

            param[4] = new SqlParameter("@CusCompany", SqlDbType.NVarChar, 50);
            param[4].Value = CusCompany;

            param[5] = new SqlParameter("@CusAddress", SqlDbType.NVarChar, 100);
            param[5].Value = CusAddress;

            param[6] = new SqlParameter("@CusDateAdd", SqlDbType.Date);
            param[6].Value = CusDateAdd;

            param[7] = new SqlParameter("@CusImage", SqlDbType.Image);
            param[7].Value = CusImage;

            param[8] = new SqlParameter("@CusUserAdd", SqlDbType.NVarChar, 50);
            param[8].Value = CusUserAdd;

            param[9] = new SqlParameter("@ImageState", SqlDbType.NVarChar, 50);
            param[9].Value = ImageState;

            clsAccess.ExecuteCommand("InsertCustomer", param);
            clsAccess.Close();

        }
    }
}
