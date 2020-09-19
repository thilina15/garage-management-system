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

            updateTextFields();
            
            
        }

        //go to inventory of the job
        private void button1_Click(object sender, EventArgs e)
        {
            addingSpareParts sp = new addingSpareParts(jobRef);
            sp.Show();
            //this.Dispose();
        }

        //show history of vehicle
        private void button4_Click(object sender, EventArgs e)
        {
            jobHistory jh = new jobHistory(true, jobRef,this);
            jh.Show();
            this.Hide();
        }


        //hold the job
        private void button5_Click(object sender, EventArgs e)
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                jobRef.specialNote = txtSpecialNote.Text;
                jobRef.status = state.hold.ToString();
                db.Entry(jobRef).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                updateTextFields();
            }
        }


        //start the job
        private void button6_Click(object sender, EventArgs e)
        {
            using (sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                jobRef.specialNote = txtSpecialNote.Text;
                jobRef.status = state.working.ToString();
                db.Entry(jobRef).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                updateTextFields();
            }
        }


        //complete the job from garage
        private void button7_Click(object sender, EventArgs e)
        {
            using (sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                jobRef.specialNote = txtSpecialNote.Text;
                jobRef.status = state.workDone.ToString();
                db.Entry(jobRef).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                updateTextFields();
            }
        }

        //update text filds
        private void updateTextFields()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                lblItemCost.Text = jobRef.itemsCost.ToString();
                lblJobDescription.Text = jobRef.description.ToString();
                lblJobID.Text = jobRef.jobID.ToString();
                txtSpecialNote.Text = jobRef.specialNote.ToString();
                lblStatus.Text = jobRef.status.ToString();
                lblVehicleID.Text = jobRef.vehicle.ToString();

            }
            
        }
    }
}
