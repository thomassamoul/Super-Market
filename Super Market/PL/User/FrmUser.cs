using Super_Market.classes;
using Super_Market.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Super_Market.PL.User
{
    public partial class FrmUser : Form
    {
        ClsAccess ClsAccess = new ClsAccess();
        ClsUser ClassUser = new ClsUser();
        public static string windowName;
        public static string State = "Add";

        public FrmUser()
        {
            InitializeComponent();
            this.chromeForm1.Text = windowName;
            txtUserId.Visible = false;
            LoadCombo();
            BtnAdd.Enabled = false;
            BtnNew.Focus();
        }

        private void LoadCombo()
        {

            comboType.DataSource = ClassUser.GetAllUsersType();
            comboType.DisplayMember = "name";
            comboType.ValueMember = "id";
            comboType.SelectedIndex = -1;
            comboType.Text = "اختر نوع المستخدم";

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtUserId.Text = ClassUser.GetUserMaxId().Rows[0][0].ToString();
                BtnAdd.Enabled = true;
                BtnNew.Enabled = false;
                txtUserName.Focus();
            }
            catch
            {

            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
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
                txtRePass.Focus();
            }
        }

        private void txtRePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFullName.Focus();
            }
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboType.Focus();
            }
        }

        private void txtRePass_Validated(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtRePass.Focus();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRePass.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRePass.Focus();
                return;
            }

            if (txtUserId.Text == string.Empty || txtUserName.Text == string.Empty || txtPass.Text == string.Empty
                || txtFullName.Text == string.Empty || comboType.SelectedItem == null)
            {
                MessageBox.Show("احدي الحقول فارغة", "super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (State == "Add")
                {
                    ClassUser.AddUser(Convert.ToInt32(txtUserId.Text), txtUserName.Text, txtPass.Text, txtFullName.Text, dateUser.Value, Convert.ToInt32(comboType.SelectedValue));
                    MessageBox.Show("تم اضافة المستخدم", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = false;
                }

                if (State == "Update")
                {
                    int id = Convert.ToInt32(this.txtUserId.Text);

                    ClassUser.UpdateUser(txtUserName.Text, txtPass.Text, txtFullName.Text, dateUser.Value, Convert.ToInt32(comboType.SelectedValue), id);
                    MessageBox.Show("تم تعديل المستخدم", "super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnAdd.Enabled = false;
                    BtnNew.Enabled = false;
                    this.Close();
                }

            }
            catch
            {
                return;
            }
        }
    }
}