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
            //method adapted from StackOverflow
            //SaphuA (2024). Hide main form C# on autorun. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/5022414/hide-main-form-c-sharp-on-autorun [Accessed 9 Sep. 2024].
            //https://stackoverflow.com/users/314447/saphua
            // Open the Report Issues form
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            this.Hide(); // Hide the main form
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Hide(); // Hide the main form
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm serviceStatusForm = new ServiceRequestStatusForm();
            serviceStatusForm.ShowDialog();


        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
