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
    public class Feedback
    {
        public string OverallRating { get; set; }
        public string LikedMost { get; set; }
        public string LikedLeast { get; set; }
        public string Suggestions { get; set; }
        public bool ClearAndConcise { get; set; }
        public bool HelpfulFields { get; set; }
    }
    public partial class FeedbackForm : Form
    {
        private List<Feedback> feedbackList = new List<Feedback>();
        //method adapted from Stack Overflow
        //grey, nunsy (2024). Empty textBox (null; string.IsNullOrEmpty) Issue in TextChanged. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/19933230/empty-textbox-null-string-isnullorempty-issue-in-textchanged [Accessed 9 Sep. 2024].
        //https://stackoverflow.com/users/2796004/nunsy-grey
        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            // Validate feedback data
            if (numericUpDownSatisfaction.Value == 0 || string.IsNullOrEmpty(textBoxLikeMost.Text) || string.IsNullOrEmpty(textBoxLikeLeast.Text) || string.IsNullOrEmpty(textBoxSuggestions.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Collect feedback data
            Feedback feedback = new Feedback
            {
                
                OverallRating = numericUpDownSatisfaction.Value.ToString(),
                LikedMost = textBoxLikeMost.Text,
                LikedLeast = textBoxLikeLeast.Text,
                Suggestions = textBoxSuggestions.Text,

                //method adapted from StackOverflow
                //Roshan (2024). How to get the selected item of a combo box to a string variable in c#. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/15186093/how-to-get-the-selected-item-of-a-combo-box-to-a-string-variable-in-c-sharp [Accessed 11 Sep. 2024].
                //https://stackoverflow.com/users/2091805/roshan
                //checks if the selected item is "Yes", sets to true. If the selected item is "No", it sets the property to false.
                ClearAndConcise = comboBoxClear.SelectedItem.ToString() == "Yes",
                HelpfulFields = comboBoxHelpful.SelectedItem.ToString() == "Yes"
            };

            // Add feedback to the list
            feedbackList.Add(feedback);

            // Close the feedback form
            this.Close();
        }


        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDownSatisfaction_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLikeMost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLikeLeast_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSuggestions_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxClear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHelpful_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
