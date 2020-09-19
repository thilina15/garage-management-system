using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sunilGarageDataSet);

        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sunilGarageDataSet.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.sunilGarageDataSet.job);
            monthlyReport mr = new monthlyReport();
            mr.SetDataSource(this.sunilGarageDataSet);
            crystalReportViewer1.ReportSource = mr;

        }
    }
}
