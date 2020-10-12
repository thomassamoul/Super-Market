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

namespace Super_Market.PL.Items
{
    public partial class FrmItemCompany : Form
    {
        ClsItemsCompany clsItemsCompany = new ClsItemsCompany();

        public FrmItemCompany()
        {
            InitializeComponent();
            txtCoName.Focus();
            LoadData();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == string.Empty)
                {
                    MessageBox.Show("يجب ان لا يكون رقم الصنف فارغ", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int count = -1;
                for (int i = 0; i < dgItemsCom.Rows.Count; i++)
                {
                    count += 1;
                    if (dgItemsCom.Rows[count].Cells["رقم الصنف"].Value.ToString() == txtItemId.Text)
                    {
                        MessageBox.Show("تمت اضافة البيانات من قبل", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                        return;
                    }
                }

                clsItemsCompany.InsertItemsCompany(Convert.ToInt32(txtItemId.Text), txtCoName.Text, txtPhone.Text, txtCoAddress.Text);
                MessageBox.Show("تمت اضافة البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Clear();
            }
            catch
            {
                return;
            }
        }

        private void txtCoName_KeyDown(object sender, KeyEventArgs e)
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
                txtCoAddress.Focus();
            }
        }

        private void txtCoAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }


        private void LoadData()
        {
            try
            {
                dgItemsCom.DataSource = clsItemsCompany.GetAllItemsCompany();
            }
            catch
            {
                return;
            }
        }

        private void Clear()
        {
            txtItemId.Clear();
            txtCoName.Clear();
            txtPhone.Clear();
            txtCoAddress.Clear();
        }

        private void dgItemsCom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                txtItemId.Text = dgItemsCom.CurrentRow.Cells[0].Value.ToString();
                txtCoName.Text = dgItemsCom.CurrentRow.Cells[1].Value.ToString();
                txtPhone.Text = dgItemsCom.CurrentRow.Cells[2].Value.ToString();
                txtCoAddress.Text = dgItemsCom.CurrentRow.Cells[3].Value.ToString(); ;
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == string.Empty)
                {
                    MessageBox.Show("يجب ان لا يكون رقم الصنف فارغ", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                clsItemsCompany.UpdateItemsCompany(Convert.ToInt32(txtItemId.Text), txtCoName.Text, txtPhone.Text, txtCoAddress.Text);
                MessageBox.Show("تمت تعديل البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadData();
                Clear();
            }
            catch
            {
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == string.Empty)
                {
                    MessageBox.Show("يجب ان لا يكون رقم الصنف فارغ", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int id = Convert.ToInt32(txtItemId.Text);

                if (MessageBox.Show("هل تريد حذف البيانات", Program.programeName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsItemsCompany.DeleteItemsCompany(id);
                    MessageBox.Show("تم حذف البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    Clear();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
