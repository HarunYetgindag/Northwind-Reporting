namespace NorthwindReporting
{
    partial class FrmReport
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
            this.OrderReport1TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NorthwindDataSet = new NorthwindReporting.NorthwindDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Report1TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrderReport1TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report1TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderReport1TableBindingSource
            // 
            this.OrderReport1TableBindingSource.DataMember = "OrderReport1Table";
            this.OrderReport1TableBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // NorthwindDataSet
            // 
            this.NorthwindDataSet.DataSetName = "NorthwindDataSet";
            this.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Report1DataSet";
            reportDataSource1.Value = this.Report1TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NorthwindReporting.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(892, 429);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report1TableBindingSource
            // 
            this.Report1TableBindingSource.DataMember = "Report1Table";
            this.Report1TableBindingSource.DataSource = this.NorthwindDataSet;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 429);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.NorthwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report1TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderReport1TableBindingSource;
        private NorthwindDataSet NorthwindDataSet;
        private System.Windows.Forms.BindingSource Report1TableBindingSource;
    }
}

