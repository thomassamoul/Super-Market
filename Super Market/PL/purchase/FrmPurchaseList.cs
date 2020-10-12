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
    public partial class FrmPurchaseList : Form
    {
        ClsPurchase clsPurchase = new ClsPurchase();

        public FrmPurchaseList()
        {
            InitializeComponent();
            picnormal.Visible = false;
            loadData();
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

        void loadData()
        {
            try
            {
                dgSupp.DataSource = clsPurchase.GetPurchaseDetails();
            }
            catch
            {
                return;
            }
        }

        private void dgSupp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgSupp.CurrentRow.Cells[7].Equals("مضاف"))
                {
                    MessageBox.Show("هذا الصنف قد تم اضافته مسبقا يرجي اختيار اخر", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }   
                this.Close();
            }
            catch
            {
                return;
            }
        }
    }
}
