namespace MunicipalServicesApp
{
    partial class LocalEventsForm
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoryPick = new System.Windows.Forms.ComboBox();
            this.txtbSearchEvents = new System.Windows.Forms.TextBox();
            this.lblCombo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEventSearch = new System.Windows.Forms.Label();
            this.btnSearchEvents = new System.Windows.Forms.Button();
            this.rtbEvents = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(995, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Events";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.25899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.74101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateRange, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFrom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpTo, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.37908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(994, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRange.ForeColor = System.Drawing.Color.Maroon;
            this.lblDateRange.Location = new System.Drawing.Point(3, 0);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(250, 31);
            this.lblDateRange.TabIndex = 1;
            this.lblDateRange.Text = "Select Date Range:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpFrom.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(394, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(298, 34);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarForeColor = System.Drawing.Color.Maroon;
            this.dtpTo.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(698, 3);
            this.dtpTo.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(293, 34);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // cmbCategoryPick
            // 
            this.cmbCategoryPick.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCategoryPick.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCategoryPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryPick.FormattingEnabled = true;
            this.cmbCategoryPick.Items.AddRange(new object[] {
            "All",
            "Community & Cultural",
            "",
            "Sports & Fitness",
            "",
            "Public Meetings",
            "",
            "Arts & Performance",
            "",
            "Local Business & Markets",
            "",
            "Education & Workshops",
            "",
            "Environmental & Outdoors"});
            this.cmbCategoryPick.Location = new System.Drawing.Point(395, 48);
            this.cmbCategoryPick.Name = "cmbCategoryPick";
            this.cmbCategoryPick.Size = new System.Drawing.Size(600, 39);
            this.cmbCategoryPick.TabIndex = 4;
            // 
            // txtbSearchEvents
            // 
            this.txtbSearchEvents.AutoCompleteCustomSource.AddRange(new string[] {
            "Community",
            "Cultural",
            "Arts",
            "Performance",
            "Environmental",
            "Outdoors",
            "Education",
            "Workshops",
            "Workshop",
            "Celebration",
            "Local",
            "Festival",
            "Park",
            "Party",
            "Run",
            "Lecture",
            "Expo"});
            this.txtbSearchEvents.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbSearchEvents.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbSearchEvents.BackColor = System.Drawing.SystemColors.Info;
            this.txtbSearchEvents.CausesValidation = false;
            this.txtbSearchEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearchEvents.Location = new System.Drawing.Point(395, 3);
            this.txtbSearchEvents.Name = "txtbSearchEvents";
            this.txtbSearchEvents.Size = new System.Drawing.Size(603, 38);
            this.txtbSearchEvents.TabIndex = 5;
            this.txtbSearchEvents.TextChanged += new System.EventHandler(this.txtbSearchEvents_TextChanged);
            // 
            // lblCombo
            // 
            this.lblCombo.AutoSize = true;
            this.lblCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombo.Location = new System.Drawing.Point(3, 45);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Size = new System.Drawing.Size(241, 31);
            this.lblCombo.TabIndex = 6;
            this.lblCombo.Text = "Select A Category:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.1716F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.8284F));
            this.tableLayoutPanel2.Controls.Add(this.lblCombo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtbSearchEvents, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblEventSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbCategoryPick, 1, 1);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1001, 90);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblEventSearch
            // 
            this.lblEventSearch.AutoSize = true;
            this.lblEventSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSearch.Location = new System.Drawing.Point(3, 0);
            this.lblEventSearch.Name = "lblEventSearch";
            this.lblEventSearch.Size = new System.Drawing.Size(261, 31);
            this.lblEventSearch.TabIndex = 6;
            this.lblEventSearch.Text = "Search for an Event:";
            // 
            // btnSearchEvents
            // 
            this.btnSearchEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchEvents.BackColor = System.Drawing.Color.Moccasin;
            this.btnSearchEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEvents.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearchEvents.Location = new System.Drawing.Point(3, 0);
            this.btnSearchEvents.Name = "btnSearchEvents";
            this.btnSearchEvents.Size = new System.Drawing.Size(992, 44);
            this.btnSearchEvents.TabIndex = 0;
            this.btnSearchEvents.Text = "Search";
            this.btnSearchEvents.UseVisualStyleBackColor = false;
            this.btnSearchEvents.Click += new System.EventHandler(this.btnSearchEvents_Click);
            // 
            // rtbEvents
            // 
            this.rtbEvents.BackColor = System.Drawing.SystemColors.Info;
            this.rtbEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEvents.Location = new System.Drawing.Point(401, 3);
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.Size = new System.Drawing.Size(597, 570);
            this.rtbEvents.TabIndex = 4;
            this.rtbEvents.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.79461F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.20539F));
            this.tableLayoutPanel3.Controls.Add(this.lblRecommendations, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackToMainMenu, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.rtbEvents, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 227);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.45586F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.544141F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1002, 623);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendations.ForeColor = System.Drawing.Color.Maroon;
            this.lblRecommendations.Location = new System.Drawing.Point(3, 0);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(296, 31);
            this.lblRecommendations.TabIndex = 4;
            this.lblRecommendations.Text = "Recommended Events:";
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.AutoSize = true;
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(401, 579);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(594, 41);
            this.btnBackToMainMenu.TabIndex = 5;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchEvents);
            this.panel1.Location = new System.Drawing.Point(0, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 47);
            this.panel1.TabIndex = 6;
            // 
            // LocalEventsForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(995, 851);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LocalEventsForm";
            this.Text = "LocalEventsForm";
            this.Load += new System.EventHandler(this.LocalEventsForm_Load_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbCategoryPick;
        private System.Windows.Forms.TextBox txtbSearchEvents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblEventSearch;
        private System.Windows.Forms.Button btnSearchEvents;
        private System.Windows.Forms.RichTextBox rtbEvents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblRecommendations;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}