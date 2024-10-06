namespace MunicipalServicesApp
{
    partial class FeedbackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLikeMost = new System.Windows.Forms.Label();
            this.labelLikeLeast = new System.Windows.Forms.Label();
            this.labelSuggestions = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.labelHelpful = new System.Windows.Forms.Label();
            this.labelOverall = new System.Windows.Forms.Label();
            this.textBoxLikeMost = new System.Windows.Forms.TextBox();
            this.textBoxLikeLeast = new System.Windows.Forms.TextBox();
            this.textBoxSuggestions = new System.Windows.Forms.TextBox();
            this.numericUpDownSatisfaction = new System.Windows.Forms.NumericUpDown();
            this.comboBoxHelpful = new System.Windows.Forms.ComboBox();
            this.comboBoxClear = new System.Windows.Forms.ComboBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatisfaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxClear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSuggestions, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLikeLeast, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLikeMost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLikeLeast, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSuggestions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.c, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelHelpful, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelOverall, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLikeMost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSatisfaction, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxHelpful, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // labelLikeMost
            // 
            this.labelLikeMost.AutoSize = true;
            this.labelLikeMost.Location = new System.Drawing.Point(3, 0);
            this.labelLikeMost.Name = "labelLikeMost";
            this.labelLikeMost.Size = new System.Drawing.Size(239, 40);
            this.labelLikeMost.TabIndex = 0;
            this.labelLikeMost.Text = "What did you like most about the reporting process?";
            this.labelLikeMost.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLikeLeast
            // 
            this.labelLikeLeast.AutoSize = true;
            this.labelLikeLeast.Location = new System.Drawing.Point(3, 60);
            this.labelLikeLeast.Name = "labelLikeLeast";
            this.labelLikeLeast.Size = new System.Drawing.Size(238, 40);
            this.labelLikeLeast.TabIndex = 1;
            this.labelLikeLeast.Text = "What did you like the least about the reporting process?";
            // 
            // labelSuggestions
            // 
            this.labelSuggestions.AutoSize = true;
            this.labelSuggestions.Location = new System.Drawing.Point(3, 120);
            this.labelSuggestions.Name = "labelSuggestions";
            this.labelSuggestions.Size = new System.Drawing.Size(239, 40);
            this.labelSuggestions.TabIndex = 2;
            this.labelSuggestions.Text = "Do you have any suggestions for improving the reporting process?";
            this.labelSuggestions.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(3, 180);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(237, 40);
            this.c.TabIndex = 3;
            this.c.Text = "Was the reporting process clear and concise?";
            // 
            // labelHelpful
            // 
            this.labelHelpful.AutoSize = true;
            this.labelHelpful.Location = new System.Drawing.Point(3, 240);
            this.labelHelpful.Name = "labelHelpful";
            this.labelHelpful.Size = new System.Drawing.Size(186, 40);
            this.labelHelpful.TabIndex = 4;
            this.labelHelpful.Text = "Were the form fields and instructions helpful?";
            // 
            // labelOverall
            // 
            this.labelOverall.AutoSize = true;
            this.labelOverall.Location = new System.Drawing.Point(3, 300);
            this.labelOverall.Name = "labelOverall";
            this.labelOverall.Size = new System.Drawing.Size(176, 40);
            this.labelOverall.TabIndex = 5;
            this.labelOverall.Text = "Please rate your overall satisfaction from 1 to 5";
            this.labelOverall.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBoxLikeMost
            // 
            this.textBoxLikeMost.Location = new System.Drawing.Point(248, 3);
            this.textBoxLikeMost.Name = "textBoxLikeMost";
            this.textBoxLikeMost.Size = new System.Drawing.Size(374, 26);
            this.textBoxLikeMost.TabIndex = 6;
            this.textBoxLikeMost.TextChanged += new System.EventHandler(this.textBoxLikeMost_TextChanged);
            // 
            // textBoxLikeLeast
            // 
            this.textBoxLikeLeast.Location = new System.Drawing.Point(248, 63);
            this.textBoxLikeLeast.Name = "textBoxLikeLeast";
            this.textBoxLikeLeast.Size = new System.Drawing.Size(374, 26);
            this.textBoxLikeLeast.TabIndex = 7;
            this.textBoxLikeLeast.TextChanged += new System.EventHandler(this.textBoxLikeLeast_TextChanged);
            // 
            // textBoxSuggestions
            // 
            this.textBoxSuggestions.Location = new System.Drawing.Point(248, 123);
            this.textBoxSuggestions.Name = "textBoxSuggestions";
            this.textBoxSuggestions.Size = new System.Drawing.Size(374, 26);
            this.textBoxSuggestions.TabIndex = 8;
            this.textBoxSuggestions.TextChanged += new System.EventHandler(this.textBoxSuggestions_TextChanged);
            // 
            // numericUpDownSatisfaction
            // 
            this.numericUpDownSatisfaction.Location = new System.Drawing.Point(248, 303);
            this.numericUpDownSatisfaction.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSatisfaction.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSatisfaction.Name = "numericUpDownSatisfaction";
            this.numericUpDownSatisfaction.Size = new System.Drawing.Size(374, 26);
            this.numericUpDownSatisfaction.TabIndex = 11;
            this.numericUpDownSatisfaction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSatisfaction.ValueChanged += new System.EventHandler(this.numericUpDownSatisfaction_ValueChanged);
            // 
            // comboBoxHelpful
            // 
            this.comboBoxHelpful.FormattingEnabled = true;
            this.comboBoxHelpful.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxHelpful.Location = new System.Drawing.Point(248, 243);
            this.comboBoxHelpful.Name = "comboBoxHelpful";
            this.comboBoxHelpful.Size = new System.Drawing.Size(374, 28);
            this.comboBoxHelpful.TabIndex = 12;
            this.comboBoxHelpful.SelectedIndexChanged += new System.EventHandler(this.comboBoxHelpful_SelectedIndexChanged);
            // 
            // comboBoxClear
            // 
            this.comboBoxClear.FormattingEnabled = true;
            this.comboBoxClear.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxClear.Location = new System.Drawing.Point(248, 183);
            this.comboBoxClear.Name = "comboBoxClear";
            this.comboBoxClear.Size = new System.Drawing.Size(374, 28);
            this.comboBoxClear.TabIndex = 13;
            this.comboBoxClear.SelectedIndexChanged += new System.EventHandler(this.comboBoxClear_SelectedIndexChanged);
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitFeedback.Location = new System.Drawing.Point(0, 380);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(800, 70);
            this.btnSubmitFeedback.TabIndex = 1;
            this.btnSubmitFeedback.Text = "Submit Feedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSatisfaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelLikeMost;
        private System.Windows.Forms.Label labelLikeLeast;
        private System.Windows.Forms.Label labelSuggestions;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label labelHelpful;
        private System.Windows.Forms.Label labelOverall;
        private System.Windows.Forms.TextBox textBoxSuggestions;
        private System.Windows.Forms.TextBox textBoxLikeLeast;
        private System.Windows.Forms.TextBox textBoxLikeMost;
        private System.Windows.Forms.NumericUpDown numericUpDownSatisfaction;
        private System.Windows.Forms.ComboBox comboBoxClear;
        private System.Windows.Forms.ComboBox comboBoxHelpful;
        private System.Windows.Forms.Button btnSubmitFeedback;
    }
}