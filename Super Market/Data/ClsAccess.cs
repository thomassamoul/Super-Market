using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.Data
{

    class ClsAccess
    {
        private SqlConnection con;

        public ClsAccess()
        {
            con = new SqlConnection(@"Server = .\; database=Super_Market; Integrated Security = true");
        }

        public void Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
                //MessageBox.Show("تم الاتصال" , "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لا يوجد اتصال", "super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();

            }
        }

        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procedure;
                cmd.Connection = con;

                if (param != null)
                {
                    cmd.Parameters.AddRange(param);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا" + ex.Message, "super market", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);

                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

    }
}
