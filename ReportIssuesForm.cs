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
        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20); // 20% progress for selecting a category


        }

        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx|All Files|*.*";
            openFileDialog.Title = "Select a file to attach";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                // Handle the file attachment (e.g., save path, display confirmation)
                MessageBox.Show("File attached: " + filePath);
                UpdateProgressBar(20); // 20% progress for attaching a media file

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { // Handle form submission logic here
            if (ValidateForm()) // Optionally validate the form before submission
            {
                // Save the report to a database or send it to a server
                MessageBox.Show("Issue reported successfully!", "Submission Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form fields
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
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20); //20% progress when the location is filled

        }

        private void UpdateProgressBar(int increment)
        {
            if (progressBarEngagement.Value + increment <= progressBarEngagement.Maximum)
            {
                progressBarEngagement.Value += increment;
            }
        }

        private void progressBarEngagement_Click(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(20); //20% progress for filling out the description

        }

        private void ResetProgressBar()
        {
            progressBarEngagement.Value = 0;
        }

        private void ResetFormFields()
        {
            txtLocation.Text = string.Empty;
            cmbCategory.SelectedIndex = -1; // Deselects any selected category
            rtbDescription.Clear();
            // Optionally reset any other fields
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                return false;
            }
            return true;
        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
