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
        private BindingSource bindingSource;

        public ReportListForm(List<IssueReport> reports)
        {
            InitializeComponent();
            this.issueReports = reports;
            bindingSource = new BindingSource();
        }

        private void ReportListForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = issueReports;
            dgvReports.DataSource = bindingSource;
            dgvReports.AutoGenerateColumns = true;
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

