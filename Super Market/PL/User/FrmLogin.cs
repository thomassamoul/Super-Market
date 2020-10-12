using Super_Market.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.PL.User
{
    public partial class FrmLogin : Form
    {
        ClsUser clsUser = new ClsUser();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPass.Text == string.Empty)
            {
                return;
            }
            DataTable dt = new DataTable();
            dt = clsUser.Login(txtUsername.Text, txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                Program.userName = dt.Rows[0][3].ToString();

                if (dt.Rows[0][5].ToString() == "1")
                {
                    MessageBox.Show("admin", "Super Marekr", MessageBoxButtons.OK);
                    this.Close();
                    return;
                }
                else if (dt.Rows[0][5].ToString() == "2")
                {
                    MessageBox.Show("user", "Super Marekr", MessageBoxButtons.OK);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("not found", "Super Marekr", MessageBoxButtons.OK);
                    this.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("بيانات الدخول غير صحيحة", "Super Marekr", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
