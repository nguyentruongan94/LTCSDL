namespace DXApplication1
{
    partial class frmReportSP
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
            this.aocuoiDataSet = new DXApplication1.aocuoiDataSet();
            this.SANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SANPHAMTableAdapter = new DXApplication1.aocuoiDataSetTableAdapters.SANPHAMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SANPHAMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DXApplication1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(713, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // aocuoiDataSet
            // 
            this.aocuoiDataSet.DataSetName = "aocuoiDataSet";
            this.aocuoiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SANPHAMBindingSource
            // 
            this.SANPHAMBindingSource.DataMember = "SANPHAM";
            this.SANPHAMBindingSource.DataSource = this.aocuoiDataSet;
            // 
            // SANPHAMTableAdapter
            // 
            this.SANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportSP";
            this.Text = "frmReportSP";
            this.Load += new System.EventHandler(this.frmReportSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aocuoiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SANPHAMBindingSource;
        private aocuoiDataSet aocuoiDataSet;
        private aocuoiDataSetTableAdapters.SANPHAMTableAdapter SANPHAMTableAdapter;
    }
}