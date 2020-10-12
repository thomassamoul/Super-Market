using Super_Market.classes;
using Super_Market.Data;
using System;
using System.Windows.Forms;

namespace Super_Market.PL.User
{
    public partial class FrmUserManager : Form
    {
        ClsUser classUser = new ClsUser();

        public FrmUserManager()
        {
            InitializeComponent();
            picnormal.Visible = false;
            DataPreview();

        }

        public void DataPreview()
        {
            try
            {
                dgUser.DataSource = classUser.GetAllUsers();

            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();

            frmUser.ShowDialog();
            DataPreview();
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picnormal.Visible = false;
            picmax.Visible = true;

        }

        private void picmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picnormal.Visible = true;
            picmax.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmUser.windowName = "تعديل المستخدم";
            FrmUser frmUser = new FrmUser();
            frmUser.BtnNew.Visible = false;
            frmUser.BtnAdd.Enabled = true;
            frmUser.BtnAdd.Location = new System.Drawing.Point(314, 23);
            frmUser.BtnAdd.ImageIndex = 1;
            frmUser.BtnAdd.Text = "تعديل";
            FrmUser.State = "Update";

            try
            {
                frmUser.txtUserId.Text = this.dgUser.CurrentRow.Cells[0].Value.ToString();
                frmUser.txtUserName.Text = this.dgUser.CurrentRow.Cells[1].Value.ToString();
                frmUser.txtPass.Text = this.dgUser.CurrentRow.Cells[2].Value.ToString();
                frmUser.txtFullName.Text = this.dgUser.CurrentRow.Cells[3].Value.ToString();
                frmUser.dateUser.Value = (DateTime)this.dgUser.CurrentRow.Cells[4].Value;

                frmUser.ShowDialog();
                DataPreview();

            }

            catch { return; }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف هذا المستخدم", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(this.dgUser.CurrentRow.Cells[0].Value);
                    classUser.DeleteUser(id);
                    MessageBox.Show("تم حذف المستخدم", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataPreview();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
