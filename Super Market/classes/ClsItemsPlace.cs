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
    class ClsItemsPlace
    {
        ClsAccess clsAccess = new ClsAccess();
        DataTable dt;

        public DataTable GetAllPlaces()
        {
            dt = new DataTable();
            dt = clsAccess.SelectData("GetAllPlaces", null);
            return dt;
        }

        public void InsertPlaces(int ItemId, string PlFLoar, string PlStand, string PlPlace)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@PlFLoar", SqlDbType.NVarChar, 50);
            param[1].Value = PlFLoar;

            param[2] = new SqlParameter("@PlStand", SqlDbType.NVarChar, 50);
            param[2].Value = PlStand;

            param[3] = new SqlParameter("@PlPlace", SqlDbType.NVarChar, 50);
            param[3].Value = PlPlace;

            clsAccess.ExecuteCommand("InsertPlaces", param);

            clsAccess.Close();
        }

        public void UpdatePlaces(int ItemId, string PlFLoar, string PlStand, string PlPlace)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

            param[1] = new SqlParameter("@PlFLoar", SqlDbType.NVarChar, 50);
            param[1].Value = PlFLoar;

            param[2] = new SqlParameter("@PlStand", SqlDbType.NVarChar, 50);
            param[2].Value = PlStand;

            param[3] = new SqlParameter("@PlPlace", SqlDbType.NVarChar, 50);
            param[3].Value = PlPlace;

            clsAccess.ExecuteCommand("UpdatePlaces", param);

            clsAccess.Close();
        }

        public void DeletePlaces(int ItemId)
        {

            clsAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[0].Value = ItemId;

           
            clsAccess.ExecuteCommand("DeletePlaces", param);

            clsAccess.Close();
        }
    }
}
