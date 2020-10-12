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

namespace Super_Market.PL.Supplier
{
    public partial class FrmAddSupplier : Form
    {
        public string state = "Add";

        ClsSupplier clsSupplier = new ClsSupplier();
        public static string windowName = "اضافة مورد";

        public FrmAddSupplier()
        {
            InitializeComponent();
            txtSuppId.Visible = false;
            BtnAdd.Enabled = false;
            textUserName.Text = Program.userName;
            this.chromeForm1.Text = windowName;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void clear()
        {
            dateSupp.ResetText();
            txtSuppId.Clear();
            txtSuppName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCompanyName.Clear();

        }

        private void txtSuppName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCompanyName.Focus();
            }
        }

        private void txtCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtSuppId.Text = clsSupplier.SuppMaxID().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnNew_Click(sender, e);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "Add")
                {

                    if (txtSuppId.Text == string.Empty || txtSuppName.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty
                        || txtCompanyName.Text == string.Empty || textUserName.Text == string.Empty)
                    {
                        MessageBox.Show("احدي الحقول فارغة", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    clsSupplier.AddSupplier(Convert.ToInt32(txtSuppId.Text), txtSuppName.Text, txtPhone.Text, txtEmail.Text,
                        txtCompanyName.Text, txtAddress.Text, dateSupp.Value, textUserName.Text);
                    MessageBox.Show("تم اضافة المورد", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = true;
                    clear();
                }
                else if (state == "Update")
                {
                    if (txtSuppId.Text == string.Empty || txtSuppName.Text == string.Empty || txtEmail.Text == string.Empty || txtPhone.Text == string.Empty || txtAddress.Text == string.Empty
                        || txtCompanyName.Text == string.Empty || textUserName.Text == string.Empty)
                    {
                        MessageBox.Show("احدي الحقول فارغة", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    clsSupplier.UpdateSupplier(Convert.ToInt32(txtSuppId.Text), txtSuppName.Text, txtPhone.Text, txtEmail.Text,
                        txtCompanyName.Text, txtAddress.Text, dateSupp.Value, textUserName.Text);
                    MessageBox.Show("تم تعديل المورد", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = true;
                    clear();
                }
            }
            catch
            {

            }
        }
    }
}
