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

namespace Super_Market.PL.Supplier
{
    public partial class FrmSupplierList : Form
    {
        ClsSupplier clsSupplier = new ClsSupplier();

        public FrmSupplierList()
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {

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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            FrmAddSupplier frm = new FrmAddSupplier();
            frm.ShowDialog();
            DataView();
        }

        private void dgSupp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void FrmSupplierList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
