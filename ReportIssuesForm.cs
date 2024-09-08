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
            txtLocation.Clear(); // Clear any existing text i box
            rtbDescription.Clear(); // Clear any existing text in box

            // Initialize ProgressBar
            progressBarEngagement.Minimum = 0;
            progressBarEngagement.Maximum = 100; // progress logic
            progressBarEngagement.Value = 0;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                UpdateProgressBar(10); // 10% progress for entering location
            }
            else
            {
                // If the text is cleared, decrement the progress bar value
                UpdateProgressBar(-10);
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                UpdateProgressBar(30); // 30% progress for entering description
            }
            else
            {
                // If the text is cleared, decrement the progress bar value
                UpdateProgressBar(-30);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20); // 20% progress for selecting a category
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter a valid location.", "Invalid Location", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "No Category Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "No Description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            return isValid;
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

                if (string.IsNullOrWhiteSpace(filePath) || filePath.Length > 255)
                {
                    MessageBox.Show("Invalid file path or file too large.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Handle the file attachment display confirmation
                MessageBox.Show("File attached: " + filePath);
                UpdateProgressBar(20); // 20% progress for attaching a media file
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm()) //Validate the form before submission
            {
                try
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

                    // Save the report to a database or send it to a server later in development
                    // Display confirmation message

                    MessageBox.Show("Thank you for submitting your issue report! We'll review it and get back to you soon.", "Submission Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult response = MessageBox.Show("Would you like to provide feedback about the reporting process?", "Submission Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (response == DialogResult.Yes)
                    {
                        // Display feedback form
                        FeedbackForm feedbackForm = new FeedbackForm();
                        feedbackForm.ShowDialog();
                    }

                    // Reset the form fields
                    ResetFormFields();

                    // Reset the ProgressBar after submission
                    ResetProgressBar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while submitting the report: " + ex.Message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            int newValue = progressBarEngagement.Value + increment;
            if (newValue <= progressBarEngagement.Maximum && newValue >= progressBarEngagement.Minimum)
            {
                progressBarEngagement.Value = newValue;
            }
            else if (newValue > progressBarEngagement.Maximum)
            {
                progressBarEngagement.Value = progressBarEngagement.Maximum;
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
           
        }

      

  
      

        private void btnShowReportList_Click(object sender, EventArgs e)
        {
            ReportListForm reportListForm = new ReportListForm(issueReports);
            reportListForm.ShowDialog();
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBarEngagement_Click(object sender, EventArgs e)
        {

        }
    }
}