using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _DataLayer;
using _BusinessLayer;
using _BusinessLayer.Repository.Concrete;
using Microsoft.Reporting.WinForms;

namespace NorthwindReporting
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            ProductConcrete pc = new ProductConcrete();


            NorthwindDataSet dataSet = new NorthwindDataSet();
            
            foreach (var p in pc.Report1Result())
            {
                dataSet.Report1Table.AddReport1TableRow(p.ProductID.ToString(), p.ProductName, p.UnitPrice.ToString(), p.UnitsInStock.ToString(), p.CategoryName);
            }
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            LocalReport localReport = reportViewer1.LocalReport;
            localReport.ReportPath = "Reports/Report1.rdlc";
            ReportDataSource dataSource = new ReportDataSource("Report1DataSet");
            dataSource.Name = "Report1DataSet";
            dataSource.Value = dataSet.Report1Table;
            reportViewer1.LocalReport.DataSources.Clear();
            localReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
