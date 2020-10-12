using Super_Market.classes;
using Super_Market.report;
using Super_Market.report.pur;
using System;
using System.Windows.Forms;

namespace Super_Market.PL.purchase
{
    public partial class FrmPurManager : Form
    {
        public bool tab = false;
        ClsPurchase clsPurchase = new ClsPurchase();
        int id;

        public FrmPurManager()
        {
            InitializeComponent();
            picnormal.Visible = false;
            setData();
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
            FrmPurBill frm = new FrmPurBill();
            frm.ShowDialog();
            setData();

        }

        void setData()
        {
            try
            {
                dgSupp.DataSource = clsPurchase.GetAllPurchaseManager();
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
                if (MessageBox.Show("هل تريد حذف هذه الفاتورة", "Super Market", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value.ToString());

                    clsPurchase.DeletePurchace(id);

                    setData();
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;
                OnePurchaseBill myRep = new OnePurchaseBill();
                int id = Convert.ToInt32(dgSupp.CurrentRow.Cells[0].Value);
                myRep.SetDataSource(clsPurchase.PrintOne(id));
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;
                PurPrintALl myRep = new PurPrintALl();
                myRep.SetDataSource(clsPurchase.PrintAllPurchase());
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
