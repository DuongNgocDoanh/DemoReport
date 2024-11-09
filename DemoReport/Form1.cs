using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 data = new Class1();
            reportViewer1.LocalReport.ReportEmbeddedResource = "DemoReport.Report1.rdlc";
            ReportDataSource reportData = new ReportDataSource();
            reportData.Name = "DataSet1";
            reportData.Value = data.GetThuMuc();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            this.reportViewer1.RefreshReport();
        }
    }
}
