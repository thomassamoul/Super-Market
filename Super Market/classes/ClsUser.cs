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
    class ClsUser
    {
        ClsAccess classAccess = new ClsAccess();
        DataTable dt;

        public DataTable GetUserMaxId()
        {
            dt = new DataTable();

            dt = classAccess.SelectData("MaxUserId", null);

            return dt;
        }

        public DataTable GetAllUsers()
        {
            dt = new DataTable();

            dt = classAccess.SelectData("AllUsers", null);

            return dt;
        }

        public DataTable GetAllUsersType()
        {
            dt = new DataTable();

            dt = classAccess.SelectData("AllUsersType", null);

            return dt;
        }

        public void DeleteUser(int Id)
        {
            classAccess.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
            param[0].Value = Id;

            classAccess.ExecuteCommand("DeleteUser", param);

            classAccess.Close();

        }

        public void AddUser(int UserId, string UserName, string UserPass, string UserFullName, DateTime UserDate, int TypeId)
        {

            classAccess.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@UserId", SqlDbType.Int);
            param[0].Value = UserId;

            param[1] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[1].Value = UserName;

            param[2] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 30);
            param[2].Value = UserPass;

            param[3] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 30);
            param[3].Value = UserFullName;

            param[4] = new SqlParameter("@UserDateT", SqlDbType.DateTime);
            param[4].Value = UserDate;

            param[5] = new SqlParameter("@TypeId", SqlDbType.Int);
            param[5].Value = TypeId;

            classAccess.ExecuteCommand("AddUser", param);

            classAccess.Close();

        }

        public DataTable Login(string username, string pass)
        {
            dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = username;

            param[1] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 50);
            param[1].Value = pass;

            dt = classAccess.SelectData("CHKLogin", param);

            return dt;

        }

        public void UpdateUser(string UserName, string UserPass, string UserFullName, DateTime UserDate, int TypeId, int Id)
        {

            classAccess.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@UserPass", SqlDbType.NVarChar, 30);
            param[1].Value = UserPass;

            param[2] = new SqlParameter("@UserFullName", SqlDbType.NVarChar, 30);
            param[2].Value = UserFullName;

            param[3] = new SqlParameter("@UserDateT", SqlDbType.DateTime);
            param[3].Value = UserDate;

            param[4] = new SqlParameter("@TypeId", SqlDbType.Int);
            param[4].Value = TypeId;

            param[5] = new SqlParameter("@Id", SqlDbType.Int);
            param[5].Value = Id;

            classAccess.ExecuteCommand("UpdateUser", param);

            classAccess.Close();

        }

    }
}
