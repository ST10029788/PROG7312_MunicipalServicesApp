using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open the Report Issues form
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            this.Hide(); // Hide the main form
        }
    }
}
