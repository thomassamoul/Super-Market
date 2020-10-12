namespace Super_Market.PL.purchase
{
    partial class FrmPurBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chromeForm1 = new ChromeForm();
            this.userControlMain1 = new Super_Market.PL.Main.ControlMain.UserControlMain();
            this.picmax = new System.Windows.Forms.PictureBox();
            this.picnormal = new System.Windows.Forms.PictureBox();
            this.labMin = new System.Windows.Forms.Label();
            this.chromeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnormal)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.userControlMain1);
            this.chromeForm1.Controls.Add(this.picmax);
            this.chromeForm1.Controls.Add(this.picnormal);
            this.chromeForm1.Controls.Add(this.labMin);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.Sizable = true;
            this.chromeForm1.Size = new System.Drawing.Size(910, 640);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "فاتورة الشراء";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // userControlMain1
            // 
            this.userControlMain1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlMain1.BackColor = System.Drawing.Color.White;
            this.userControlMain1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlMain1.Location = new System.Drawing.Point(13, 30);
            this.userControlMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControlMain1.Name = "userControlMain1";
            this.userControlMain1.Size = new System.Drawing.Size(883, 606);
            this.userControlMain1.TabIndex = 15;
            // 
            // picmax
            // 
            this.picmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picmax.Image = global::Super_Market.Properties.Resources.application_windows_grow;
            this.picmax.Location = new System.Drawing.Point(850, 8);
            this.picmax.Name = "picmax";
            this.picmax.Size = new System.Drawing.Size(15, 15);
            this.picmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picmax.TabIndex = 14;
            this.picmax.TabStop = false;
            this.picmax.Click += new System.EventHandler(this.picmax_Click);
            // 
            // picnormal
            // 
            this.picnormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picnormal.Image = global::Super_Market.Properties.Resources.applications_windows;
            this.picnormal.Location = new System.Drawing.Point(850, 8);
            this.picnormal.Name = "picnormal";
            this.picnormal.Size = new System.Drawing.Size(15, 15);
            this.picnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picnormal.TabIndex = 13;
            this.picnormal.TabStop = false;
            this.picnormal.Click += new System.EventHandler(this.picnormal_Click);
            // 
            // labMin
            // 
            this.labMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(872, 8);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(15, 22);
            this.labMin.TabIndex = 12;
            this.labMin.Text = "-";
            this.labMin.Click += new System.EventHandler(this.labMin_Click);
            // 
            // FrmPurBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 640);
            this.Controls.Add(this.chromeForm1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPurBill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPurBill";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.ResumeLayout(false);
            this.chromeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picnormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private System.Windows.Forms.PictureBox picmax;
        private System.Windows.Forms.PictureBox picnormal;
        private System.Windows.Forms.Label labMin;
        private Main.ControlMain.UserControlMain userControlMain1;
    }
}