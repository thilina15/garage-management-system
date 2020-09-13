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
    public partial class jobDetails : Form
    {
        job jobRef;
        public jobDetails()
        {
            InitializeComponent();
        }

        //overide constructor...........
        public jobDetails(job job)
        {
            InitializeComponent();
            jobRef = job;
            //jobRef.setItemCost();

            lblItemCost.Text = jobRef.itemsCost.ToString();
            lblJobDescription.Text = jobRef.description.ToString();
            lblJobID.Text = jobRef.jobID.ToString();
            txtSpecialNote.Text = jobRef.specialNote.ToString();
            lblStatus.Text = jobRef.status.ToString();
            lblVehicleID.Text = jobRef.vehicle.ToString();
            
            
        }

        //go to inventory of the job
        private void button1_Click(object sender, EventArgs e)
        {
            addingSpareParts sp = new addingSpareParts(jobRef);
            sp.Show();
            this.Dispose();
        }
    }
}
