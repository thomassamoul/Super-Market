using Super_Market.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.PL.Customer
{
    public partial class FrmCustomerManager : Form
    {
        ClsCustomer clsCustomer = new ClsCustomer();
        public FrmCustomerManager()
        {
            InitializeComponent();
            loadData();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadData()
        {
            try
            {
                dgSupp.DataSource = clsCustomer.GetAllCustomers();
                dgSupp.Columns[7].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
            loadData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmAddCustomer.windowName = "تعديل بيانات عميل";
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
        }

        private void dgSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = (byte[])dgSupp.CurrentRow.Cells[7].Value;
                var ms = new MemoryStream(data);
                pictureBox2.Image = Image.FromStream(ms);
            }
            catch
            {

            }
        }
    }
}
