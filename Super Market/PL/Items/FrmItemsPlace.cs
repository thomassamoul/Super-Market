using Super_Market.classes;
using System;
using System.Windows.Forms;

namespace Super_Market.PL.Items
{
    public partial class FrmItemsPlace : Form
    {
        ClsItemsPlace clsItemsPlace = new ClsItemsPlace();

        public FrmItemsPlace()
        {
            InitializeComponent();
            comFloar.Focus();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgItemsCom.DataSource = clsItemsPlace.GetAllPlaces();
            }
            catch { return; }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == string.Empty || comFloar.SelectedItem == null || comPlPlace.SelectedItem == null || comStand.SelectedItem == null)
                {
                    MessageBox.Show("احد الحقول فارغة", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                int count = -1;
                for (int i = 0; i < dgItemsCom.Rows.Count; i++)
                {
                    count += 1;
                    if (dgItemsCom.Rows[count].Cells["رقم الصنف"].Value.ToString() == txtItemId.Text)
                    {
                        MessageBox.Show("تمت اضافة البيانات من قبل", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clear();
                        return;
                    }
                }

                clsItemsPlace.InsertPlaces(Convert.ToInt32(txtItemId.Text), comFloar.Text, comStand.Text, comPlPlace.Text);
                MessageBox.Show("تمت الاضافة بنجاح", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Clear();
            }
            catch
            {
                return;
            }
        }

        private void Clear()
        {
            txtItemId.Clear();
            comFloar.SelectedItem = null;
            comPlPlace.SelectedItem = null;
            comStand.SelectedItem = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItemId.Text == string.Empty || comFloar.SelectedItem == null || comPlPlace.SelectedItem == null || comStand.SelectedItem == null)
                {
                    MessageBox.Show("احد الحقول فارغة", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                clsItemsPlace.UpdatePlaces(Convert.ToInt32(txtItemId.Text), comFloar.Text, comStand.Text, comPlPlace.Text);
                MessageBox.Show("تم التعديل بنجاح", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                Clear();
            }
            catch
            {
                return;
            }
        }

        private void dgItemsCom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtItemId.Text = dgItemsCom.CurrentRow.Cells[0].Value.ToString();
                comFloar.Text = dgItemsCom.CurrentRow.Cells[1].Value.ToString();
                comStand.Text = dgItemsCom.CurrentRow.Cells[2].Value.ToString();
                comPlPlace.Text = dgItemsCom.CurrentRow.Cells[3].Value.ToString();
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
                if (txtItemId.Text == string.Empty)
                {
                    MessageBox.Show("يجب ان لا يكون رقم الصنف فارغ", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                int id = Convert.ToInt32(txtItemId.Text);

                if (MessageBox.Show("هل تريد حذف البيانات", Program.programeName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clsItemsPlace.DeletePlaces(id);
                    MessageBox.Show("تم حذف البيانات", Program.programeName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    Clear();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
