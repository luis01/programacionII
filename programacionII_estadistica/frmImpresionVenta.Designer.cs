namespace programacionII_estadistica
{
    partial class frmImpresionVenta
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistema_dbDataSet = new programacionII_estadistica.sistema_dbDataSet();
            this.rptVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptVentasTableAdapter = new programacionII_estadistica.sistema_dbDataSetTableAdapters.rptVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsRptVentas";
            reportDataSource1.Value = this.rptVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "programacionII_estadistica.rptVEntas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistema_dbDataSet
            // 
            this.sistema_dbDataSet.DataSetName = "sistema_dbDataSet";
            this.sistema_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVentasBindingSource
            // 
            this.rptVentasBindingSource.DataMember = "rptVentas";
            this.rptVentasBindingSource.DataSource = this.sistema_dbDataSet;
            // 
            // rptVentasTableAdapter
            // 
            this.rptVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 559);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmImpresionVenta";
            this.Text = "Factura de Venta";
            this.Load += new System.EventHandler(this.frmImpresionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rptVentasBindingSource;
        private sistema_dbDataSet sistema_dbDataSet;
        private sistema_dbDataSetTableAdapters.rptVentasTableAdapter rptVentasTableAdapter;
    }
}