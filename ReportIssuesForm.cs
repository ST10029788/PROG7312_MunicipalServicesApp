using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        private List<IssueReport> issueReports = new List<IssueReport>(); // List to store reported issues

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Initialize form elements 
            cmbCategory.SelectedIndex = -1; // No selection
            txtLocation.Clear(); // Clear any existing text
            rtbDescription.Clear(); // Clear any existing text

            // Initialize ProgressBar
            progressBarEngagement.Minimum = 0;
            progressBarEngagement.Maximum = 100; // Adjust according to your progress logic
            progressBarEngagement.Value = 0;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20); // 20% progress for selecting a category
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx|All Files|*.*",
                Title = "Select a file to attach"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Handle the file attachment (e.g., save path, display confirmation)
                MessageBox.Show("File attached: " + filePath);
                UpdateProgressBar(20); // 20% progress for attaching a media file
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) // Optionally validate the form before submission
            {
                // Create a new issue report and add it to the list
                IssueReport newReport = new IssueReport
                {
                    Location = txtLocation.Text,
                    Category = cmbCategory.SelectedItem.ToString(),
                    Description = rtbDescription.Text,
                    // Optionally include other fields like media paths
                };

                issueReports.Add(newReport);

                // Example: Save the report to a database or send it to a server
                MessageBox.Show("Issue reported successfully!", "Submission Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form fields (if needed)
                ResetFormFields();

                // Reset the ProgressBar after submission
                ResetProgressBar();
            }
            else
            {
                MessageBox.Show("Please complete all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Close();
        }

        private void UpdateProgressBar(int increment)
        {
            if (progressBarEngagement.Value + increment <= progressBarEngagement.Maximum)
            {
                progressBarEngagement.Value += increment;
            }
        }

        private void ResetProgressBar()
        {
            progressBarEngagement.Value = 0;
        }

        private void ResetFormFields()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1; // Deselects any selected category
            rtbDescription.Clear();
            // Optionally reset any other fields
        }

        private bool ValidateForm()
        {
            return !(string.IsNullOrWhiteSpace(txtLocation.Text) ||
                     cmbCategory.SelectedIndex == -1 ||
                     string.IsNullOrWhiteSpace(rtbDescription.Text));
        }

        // Define a class to represent an issue report
      

        private void btnShowReportList_Click(object sender, EventArgs e)
        {
            ReportListForm reportListForm = new ReportListForm(issueReports);
            reportListForm.ShowDialog();
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }
    }
}