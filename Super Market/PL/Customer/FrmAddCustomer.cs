using Super_Market.classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Super_Market.PL.Customer
{
    public partial class FrmAddCustomer : Form
    {
        ClsCustomer clsCustomer = new ClsCustomer();
        public static string windowName = "اضافة عميل جديد";


        public FrmAddCustomer()
        {
            InitializeComponent();
            BtnAdd.Enabled = false;
            chromeForm1.Text = windowName;
            try
            {
                txtUsername.Text = Program.userName;
            }
            catch
            {
                return;
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCusName_KeyDown(object sender, KeyEventArgs e)
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

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "اختر صورة";
            dialog.FileName = "";
            dialog.Filter = "Images | *.jpeg;  *.jpg;  *.gif;";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picCusImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                BtnAdd.Enabled = true;
                BtnNew.Enabled = false;
                txtCusId.Text = clsCustomer.MaxCustId().Rows[0][0].ToString();
                txtCusName.Focus();
            }
            catch
            {
                return;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCusId.Text == string.Empty || txtCusName.Text == string.Empty ||
                    txtPhone.Text.Equals(string.Empty) || txtEmail.Text == string.Empty ||
                    txtCompanyName.Text == string.Empty || txtAddress.Text == string.Empty ||
                    txtUsername.Text == string.Empty)
                {
                    MessageBox.Show("احد الحقول فارغة", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (picCusImage.Image == null)
                {
                    byte[] img;
                    img = new byte[0];
                    picCusImage.Image = null;
                    clsCustomer.InsertCustomer(Convert.ToInt32(txtCusId.Text), txtCusName.Text, txtPhone.Text, txtEmail.Text, txtCompanyName.Text, txtAddress.Text,
                        date.Value, img, txtUsername.Text, "without_image");
                    MessageBox.Show("تمت اضافة البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = true;

                }
                else
                {
                    byte[] img;
                    MemoryStream ms = new MemoryStream();
                    picCusImage.Image.Save(ms, picCusImage.Image.RawFormat);
                    img = ms.ToArray();
                    clsCustomer.InsertCustomer(Convert.ToInt32(txtCusId.Text), txtCusName.Text, txtPhone.Text, txtEmail.Text, txtCompanyName.Text, txtAddress.Text,
                        date.Value, img, txtUsername.Text, "With_image");
                    MessageBox.Show("تمت اضافة البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void Clear()
        {
            txtCusId.Clear();
            txtCusName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCompanyName.Clear();
            txtAddress.Clear();
            date.ResetText();
            picCusImage.Image = null;

        }

       
    }
}
