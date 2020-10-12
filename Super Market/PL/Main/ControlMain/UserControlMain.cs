using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Super_Market.classes;
using Super_Market.PL.Supplier;
using System.Globalization;
using Super_Market.report.pur;
using Super_Market.report;

namespace Super_Market.PL.Main.ControlMain
{
    public partial class UserControlMain : UserControl
    {
        ClsPurchase clsPurchase = new ClsPurchase();
        DataTable dt = new DataTable();

        public UserControlMain()
        {
            InitializeComponent();
            BtnAdd.Enabled = false;
            panelSupp.Enabled = false;
            addData();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrderID.Text = clsPurchase.MaxOrderId().Rows[0][0].ToString();
                BtnAdd.Enabled = true;
                BtnNew.Enabled = false;
                txtDesc.Focus();
                txtSuppId.Text = "1";
                txtSuppName.Text = "بدون مورد";
            }
            catch
            {

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text == string.Empty || txtSalesMan.Text == string.Empty || txtDesc.Text == string.Empty ||
                    txtSuppId.Text == string.Empty || txtSuppName.Text == string.Empty || dgPurchase.Rows.Count < 1)
                {
                    MessageBox.Show("احدي الحقول فارغة", "super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                clsPurchase.AddPurchace(Convert.ToInt32(txtOrderID.Text), dateOrder.Value, txtDesc.Text, Convert.ToInt32(txtSuppId.Text), txtSalesMan.Text);

                try
                {
                    for (int i = 0; i < dgPurchase.Rows.Count; i++)
                    {

                        clsPurchase.InsertPurshaceOrderDetails(
                            Convert.ToInt32(txtOrderID.Text),
                            dgPurchase.Rows[i].Cells[0].Value.ToString(),
                            dgPurchase.Rows[i].Cells[1].Value.ToString(),
                            dgPurchase.Rows[i].Cells[2].Value.ToString(),
                            dgPurchase.Rows[i].Cells[3].Value.ToString(),
                            Convert.ToInt32(dgPurchase.Rows[i].Cells[4].Value.ToString()),
                            dgPurchase.Rows[i].Cells[6].Value.ToString(),
                            lastStatus.Text,
                            dgPurchase.Rows[i].Cells[5].Value.ToString());
                    }
                }
                catch
                {
                    return;
                }

                MessageBox.Show("تم حفظ الفاتورة", "Super Market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    if (MessageBox.Show("هل تريد طباعة هذه الفاتورة", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        OnePurchaseBill myRep = new OnePurchaseBill();
                        int id = Convert.ToInt32(txtOrderID.Text);
                        myRep.SetParameterValue("@Id", id);
                        FrmCry frm = new FrmCry();
                        frm.crystalReportViewer1.ReportSource = myRep;
                        this.Cursor = Cursors.Hand;
                        frm.ShowDialog();
                    }
                }
                catch
                {
                    return;
                }
                ClearAll();
                BtnAdd.Enabled = false;
                BtnNew.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void txtDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRecived.Focus();
            }
        }

        private void radioWithoutSupp_CheckedChanged(object sender, EventArgs e)
        {
            panelSupp.Enabled = false;
            txtSuppId.Text = "1";
            txtSuppName.Text = "بدون مورد";
            txtCompany.Clear();
            txtSuppPhone.Clear();

        }

        private void radioWithSupp_CheckedChanged(object sender, EventArgs e)
        {
            panelSupp.Enabled = true;

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            FrmSupplierList frm = new FrmSupplierList();
            try
            {
                frm.ShowDialog();
                txtSuppId.Text = frm.dgSupp.CurrentRow.Cells[0].Value.ToString();
                txtSuppName.Text = frm.dgSupp.CurrentRow.Cells[1].Value.ToString();
                txtSuppPhone.Text = frm.dgSupp.CurrentRow.Cells[2].Value.ToString();
                txtCompany.Text = frm.dgSupp.CurrentRow.Cells[4].Value.ToString();
                txtRecived.Focus();

            }
            catch
            {

                throw;
            }
        }

        private void UserControlMain_Load(object sender, EventArgs e)
        {
            txtSalesMan.Text = Program.userName;
        }

        private void UserControlMain_TabStopChanged(object sender, EventArgs e)
        {
            txtSalesMan.Text = Program.userName;
        }

