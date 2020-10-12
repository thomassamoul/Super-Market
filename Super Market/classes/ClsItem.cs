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
    class ClsItem
    {
        ClsAccess clsAccess = new ClsAccess();
        DataTable dt;

        public DataTable MaxItems()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("MaxItemId", null);
            return dt;
        }

        public DataTable AllItems()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("GetAllItems", null);
            return dt;
        }

        public DataTable PrintAll()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("GetAllItemsPrintAll", null);
            return dt;
        }


        public void AddItem(int ItemId, string Barcode, string ItemName, DateTime ItemDate, string PurPrice, string SalePrice, int ItemQTE, int ItemDiscount, int CatId)
        {
            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@Barcode", SqlDbType.NVarChar, 50);
            param[1].Value = Barcode;

            param[2] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[2].Value = ItemName;

            param[3] = new SqlParameter("@ItemDate", SqlDbType.Date);
            param[3].Value = ItemDate;

            param[4] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 30);
            param[4].Value = PurPrice;

            param[5] = new SqlParameter("@SalePrice", SqlDbType.NVarChar, 30);
            param[5].Value = SalePrice;

            param[6] = new SqlParameter("@ItemQTE", SqlDbType.Int);
            param[6].Value = ItemQTE;

            param[7] = new SqlParameter("@ItemDiscount", SqlDbType.Int);
            param[7].Value = ItemDiscount;

            param[8] = new SqlParameter("@CatId", SqlDbType.Int);
            param[8].Value = CatId;

            clsAccess.ExecuteCommand("AddItem", param);
            clsAccess.Close();

        }

        public void UpdateItem(int ItemId, string Barcode, string ItemName, DateTime ItemDate, string PurPrice, string SalePrice, int ItemQTE, int ItemDiscount, int CatId)
        {
            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@Barcode", SqlDbType.NVarChar, 50);
            param[1].Value = Barcode;

            param[2] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[2].Value = ItemName;

            param[3] = new SqlParameter("@ItemDate", SqlDbType.Date);
            param[3].Value = ItemDate;

            param[4] = new SqlParameter("@PurPrice", SqlDbType.NVarChar, 30);
            param[4].Value = PurPrice;

            param[5] = new SqlParameter("@SalePrice", SqlDbType.NVarChar, 30);
            param[5].Value = SalePrice;

            param[6] = new SqlParameter("@ItemQTE", SqlDbType.Int);
            param[6].Value = ItemQTE;

            param[7] = new SqlParameter("@ItemDiscount", SqlDbType.Int);
            param[7].Value = ItemDiscount;

            param[8] = new SqlParameter("@CatId", SqlDbType.Int);
            param[8].Value = CatId;

            clsAccess.ExecuteCommand("UpdateItem", param);
            clsAccess.Close();

        }


        public void UpdateStatus(string State, int Id, string ItemName)
        {
            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@State", SqlDbType.NVarChar, 50);
            param[0].Value = State;

            param[1] = new SqlParameter("@Id", SqlDbType.Int);
            param[1].Value = Id;

            param[2] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[2].Value = ItemName;

            clsAccess.ExecuteCommand("UpdateStateItems", param);
            clsAccess.Close();
        }

        public void DeleteItem(int Id)
        {
            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = Id;

            clsAccess.ExecuteCommand("DeleteItem", param);
            clsAccess.Close();
        }

        public DataTable SearchAllItems(string Search)
        {

            dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
             

            param[0] = new SqlParameter("@Search", SqlDbType.NVarChar, 50);
            param[0].Value = Search;

            dt = clsAccess.SelectData("SearchAllItems", param);
            return dt;
        }
    }
}
