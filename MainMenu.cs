using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
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

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