        private void txtRecived_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarCode.Focus();
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
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
                txtPurchasePrice.Focus();
            }
        }

        private void txtPurchasePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPurchaseQTE.Focus();
            }
        }

        private void txtPurchaseQTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddList.Focus();
            }
        }

        void dev()
        {
            if (txtPurchaseQTE.Text != string.Empty && txtPurchasePrice.Text != string.Empty)
            {
                try
                {
                    double price = Convert.ToDouble(txtPurchasePrice.Text);
                    double QTE = Convert.ToDouble(txtPurchaseQTE.Text);
                    double result = price / QTE;
                    txtUnitPrice.Text = string.Format("{0:0.##}", result);
                    txtAmount.Text = price.ToString();
                }
                catch
                {
                    return;
                }

            }
        }

        private void txtPurchasePrice_KeyUp(object sender, KeyEventArgs e)
        {
            dev();
        }

        private void txtPurchaseQTE_KeyUp(object sender, KeyEventArgs e)
        {
            dev();
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dec = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != dec)
            {
                e.Handled = true;
            }
        }

        private void txtPurchaseQTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        void addData()
        {
            dt.Columns.Add("ايصال الشراء");
            dt.Columns.Add("الباركود");
            dt.Columns.Add("اسم الصنف");
            dt.Columns.Add("سعر الشراء");
            dt.Columns.Add("الكمية");
            dt.Columns.Add("سعر الوحدة");
            dt.Columns.Add("المبلغ");
            dgPurchase.DataSource = dt;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemName.Text == string.Empty || txtPurchasePrice.Text == string.Empty || txtPurchaseQTE.Text == string.Empty ||
                    txtUnitPrice.Text == string.Empty || txtAmount.Text == string.Empty)
                {
                    return;
                }
                DataRow row = dt.NewRow();
                row[0] = txtRecived.Text;
                row[1] = txtBarCode.Text;
                row[2] = txtItemName.Text;
                row[3] = txtPurchasePrice.Text;
                row[4] = txtPurchaseQTE.Text;
                row[5] = txtUnitPrice.Text;
                row[6] = txtAmount.Text;

                dt.Rows.Add(row);
                dgPurchase.DataSource = dt;
                Clear();
                TableSum();
                txtRecived.Focus();
            }
            catch
            {
                return;
            }
        }

        void Clear()
        {
            txtRecived.Clear();
            txtBarCode.Clear();
            txtItemName.Clear();
            txtPurchasePrice.Clear();
            txtPurchaseQTE.Clear();
            txtUnitPrice.Clear();
            txtAmount.Clear();
        }

        void ClearAll()
        {
            txtOrderID.Clear();
            txtDesc.Clear();
            txtSuppId.Clear();
            txtSuppName.Clear();
            txtCompany.Clear();
            txtSuppPhone.Clear();
            txtTotal.Clear();
            dgPurchase.DataSource = null;
            dt.Clear();
            Clear();
        }

        void TableSum()
        {
            try
            {
                if (dgPurchase.Rows.Count < 1)
                {
                    txtTotal.Text = "0";
                }
                else
                {
                    txtTotal.Text = (from DataGridViewRow row in dgPurchase.Rows
                                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                }
            }
            catch
            {
                return;
            }
        }

        void GetData()
        {
            try
            {
                txtRecived.Text = dgPurchase.CurrentRow.Cells[0].Value.ToString();
                txtBarCode.Text = dgPurchase.CurrentRow.Cells[1].Value.ToString();
                txtItemName.Text = dgPurchase.CurrentRow.Cells[2].Value.ToString();
                txtPurchasePrice.Text = dgPurchase.CurrentRow.Cells[3].Value.ToString();
                txtPurchaseQTE.Text = dgPurchase.CurrentRow.Cells[4].Value.ToString();
                txtUnitPrice.Text = dgPurchase.CurrentRow.Cells[5].Value.ToString();
                txtAmount.Text = dgPurchase.CurrentRow.Cells[6].Value.ToString();
                dgPurchase.Rows.RemoveAt(dgPurchase.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void DgPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetData();
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgPurchase.Rows.RemoveAt(dgPurchase.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void حToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dgPurchase.DataSource = null;
        }

        private void نعديلسطرمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgPurchase_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TableSum();
        }
    }
}
