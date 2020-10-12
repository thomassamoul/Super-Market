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

namespace Super_Market.PL.Store
{
    public partial class FrmCategory : Form
    {
        ClsCategory ClassCategory = new ClsCategory();

        public FrmCategory()
        {
            InitializeComponent();
            TxtId.Visible = false;
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;
            DataPreview();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtId.Text = ClassCategory.CatMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch (Exception)
            {
                return;
            }        
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ClassCategory.AddCategory(Convert.ToInt32(TxtId.Text), TxtName.Text);
                MessageBox.Show("تم اضافة اسم المجموعة", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                TxtId.Clear();
                TxtName.Clear();
                DataPreview();
            }
            catch 
            {

            }
        }


        void DataPreview()
        {
            try
            {
                DgCat.DataSource = ClassCategory.GetAllCategory();

            }
            catch (Exception)
            {
                return;
            }        
        }

        private void DgCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtId.Text = DgCat.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DgCat.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if(TxtName.Text != string.Empty)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;

            }
            else
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TxtId.Text);
                ClassCategory.UpdateCategory(TxtName.Text, id);
                MessageBox.Show("تم تحديث اسم المجموعة", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                TxtId.Clear();
                TxtName.Clear();
                DataPreview();
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
                if (MessageBox.Show("هل تريد حذف هذه المجموعة", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    int id = Convert.ToInt32(TxtId.Text);
                    ClassCategory.DeleteCategory(id);
                    MessageBox.Show("تم حذف اسم المجموعة", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                    TxtId.Clear();
                    TxtName.Clear();
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
