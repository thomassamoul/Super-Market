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
    class ClsCategory
    {

        ClsAccess classAccess = new ClsAccess();
        DataTable dt;

        public DataTable CatMaxId()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("CategoryMaxId", null);
            return dt;
        }

        public DataTable GetAllCategory()
        {
            dt = new DataTable();
            dt = classAccess.SelectData("AllCategory", null);

            return dt;
        }


        public void AddCategory(int CatId, string CatName)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@CatId", SqlDbType.Int);
            param[0].Value = CatId;

            param[1] = new SqlParameter("@CatName", SqlDbType.NVarChar, 50);
            param[1].Value = CatName;

            classAccess.ExecuteCommand("AddCategory", param);

            classAccess.Close();

        }

        public void UpdateCategory(string CatName, int id)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@CatName", SqlDbType.NVarChar, 50);
            param[0].Value = CatName;

            param[1] = new SqlParameter("@Id", SqlDbType.Int);
            param[1].Value = id;

            classAccess.ExecuteCommand("UpdateCategory", param);

            classAccess.Close();

        }

        public void DeleteCategory(int id)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            classAccess.ExecuteCommand("DeleteCategory", param);

            classAccess.Close();

        }


    }
}
