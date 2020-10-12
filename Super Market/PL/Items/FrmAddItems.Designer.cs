namespace Super_Market.PL.Items
{
    partial class FrmAddItems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddItems));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chromeForm1 = new ChromeForm();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPurList = new System.Windows.Forms.Button();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtItemQTE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateItem = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chromeForm1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Add.png");
            this.imageList1.Images.SetKeyName(1, "Modify.png");
            this.imageList1.Images.SetKeyName(2, "New document.png");
            this.imageList1.Images.SetKeyName(3, "Delete.png");
            this.imageList1.Images.SetKeyName(4, "Exit.png");
            this.imageList1.Images.SetKeyName(5, "List.png");
            // 
            // chromeForm1
            // 
            this.chromeForm1.BackColor = System.Drawing.Color.White;
            this.chromeForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.chromeForm1.Controls.Add(this.groupBox2);
            this.chromeForm1.Controls.Add(this.groupBox1);
            this.chromeForm1.Customization = "AAAA/1paWv9ycnL/";
            this.chromeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeForm1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeForm1.Image = null;
            this.chromeForm1.Location = new System.Drawing.Point(0, 0);
            this.chromeForm1.Movable = true;
            this.chromeForm1.Name = "chromeForm1";
            this.chromeForm1.NoRounding = false;
            this.chromeForm1.Sizable = false;
            this.chromeForm1.Size = new System.Drawing.Size(449, 459);
            this.chromeForm1.SmartBounds = true;
            this.chromeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.chromeForm1.TabIndex = 0;
            this.chromeForm1.Text = "اضافة صنف";
            this.chromeForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.chromeForm1.Transparent = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtstatus);
            this.groupBox2.Controls.Add(this.BtnNew);
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.ForeColor = System.Drawing.Color.Blue;
            this.txtstatus.Location = new System.Drawing.Point(125, 23);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(51, 30);
            this.txtstatus.TabIndex = 16;
            this.txtstatus.Text = "مضاف";
            this.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtstatus.Visible = false;
            // 
            // BtnNew
            // 
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.ImageIndex = 2;
            this.BtnNew.ImageList = this.imageList1;
            this.BtnNew.Location = new System.Drawing.Point(333, 23);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(92, 29);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.Text = "جديد";
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExit.ImageIndex = 4;
            this.BtnExit.ImageList = this.imageList1;
            this.BtnExit.Location = new System.Drawing.Point(11, 23);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 29);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "خروج";
            this.BtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.ImageIndex = 0;
            this.BtnAdd.ImageList = this.imageList1;
            this.BtnAdd.Location = new System.Drawing.Point(235, 23);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(92, 29);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "اضافة";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtItemId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPurList);
            this.groupBox1.Controls.Add(this.comboGroup);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtItemQTE);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateItem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSalePrice);
            this.groupBox1.Controls.Add(this.txtPurPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 350);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // txtItemId
            // 
            this.txtItemId.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemId.ForeColor = System.Drawing.Color.Blue;
            this.txtItemId.Location = new System.Drawing.Point(216, 21);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(111, 30);
            this.txtItemId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "رقم الصنف";
            // 
            // btnPurList
            // 
            this.btnPurList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPurList.ImageIndex = 5;
            this.btnPurList.ImageList = this.imageList1;
            this.btnPurList.Location = new System.Drawing.Point(6, 20);
            this.btnPurList.Name = "btnPurList";
            this.btnPurList.Size = new System.Drawing.Size(123, 30);
            this.btnPurList.TabIndex = 13;
            this.btnPurList.Text = "قائمة  الشراء";
            this.btnPurList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurList.UseVisualStyleBackColor = true;
            this.btnPurList.Click += new System.EventHandler(this.btnPurList_Click);
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(6, 57);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(321, 30);
            this.comboGroup.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "رقم المجموعة";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Blue;
            this.txtDiscount.Location = new System.Drawing.Point(6, 308);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(321, 30);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            // 
            // txtItemQTE
            // 
            this.txtItemQTE.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemQTE.ForeColor = System.Drawing.Color.Blue;
            this.txtItemQTE.Location = new System.Drawing.Point(6, 272);
            this.txtItemQTE.Name = "txtItemQTE";
            this.txtItemQTE.Size = new System.Drawing.Size(321, 30);
            this.txtItemQTE.TabIndex = 9;
            this.txtItemQTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemQTE_KeyDown);
            this.txtItemQTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQTE_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "الخصم";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "الكمية";
            // 
            // dateItem
            // 
            this.dateItem.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateItem.Location = new System.Drawing.Point(6, 93);
            this.dateItem.Name = "dateItem";
            this.dateItem.Size = new System.Drawing.Size(321, 30);
            this.dateItem.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "سعر الشراء";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.ForeColor = System.Drawing.Color.Blue;
            this.txtSalePrice.Location = new System.Drawing.Point(6, 236);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(321, 30);
            this.txtSalePrice.TabIndex = 5;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalePrice_KeyDown);
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtPurPrice
            // 
            this.txtPurPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurPrice.ForeColor = System.Drawing.Color.Blue;
            this.txtPurPrice.Location = new System.Drawing.Point(6, 200);
            this.txtPurPrice.Name = "txtPurPrice";
            this.txtPurPrice.Size = new System.Drawing.Size(321, 30);
            this.txtPurPrice.TabIndex = 4;
            this.txtPurPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurPrice_KeyDown);
            this.txtPurPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "سعر البيع";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.Blue;
            this.txtItemName.Location = new System.Drawing.Point(6, 164);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(321, 30);
            this.txtItemName.TabIndex = 3;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "اسم الصنف";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Blue;
            this.txtBarcode.Location = new System.Drawing.Point(6, 129);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(321, 30);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "الباركود";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "تاريخ الاضافة";
            // 
            // FrmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(449, 459);
            this.Controls.Add(this.chromeForm1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddItems";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddItems_KeyDown);
            this.chromeForm1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ChromeForm chromeForm1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dateItem;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSalePrice;
        public System.Windows.Forms.TextBox txtPurPrice;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.TextBox txtItemQTE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnPurList;
        public System.Windows.Forms.TextBox txtstatus;
        public System.Windows.Forms.ComboBox comboGroup;
    }
}