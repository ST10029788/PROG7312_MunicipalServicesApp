namespace MunicipalServicesApp
{
    partial class ReportIssuesForm
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
            this.txtLocation = new System.Windows.Forms.RichTextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.progressBarEngagement = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowReportList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(274, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(523, 29);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLocation.Location = new System.Drawing.Point(3, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 1;
            this.labelLocation.Text = "Location:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Other",
            "Roads",
            "Utilities",
            "Water Supply",
            "Electricity",
            "Public Safety",
            "Waste Management",
            "Vandalism",
            "Illegal Dumping",
            "Potholes",
            "Traffic Signals",
            "Noise Pollution",
            "Animal Control",
            "Environmental Hazards",
            "Abandoned Vehicles",
            "Flooding "});
            this.cmbCategory.Location = new System.Drawing.Point(274, 38);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(523, 28);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCategory.Location = new System.Drawing.Point(3, 35);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(77, 20);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category:";
            this.labelCategory.Click += new System.EventHandler(this.labelCategory_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(274, 73);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(523, 49);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDescription.Location = new System.Drawing.Point(3, 70);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 20);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description:";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachMedia.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAttachMedia.Location = new System.Drawing.Point(3, 3);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(394, 44);
            this.btnAttachMedia.TabIndex = 6;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSubmit.Location = new System.Drawing.Point(403, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(394, 44);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // progressBarEngagement
            // 
            this.progressBarEngagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarEngagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressBarEngagement.Location = new System.Drawing.Point(0, 0);
            this.progressBarEngagement.Name = "progressBarEngagement";
            this.progressBarEngagement.Size = new System.Drawing.Size(800, 19);
            this.progressBarEngagement.TabIndex = 8;
            this.progressBarEngagement.Click += new System.EventHandler(this.progressBarEngagement_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBack.Location = new System.Drawing.Point(3, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(394, 44);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back to Main Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowReportList
            // 
            this.btnShowReportList.AutoSize = true;
            this.btnShowReportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReportList.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShowReportList.Location = new System.Drawing.Point(403, 53);
            this.btnShowReportList.Name = "btnShowReportList";
            this.btnShowReportList.Size = new System.Drawing.Size(394, 44);
            this.btnShowReportList.TabIndex = 11;
            this.btnShowReportList.Text = "Show Report List";
            this.btnShowReportList.UseVisualStyleBackColor = true;
            this.btnShowReportList.Click += new System.EventHandler(this.btnShowReportList_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.96227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.03773F));
            this.tableLayoutPanel1.Controls.Add(this.labelLocation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLocation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtbDescription, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 125);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnShowReportList, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBack, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAttachMedia, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBarEngagement);
            this.Name = "ReportIssuesForm";
            this.Text = "Report an Issue";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ProgressBar progressBarEngagement;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowReportList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}