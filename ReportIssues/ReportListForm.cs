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
        //method adapted from Clare, J. (2024). Updating of BindingSource in WinForms does not update Datasource Collection. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/14571451/updating-of-bindingsource-in-winforms-does-not-update-datasource-collection [Accessed 11 Sep. 2024].
        //Jeff Clare
        //https://stackoverflow.com/users/2019580/jeff-clare
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