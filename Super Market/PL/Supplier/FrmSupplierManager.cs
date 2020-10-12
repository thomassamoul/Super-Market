using Super_Market.classes;
using Super_Market.report.SuppPrint;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Super_Market.PL.Supplier
{
    public partial class FrmSupplierManager : Form
    {

        ClsSupplier clsSupplier = new ClsSupplier();

        public FrmSupplierManager()
        {
            InitializeComponent();
            DataView();
        }

        void DataView()
        {
            try
            {
                dgSupp.DataSource = clsSupplier.GetAllSupplies();
            }
            catch
            {
                return;
            }
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddSupplier.windowName = "اضافة مورد";
            FrmAddSupplier frm = new FrmAddSupplier();
            frm.ShowDialog();
            DataView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgSupp.CurrentRow.Cells[1].Value.Equals("بدون مورد"))
                {
                    MessageBox.Show("لا يمكن حذف هذا المورد", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("هل تريد حذف هذا المورد", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(this.dgSupp.CurrentRow.Cells[0].Value);
                    clsSupplier.DeleteSupplier(id);
                    MessageBox.Show("تم حذف المورد", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataView();
                }
            }
            catch
            {
                return;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgSupp.CurrentRow.Cells[1].Value.Equals("بدون مورد"))
            {
                MessageBox.Show("لا يمكن حذف هذا المورد", "Super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FrmAddSupplier.windowName = "تعديل مورد";
            FrmAddSupplier frm = new FrmAddSupplier();
            try
            {
                frm.BtnNew.Visible = false;
                frm.BtnAdd.Enabled = true;
                frm.BtnAdd.Text = "تعديل";
                frm.BtnAdd.Location = new Point(333, 23);
                frm.BtnAdd.ImageIndex = 1;
                frm.state = "Update";
                frm.txtSuppId.Text = dgSupp.CurrentRow.Cells[0].Value.ToString();
                frm.txtSuppName.Text = dgSupp.CurrentRow.Cells[1].Value.ToString();
                frm.txtPhone.Text = dgSupp.CurrentRow.Cells[2].Value.ToString();
                frm.txtEmail.Text = dgSupp.CurrentRow.Cells[3].Value.ToString();
                frm.txtCompanyName.Text = dgSupp.CurrentRow.Cells[4].Value.ToString();
                frm.txtAddress.Text = dgSupp.CurrentRow.Cells[5].Value.ToString();
                frm.dateSupp.Text = dgSupp.CurrentRow.Cells[6].Value.ToString();
                frm.textUserName.Text = dgSupp.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();

                DataView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex.Message, "Super market", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsSupplier.SearchAllSupplies(txtSearch.Text);
                dgSupp.DataSource = dt;
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value.ToString());

                FrmMicroSoft frm = new FrmMicroSoft();
                frm.printOneSupplierTableAdapter.Fill(frm.super_MarketDataSet.PrintOneSupplier, id);
                frm.reportViewer2.Visible = false;
                frm.reportViewer1.RefreshReport();
                this.Cursor = Cursors.Default;
                frm.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value.ToString());

                FrmMicroSoft frm = new FrmMicroSoft();
                frm.printAllSupplierTableAdapter.Fill(frm.super_MarketDataSet.PrintAllSupplier);
                frm.reportViewer1.Visible = true;
                frm.reportViewer2.RefreshReport();
                this.Cursor = Cursors.Default;
                frm.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                return;
            }
        }
    }
}
