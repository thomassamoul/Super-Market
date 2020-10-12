using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Market.PL.purchase
{
    public partial class FrmPurBill : Form
    {
        public static string windowName;

        public FrmPurBill()
        {
            InitializeComponent();
            picnormal.Visible = false;
            this.chromeForm1.Text = windowName;

        }

        private void picmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picnormal.Visible = true;
            picmax.Visible = false;
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picnormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picnormal.Visible = false;
            picmax.Visible = true;
        }
    }
}
