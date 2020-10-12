namespace Super_Market.PL.Main.ControlMain
{
    partial class UserControlMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMain));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgPurchase = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.نعديلسطرمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPurchaseQTE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRecived = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelSupp = new System.Windows.Forms.Panel();
            this.btnSupp = new System.Windows.Forms.Button();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuppPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioWithSupp = new System.Windows.Forms.RadioButton();
            this.radioWithoutSupp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelSupp.SuspendLayout();
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
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(883, 606);
            this.panel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lastStatus);
            this.groupBox5.Controls.Add(this.BtnNew);
            this.groupBox5.Controls.Add(this.BtnExit);
            this.groupBox5.Controls.Add(this.BtnAdd);
            this.groupBox5.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 537);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(871, 66);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.ImageIndex = 2;
            this.BtnNew.ImageList = this.imageList1;
            this.BtnNew.Location = new System.Drawing.Point(773, 23);
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
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.ImageIndex = 0;
            this.BtnAdd.ImageList = this.imageList1;
            this.BtnAdd.Location = new System.Drawing.Point(658, 23);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(109, 29);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "حفظ الفاتورة";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgPurchase);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(4, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(871, 202);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تفاصيل الفاتورة";
            // 
            // dgPurchase
            // 
            this.dgPurchase.AllowUserToAddRows = false;
            this.dgPurchase.AllowUserToDeleteRows = false;
            this.dgPurchase.AllowUserToResizeColumns = false;
            this.dgPurchase.AllowUserToResizeRows = false;
            this.dgPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPurchase.BackgroundColor = System.Drawing.Color.White;
            this.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchase.ContextMenuStrip = this.contextMenuStrip1;
            this.dgPurchase.Location = new System.Drawing.Point(6, 19);
            this.dgPurchase.Name = "dgPurchase";
            this.dgPurchase.Size = new System.Drawing.Size(861, 128);
            this.dgPurchase.TabIndex = 0;
            this.dgPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPurchase_CellDoubleClick);
            this.dgPurchase.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgPurchase_RowsRemoved);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفالسطرالحاليToolStripMenuItem,
            this.toolStripSeparator1,
            this.حToolStripMenuItem,
            this.toolStripSeparator2,
            this.نعديلسطرمحددToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 94);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // حToolStripMenuItem
            // 
            this.حToolStripMenuItem.Name = "حToolStripMenuItem";
            this.حToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.حToolStripMenuItem.Text = "حذف الكل";
            this.حToolStripMenuItem.Click += new System.EventHandler(this.حToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // نعديلسطرمحددToolStripMenuItem
            // 
            this.نعديلسطرمحددToolStripMenuItem.Name = "نعديلسطرمحددToolStripMenuItem";
            this.نعديلسطرمحددToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.نعديلسطرمحددToolStripMenuItem.Text = "تعديل سطر محدد";
            this.نعديلسطرمحددToolStripMenuItem.Click += new System.EventHandler(this.نعديلسطرمحددToolStripMenuItem_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.Location = new System.Drawing.Point(6, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(254, 30);
            this.txtTotal.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(271, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 22);
            this.label15.TabIndex = 2;
            this.label15.Text = "المبلغ الاجمالي";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtUnitPrice);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.btnAddList);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPurchaseQTE);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPurchasePrice);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtItemName);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtBarCode);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtRecived);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(4, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 138);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitPrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtUnitPrice.Location = new System.Drawing.Point(423, 101);
            this.txtUnitPrice.MaxLength = 9;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(103, 30);
            this.txtUnitPrice.TabIndex = 14;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.DimGray;
            this.label16.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(423, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 21);
            this.label16.TabIndex = 13;
            this.label16.Text = "سعر الوحدة";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddList
            // 
            this.btnAddList.Image = global::Super_Market.Properties.Resources.List;
            this.btnAddList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddList.Location = new System.Drawing.Point(6, 90);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(152, 36);
            this.btnAddList.TabIndex = 12;
            this.btnAddList.Text = "اضف للقائمة";
            this.btnAddList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtAmount.Location = new System.Drawing.Point(207, 101);
            this.txtAmount.MaxLength = 9;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(210, 30);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(207, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "المبلغ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPurchaseQTE
            // 
            this.txtPurchaseQTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchaseQTE.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtPurchaseQTE.Location = new System.Drawing.Point(532, 101);
            this.txtPurchaseQTE.MaxLength = 9;
            this.txtPurchaseQTE.Name = "txtPurchaseQTE";
            this.txtPurchaseQTE.Size = new System.Drawing.Size(151, 30);
            this.txtPurchaseQTE.TabIndex = 9;
            this.txtPurchaseQTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPurchaseQTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseQTE_KeyDown);
            this.txtPurchaseQTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchaseQTE_KeyPress);
            this.txtPurchaseQTE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseQTE_KeyUp);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(532, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "الكمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurchasePrice.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(689, 101);
            this.txtPurchasePrice.MaxLength = 9;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(175, 30);
            this.txtPurchasePrice.TabIndex = 7;
            this.txtPurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPurchasePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchasePrice_KeyDown);
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            this.txtPurchasePrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPurchasePrice_KeyUp);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.DimGray;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(689, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 21);
            this.label12.TabIndex = 6;
            this.label12.Text = "سعر الشراء";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtItemName.Location = new System.Drawing.Point(6, 44);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(308, 30);
            this.txtItemName.TabIndex = 5;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(308, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "اسم الملف";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarCode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtBarCode.Location = new System.Drawing.Point(320, 44);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(363, 30);
            this.txtBarCode.TabIndex = 3;
            this.txtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.DimGray;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(320, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "الباركود";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecived
            // 
            this.txtRecived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecived.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F);
            this.txtRecived.Location = new System.Drawing.Point(689, 44);
            this.txtRecived.Name = "txtRecived";
            this.txtRecived.Size = new System.Drawing.Size(175, 30);
            this.txtRecived.TabIndex = 1;
            this.txtRecived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecived.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecived_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(689, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "رقم ايصال الشراء";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelSupp);
            this.groupBox2.Controls.Add(this.radioWithSupp);
            this.groupBox2.Controls.Add(this.radioWithoutSupp);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(584, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المورد";
            // 
            // panelSupp
            // 
            this.panelSupp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSupp.Controls.Add(this.btnSupp);
            this.panelSupp.Controls.Add(this.txtSuppName);
            this.panelSupp.Controls.Add(this.txtCompany);
            this.panelSupp.Controls.Add(this.label5);
            this.panelSupp.Controls.Add(this.txtSuppPhone);
            this.panelSupp.Controls.Add(this.label6);
            this.panelSupp.Controls.Add(this.label7);
            this.panelSupp.Controls.Add(this.txtSuppId);
            this.panelSupp.Controls.Add(this.label8);
            this.panelSupp.Location = new System.Drawing.Point(6, 44);
            this.panelSupp.Name = "panelSupp";
            this.panelSupp.Size = new System.Drawing.Size(572, 148);
            this.panelSupp.TabIndex = 6;
            // 
            // btnSupp
            // 
            this.btnSupp.Image = global::Super_Market.Properties.Resources.group_blue;
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupp.Location = new System.Drawing.Point(6, 5);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(139, 30);
            this.btnSupp.TabIndex = 12;
            this.btnSupp.Text = "قائمة الموردين";
            this.btnSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(6, 41);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(490, 30);
            this.txtSuppName.TabIndex = 11;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(6, 113);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(490, 30);
            this.txtCompany.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "الشركة";
            // 
            // txtSuppPhone
            // 
            this.txtSuppPhone.Location = new System.Drawing.Point(6, 77);
            this.txtSuppPhone.Name = "txtSuppPhone";
            this.txtSuppPhone.Size = new System.Drawing.Size(490, 30);
            this.txtSuppPhone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "الهاتف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "اسم المورد";
            // 
            // txtSuppId
            // 
            this.txtSuppId.Location = new System.Drawing.Point(378, 5);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(118, 30);
            this.txtSuppId.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "المعرف";
            // 
            // radioWithSupp
            // 
            this.radioWithSupp.AutoSize = true;
            this.radioWithSupp.Location = new System.Drawing.Point(17, 18);
            this.radioWithSupp.Name = "radioWithSupp";
            this.radioWithSupp.Size = new System.Drawing.Size(86, 26);
            this.radioWithSupp.TabIndex = 5;
            this.radioWithSupp.Text = "اضافة مورد";
            this.radioWithSupp.UseVisualStyleBackColor = true;
            this.radioWithSupp.CheckedChanged += new System.EventHandler(this.radioWithSupp_CheckedChanged);
            // 
            // radioWithoutSupp
            // 
            this.radioWithoutSupp.AutoSize = true;
            this.radioWithoutSupp.Checked = true;
            this.radioWithoutSupp.Location = new System.Drawing.Point(486, 18);
            this.radioWithoutSupp.Name = "radioWithoutSupp";
            this.radioWithoutSupp.Size = new System.Drawing.Size(82, 26);
            this.radioWithoutSupp.TabIndex = 4;
            this.radioWithoutSupp.TabStop = true;
            this.radioWithoutSupp.Text = "بدون مورد";
            this.radioWithoutSupp.UseVisualStyleBackColor = true;
            this.radioWithoutSupp.CheckedChanged += new System.EventHandler(this.radioWithoutSupp_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateOrder);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalesMan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(594, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(281, 196);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // dateOrder
            // 
            this.dateOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOrder.Location = new System.Drawing.Point(6, 61);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(180, 30);
            this.dateOrder.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(6, 133);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(180, 58);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "وصف الفاتورة";
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalesMan.Enabled = false;
            this.txtSalesMan.Location = new System.Drawing.Point(6, 97);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(180, 30);
            this.txtSalesMan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاريخ الفاتورة";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.Location = new System.Drawing.Point(119, 25);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(67, 30);
            this.txtOrderID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // lastStatus
            // 
            this.lastStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lastStatus.BackColor = System.Drawing.Color.Maroon;
            this.lastStatus.Font = new System.Drawing.Font("Droid Arabic Kufi", 8F);
            this.lastStatus.ForeColor = System.Drawing.Color.White;
            this.lastStatus.Location = new System.Drawing.Point(133, 27);
            this.lastStatus.Name = "lastStatus";
            this.lastStatus.Size = new System.Drawing.Size(103, 21);
            this.lastStatus.TabIndex = 14;
            this.lastStatus.Text = "غير مضاف";
            this.lastStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastStatus.Visible = false;
            // 
            // UserControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlMain";
            this.Size = new System.Drawing.Size(880, 606);
            this.Load += new System.EventHandler(this.UserControlMain_Load);
            this.TabStopChanged += new System.EventHandler(this.UserControlMain_TabStopChanged);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchase)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelSupp.ResumeLayout(false);
            this.panelSupp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button BtnNew;
        public System.Windows.Forms.Button BtnExit;
        public System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgPurchase;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPurchaseQTE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRecived;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioWithSupp;
        private System.Windows.Forms.RadioButton radioWithoutSupp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSupp;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuppPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem نعديلسطرمحددToolStripMenuItem;
        private System.Windows.Forms.Label lastStatus;
    }
}
