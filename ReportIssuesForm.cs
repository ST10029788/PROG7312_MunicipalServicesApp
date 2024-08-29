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
            // Initialize TextBox for Location
            txtLocation.Text = string.Empty; // Clear any existing text

            // Initialize RichTextBox for Description
            rtbDescription.Text = string.Empty; // Clear any existing text

            // Initialize ProgressBar
            progressBarEngagement.Minimum = 0;
            progressBarEngagement.Maximum = 100; // Adjust according to your progress logic
            progressBarEngagement.Value = 0;

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateProgressBar(20); // 20% progress for selecting a category
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating progress bar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error attaching media: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting the form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error navigating back: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateProgressBar(20); // 20% progress when the location is filled
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating progress bar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProgressBar(int increment)
        {
            try
            {
                if (progressBarEngagement.Value + increment <= progressBarEngagement.Maximum)
                {
                    progressBarEngagement.Value += increment;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating progress bar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetProgressBar()
        {
            try
            {
                progressBarEngagement.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting progress bar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFormFields()
        {
            try
            {
                txtLocation.Text = string.Empty;
                cmbCategory.SelectedIndex = -1; // Deselects any selected category
                rtbDescription.Clear();
                // Optionally reset any other fields
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting form fields: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            try
            {
                return !(string.IsNullOrWhiteSpace(txtLocation.Text) ||
                         cmbCategory.SelectedIndex == -1 ||
                         string.IsNullOrWhiteSpace(rtbDescription.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Define a class to represent an issue report
        private class IssueReport
        {
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            // Optionally include other properties like media file paths
        }
    }
}