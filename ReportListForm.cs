using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            bindingSource.DataSource = issueReports;
        }

        private void ReportListForm_Load(object sender, EventArgs e)
        {
            dgvReports.DataSource = bindingSource;
            dgvReports.AutoGenerateColumns = true;
        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}