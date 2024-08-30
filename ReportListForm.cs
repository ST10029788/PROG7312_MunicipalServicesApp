using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static MunicipalServicesApp.ReportIssuesForm;

namespace MunicipalServicesApp
{
    public partial class ReportListForm : Form
    {
        private List<IssueReport> issueReports;

        public ReportListForm(List<IssueReport> reports)
        {
            InitializeComponent();
            this.issueReports = reports;
        }

        private void ReportListForm_Load(object sender, EventArgs e)
        {
            dgvReports.DataSource = issueReports;
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReportListForm_Load_1(object sender, EventArgs e)
        {

        }
    }

}

