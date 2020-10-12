using Super_Market.Data;
using Super_Market.PL.Customer;
using Super_Market.PL.Items;
using Super_Market.PL.purchase;
using Super_Market.PL.Store;
using Super_Market.PL.Supplier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Super_Market.PL.User
{
    public partial class FrmMain : Form
    {
        ClsAccess MyDataAccess = new Data.ClsAccess();

        public FrmMain()
        {
            InitializeComponent();
            //MyDataAccess.Open();
            this.WindowState = FormWindowState.Maximized;
            picmax.Visible = false;
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void التحكمبالمجموعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser.windowName = "اضافة مستخدم جديد";
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManager frm = new FrmUserManager();
            frm.ShowDialog();
        }

        private void دخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();

            frm.ShowDialog();
        }

        private void اضافةموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSupplier.windowName = "اضافة مورد";
            FrmAddSupplier frm = new FrmAddSupplier();
            frm.ShowDialog();
        }

        private void ادارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupplierManager frm = new FrmSupplierManager();
            frm.ShowDialog();
        }

        private void لوحةتحكمفواتيرالشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPurManager frm = new FrmPurManager();
            frm.ShowDialog();

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddItems.windowName = "اضافة صنف جديد";
            FrmAddItems frm = new FrmAddItems();
            frm.ShowDialog();
        }

        private void لوحةالتحكمبالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemManager frm = new FrmItemManager();
            frm.ShowDialog();
        }

        private void لوحةتحكماضافةشركةصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemCompany frm = new FrmItemCompany();
            frm.BtnAdd.Visible = false;
            frm.button4.Location = new Point(701, 23);
            frm.BtnDelete.Location = new Point(588, 23);
            frm.ShowDialog();

        }

        private void لوحةتحكماضافةمكانللصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemsPlace frm = new FrmItemsPlace();
            frm.BtnAdd.Visible = false;
            frm.button4.Location = new Point(701, 23);
            frm.BtnDelete.Location = new Point(588, 23);
            frm.ShowDialog();
        }

        private void اضافةزبونجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
        }

        private void ادارةالزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerManager frm = new FrmCustomerManager();
            frm.ShowDialog();
        }
    }
}
