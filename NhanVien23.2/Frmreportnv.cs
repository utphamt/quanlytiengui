using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanVien23._2
{
    public partial class Frmreportnv : Form
    {
        public Frmreportnv()
        {
            InitializeComponent();
        }

        
        public void showReport(string reportFilename, string recordFilter, string reportTitle="")
        {
            ReportDocument rpt = new ReportDocument();
            string  path = string.Format("{0}\\NewFolder1\\nhanvien.rpt",
                Application.StartupPath
                , reportFilename);
                rpt.Load(path);
       
            TableLogOnInfo logonInfo = new TableLogOnInfo();
            logonInfo.ConnectionInfo.ServerName = " LAPTOP-9ENT18HU\\SQLEXPRESS";
            logonInfo.ConnectionInfo.DatabaseName = "vdnhanvien";
            logonInfo.ConnectionInfo.UserID = " sa";
            logonInfo.ConnectionInfo.Password = "06062002";
            foreach (Table t in rpt.Database.Tables)
                t.ApplyLogOnInfo(logonInfo);
            if (!string.IsNullOrEmpty(recordFilter))
                rpt.RecordSelectionFormula = recordFilter;

            if (!string.IsNullOrEmpty(reportTitle))
                rpt.SummaryInfo.ReportTitle = reportTitle;
                crystalReportViewer1.ReportSource = rpt;

         }
        public void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
