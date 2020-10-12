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
    class ClsPurchase
    {
        ClsAccess classAccess = new ClsAccess();

        DataTable dt;

        public DataTable MaxOrderId()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("MaxPurchaseId", null);

            return dt;
        }

        public DataTable GetAllPurchaseManager()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("GetAllPurchaseManager", null);

            return dt;
        }
        public DataTable PrintAllPurchase()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("PrintAllPurchase", null);

            return dt;
        }

        public DataTable GetPurchaseDetails()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("GetAllPurchaseOrderDetails", null);

            return dt;
        }

        public DataTable PrintOne(int id)
        {
            dt = new DataTable();
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;
            dt = classAccess.SelectData("GetOnePurchaseBill", param);

            return dt;
        }

        public void AddPurchace(int PurOrderId, DateTime PurOrderDate, string PurOrderDesc, int PurSuppId, string UserOrder)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@PurOrderId", SqlDbType.Int);
            param[0].Value = PurOrderId;

            param[1] = new SqlParameter("@PurOrderDate", SqlDbType.DateTime);
            param[1].Value = PurOrderDate;

            param[2] = new SqlParameter("@PurOrderDesc", SqlDbType.NVarChar, 100);
            param[2].Value = PurOrderDesc;

            param[3] = new SqlParameter("@PurSuppId", SqlDbType.Int);
            param[3].Value = PurSuppId;

            param[4] = new SqlParameter("@UserOrder", SqlDbType.NVarChar, 50);
            param[4].Value = UserOrder;


            classAccess.ExecuteCommand("AddPurchase", param);

            classAccess.Close();

        }

        public void DeletePurchace(int id)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;


            classAccess.ExecuteCommand("DeletePurBill", param);

            classAccess.Close();

        }


        public void InsertPurshaceOrderDetails(int PurOrderId, string OrBill, string Barcode, string ItemName, string PurPrice, int QTE,
            string Amount, string status, string PriceUtil)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@PurOrderId", SqlDbType.Int);
            param[0].Value = PurOrderId;

            param[1] = new SqlParameter("@OrBill", SqlDbType.NVarChar, 50);
            param[1].Value = OrBill;

            param[2] = new SqlParameter("@Barcode", SqlDbType.NVarChar, 60);
            param[2].Value = Barcode;

            param[3] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[3].Value = ItemName;

            param[4] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 50);
            param[4].Value = PurPrice;

            param[5] = new SqlParameter("@QTE", SqlDbType.Int);
            param[5].Value = QTE;

            param[6] = new SqlParameter("@Amount", SqlDbType.NVarChar, 30);
            param[6].Value = Amount;

            param[7] = new SqlParameter("@status", SqlDbType.NVarChar, 50);
            param[7].Value = status;

            param[8] = new SqlParameter("@PriceUtil", SqlDbType.NVarChar, 30);
            param[8].Value = PriceUtil;


            classAccess.ExecuteCommand("InsertPurshaceOrderDetails", param);

            classAccess.Close();

        }
    }
}
