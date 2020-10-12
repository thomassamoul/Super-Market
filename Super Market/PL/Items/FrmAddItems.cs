using Super_Market.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.PL.Items
{
    public partial class FrmAddItems : Form
    {
        public static string windowName;
        ClsCategory clsCategory = new ClsCategory();
        ClsItem clsItem = new ClsItem();
        int id;
        public string State = "Add";

        public FrmAddItems()
        {
            InitializeComponent();
            this.chromeForm1.Text = windowName;
            BtnAdd.Enabled = false;
            loadCombo();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            txtItemId.Text = clsItem.MaxItems().Rows[0][0].ToString();
            BtnAdd.Enabled = true;
            BtnNew.Enabled = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtItemName.Focus();
            }
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPurPrice.Focus();
            }
        }

        private void txtPurPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalePrice.Focus();
            }
        }

        private void txtSalePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtItemQTE.Focus();
            }
        }

        private void txtItemQTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDiscount.Focus();
            }

        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(sender, e);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Text == string.Empty || txtBarcode.Text == string.Empty ||
                    txtItemName.Text == string.Empty || txtPurPrice.Text == string.Empty ||
                    txtSalePrice.Text == string.Empty || txtItemQTE.Text == string.Empty
                    || txtDiscount.Text == string.Empty ||
                    comboGroup.SelectedItem == null)
                {
                    MessageBox.Show("بعض الحقول فارغة", "Super Market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (State == "Add")
                {
                    clsItem.AddItem(Convert.ToInt32(txtItemId.Text), txtBarcode.Text, txtItemName.Text, dateItem.Value, txtPurPrice.Text, txtSalePrice.Text,
                        Convert.ToInt32(txtItemQTE.Text), Convert.ToInt32(txtDiscount.Text), Convert.ToInt32(comboGroup.SelectedIndex + 1));
                    MessageBox.Show("تم اضافة الصنف ", "Super Market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    BtnNew.Enabled = true;
                    BtnAdd.Enabled = false;
                    BtnNew.Focus();

                    try
                    {
                        clsItem.UpdateStatus(txtstatus.Text, id, txtItemName.Text) ;
                        Clear();
    
                    }
                    catch
                    {
                        return;
                    }

                }
                if (State == "Update")
                {
                    clsItem.UpdateItem(Convert.ToInt32(txtItemId.Text), txtBarcode.Text, txtItemName.Text, dateItem.Value, txtPurPrice.Text, txtSalePrice.Text,
                        Convert.ToInt32(txtItemQTE.Text), Convert.ToInt32(txtDiscount.Text), Convert.ToInt32(comboGroup.SelectedValue));
                    MessageBox.Show("تم تعديل الصنف ", "Super Market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                    this.Close();
                }

            }
            catch
            {
                return;
            }
        }

        void Clear()
        {
            txtItemId.Clear();
            txtBarcode.Clear();
            txtItemName.Clear();
            dateItem.ResetText();
            txtPurPrice.Clear();
            txtSalePrice.Clear();
            txtItemQTE.Clear();
            txtDiscount.Clear();
            comboGroup.SelectedItem = null;
        }

        private void txtItemQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txtPurPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void btnPurList_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPurchaseList frm = new FrmPurchaseList();
                frm.ShowDialog();

                txtBarcode.Text = frm.dgSupp.CurrentRow.Cells[2].Value.ToString();
                txtItemName.Text = frm.dgSupp.CurrentRow.Cells[3].Value.ToString();
                txtPurPrice.Text = frm.dgSupp.CurrentRow.Cells[8].Value.ToString();
                txtItemQTE.Text = frm.dgSupp.CurrentRow.Cells[5].Value.ToString();
                id = Convert.ToInt32(frm.dgSupp.CurrentRow.Cells[0].Value.ToString());

            }
            catch
            {
                return;
            }
        }

        void loadCombo()
        {
            try
            {
                comboGroup.DataSource = clsCategory.GetAllCategory();
                comboGroup.DisplayMember = "اسم المجموعة";
                comboGroup.ValueMember = "رقم المجموعة";
                comboGroup.SelectedIndex = -1;
                comboGroup.Text = "اختر مجموعة من القائمة";

            }
            catch
            {
                return;
            }
        }

        private void FrmAddItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
