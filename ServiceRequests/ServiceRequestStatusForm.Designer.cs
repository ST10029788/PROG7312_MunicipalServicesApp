using System.Windows.Forms;

namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.ListView lstServiceRequests;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.ToolTip toolTip;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lstServiceRequests = new System.Windows.Forms.ListView();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(299, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Service Request Status";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(3, 31);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(732, 64);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Track your submitted service requests and view their status:";
            // 
            // lstServiceRequests
            // 
            this.lstServiceRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstServiceRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstServiceRequests.FullRowSelect = true;
            this.lstServiceRequests.GridLines = true;
            this.lstServiceRequests.HideSelection = false;
            this.lstServiceRequests.Location = new System.Drawing.Point(3, 98);
            this.lstServiceRequests.Name = "lstServiceRequests";
            this.lstServiceRequests.Size = new System.Drawing.Size(798, 367);
            this.lstServiceRequests.TabIndex = 2;
            this.lstServiceRequests.UseCompatibleStateImageBehavior = false;
            this.lstServiceRequests.View = System.Windows.Forms.View.Details;
            this.lstServiceRequests.SelectedIndexChanged += new System.EventHandler(this.lstServiceRequests_SelectedIndexChanged);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(3, 498);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(798, 50);
            this.btnBackToMainMenu.TabIndex = 3;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.toolTip.SetToolTip(this.btnBackToMainMenu, "Click to return to the main menu.");
            this.btnBackToMainMenu.UseVisualStyleBackColor = true;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackToMainMenu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstServiceRequests, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPrompt, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 551);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(828, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "Service Request Status";
            this.Load += new System.EventHandler(this.ServiceRequestStatusForm_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
    }
}
