namespace Super_Market.report.SuppPrint
{
    partial class FrmMicroSoft
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.printOneSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.super_MarketDataSet = new Super_Market.Super_MarketDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.printOneSupplierTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.PrintOneSupplierTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrintAllSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printAllSupplierTableAdapter = new Super_Market.Super_MarketDataSetTableAdapters.PrintAllSupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.printOneSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintAllSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printOneSupplierBindingSource
            // 
            this.printOneSupplierBindingSource.DataMember = "PrintOneSupplier";
            this.printOneSupplierBindingSource.DataSource = this.super_MarketDataSet;
            // 
            // super_MarketDataSet
            // 
            this.super_MarketDataSet.DataSetName = "Super_MarketDataSet";
            this.super_MarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.printOneSupplierBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Super_Market.report.SuppPrint.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(847, 467);
            this.reportViewer1.TabIndex = 0;
            // 
            // printOneSupplierTableAdapter
            // 
            this.printOneSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PrintAllSupplierBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Super_Market.report.SuppPrint.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(847, 467);
            this.reportViewer2.TabIndex = 1;
            // 
            // PrintAllSupplierBindingSource
            // 
            this.PrintAllSupplierBindingSource.DataMember = "PrintAllSupplier";
            this.PrintAllSupplierBindingSource.DataSource = this.super_MarketDataSet;
            // 
            // printAllSupplierTableAdapter
            // 
            this.printAllSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMicroSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 467);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMicroSoft";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الموردين";
            this.Load += new System.EventHandler(this.FrmMicroSoft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printOneSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.super_MarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintAllSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource printOneSupplierBindingSource;
        public Super_MarketDataSet super_MarketDataSet;
        public Super_MarketDataSetTableAdapters.PrintOneSupplierTableAdapter printOneSupplierTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public System.Windows.Forms.BindingSource PrintAllSupplierBindingSource;
        public Super_MarketDataSetTableAdapters.PrintAllSupplierTableAdapter printAllSupplierTableAdapter;
    }
}