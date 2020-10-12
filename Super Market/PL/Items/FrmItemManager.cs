using Super_Market.classes;
using Super_Market.report;
using Super_Market.report.Items;
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
    public partial class FrmItemManager : Form
    {
        ClsItem clsItem = new ClsItem();

        public FrmItemManager()
        {
            InitializeComponent();
            picnormal.Visible = false;
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                dgSupp.DataSource = clsItem.AllItems();
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

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picnormal.Visible = true;
            picmax.Visible = false;
        }

        private void picnormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picnormal.Visible = false;
            picmax.Visible = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddItems.windowName = "اضافة صنف";
            FrmAddItems frm = new FrmAddItems();
            frm.ShowDialog();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAddItems.windowName = "تعديل صنف";
            FrmAddItems frm = new FrmAddItems();
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Enabled = true;
            frm.BtnAdd.Text = "تعديل";
            frm.BtnAdd.Location = new Point(333, 23);
            frm.BtnAdd.ImageIndex = 1;
            frm.State = "Update";

            try
            {
                frm.txtItemId.Text = this.dgSupp.CurrentRow.Cells[0].Value.ToString();
                frm.txtBarcode.Text = this.dgSupp.CurrentRow.Cells[1].Value.ToString();
                frm.txtItemName.Text = this.dgSupp.CurrentRow.Cells[2].Value.ToString();
                frm.dateItem.Text = this.dgSupp.CurrentRow.Cells[3].Value.ToString();
                frm.txtPurPrice.Text = this.dgSupp.CurrentRow.Cells[4].Value.ToString();
                frm.txtSalePrice.Text = this.dgSupp.CurrentRow.Cells[5].Value.ToString();
                frm.txtItemQTE.Text = this.dgSupp.CurrentRow.Cells[6].Value.ToString();
                frm.txtDiscount.Text = this.dgSupp.CurrentRow.Cells[7].Value.ToString();
                frm.comboGroup.Text = this.dgSupp.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                LoadData();
            }
            catch
            {
                return;
            }

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            FrmAddItems.windowName = "معاينة صنف";
            FrmAddItems frm = new FrmAddItems();
            frm.BtnNew.Visible = false;
            frm.BtnAdd.Visible = false;
            frm.btnPurList.Visible = false;

            try
            {
                frm.txtItemId.Text = this.dgSupp.CurrentRow.Cells[0].Value.ToString();
                frm.txtBarcode.Text = this.dgSupp.CurrentRow.Cells[1].Value.ToString();
                frm.txtItemName.Text = this.dgSupp.CurrentRow.Cells[2].Value.ToString();
                frm.dateItem.Text = this.dgSupp.CurrentRow.Cells[3].Value.ToString();
                frm.txtPurPrice.Text = this.dgSupp.CurrentRow.Cells[4].Value.ToString();
                frm.txtSalePrice.Text = this.dgSupp.CurrentRow.Cells[5].Value.ToString();
                frm.txtItemQTE.Text = this.dgSupp.CurrentRow.Cells[6].Value.ToString();
                frm.txtDiscount.Text = this.dgSupp.CurrentRow.Cells[7].Value.ToString();
                frm.comboGroup.Text = this.dgSupp.CurrentRow.Cells[8].Value.ToString();
                frm.ShowDialog();
                LoadData();
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
                if (MessageBox.Show("هل تريد حذف هذا الصنف", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value);

                    clsItem.DeleteItem(id);

                    LoadData();
                    MessageBox.Show("تم حذف الصنف", "Super Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                return;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsItem.SearchAllItems(txtSearch.Text);
                dgSupp.DataSource = dt;
            }
            catch
            {
                return;
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmItemCompany frm = new FrmItemCompany();

            try
            {
                if (dgSupp.Rows.Count > 0)
                {
                    frm.txtItemId.Text = dgSupp.CurrentRow.Cells[0].Value.ToString();

                    int count = -1;
                    for (int i = 0; i < frm.dgItemsCom.Rows.Count; i++)
                    {
                        count += 1;
                        if (frm.dgItemsCom.Rows[count].Cells["رقم الصنف"].Value.ToString() == frm.txtItemId.Text)
                        {
                            MessageBox.Show("تمت اضافة البيانات من قبل", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            frm.txtItemId.Clear();
                            frm.txtItemId.Text = string.Empty;
                        }
                    }
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("لا يوجد اصناف لاضافة الشركة", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            FrmItemsPlace frm = new FrmItemsPlace();
            frm.txtItemId.Text = dgSupp.CurrentRow.Cells[0].Value.ToString();
            int count = -1;
            for (int i = 0; i < frm.dgItemsCom.Rows.Count; i++)
            {
                count += 1;
                if (frm.dgItemsCom.Rows[count].Cells["رقم الصنف"].Value.ToString() == frm.txtItemId.Text)
                {
                    MessageBox.Show("تمت اضافة البيانات من قبل", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            frm.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد طباعة هذه الفاتورة", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    OneItem myRep = new OneItem();
                    int id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ItemsAll myRep = new ItemsAll();
                myRep.SetDataSource(clsItem.PrintAll());
                FrmCry frm = new FrmCry();
                frm.crystalReportViewer1.ReportSource = myRep;
                this.Cursor = Cursors.Hand;
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }
    }
}