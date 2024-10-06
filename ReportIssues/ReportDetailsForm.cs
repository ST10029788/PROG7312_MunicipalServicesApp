using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static MunicipalServicesApp.ReportIssuesForm;

namespace MunicipalServicesApp
{
    public partial class ReportDetailsForm : Form
    {
        private IssueReport report;

        public ReportDetailsForm(IssueReport report)
        {
            InitializeComponent();
            this.report = report;
        }

        private void ReportDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
