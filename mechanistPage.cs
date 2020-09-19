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
    public partial class mechanistPage : Form
    {
        public mechanistPage()
        {
            InitializeComponent();
            //tables default settings
            dgvNewJobs.AutoGenerateColumns = dgvHoldJobs.AutoGenerateColumns= dgvOngoingJobs.AutoGenerateColumns= false;
            dgvNewJobs.DefaultCellStyle.Font = dgvHoldJobs.DefaultCellStyle.Font= dgvOngoingJobs.DefaultCellStyle.Font= new Font("Thoma", 15);
            
            fillNewJobs();
            fillHoldJobs();
            fillOnGoingJobs();
            timer1.Start();
        }

        //fill new jobs data table
        private void fillNewJobs()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                job[] newJobs = db.jobs.Where(x => x.status == state.created.ToString()).ToArray();
                dgvNewJobs.DataSource = newJobs;
            }
            
        }

        //fill hold jobs
        private void fillHoldJobs()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                job[] holdJobs = db.jobs.Where(x => x.status == state.hold.ToString()).ToArray();
                dgvHoldJobs.DataSource = holdJobs;
            }
        }

        //fill ongoing job field
        private void fillOnGoingJobs()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                job[] onGoingJobs = db.jobs.Where(x => x.status == state.working.ToString()).ToArray();
                dgvOngoingJobs.DataSource = onGoingJobs;
            }
        }

        //new job click
        private void dgvNewJobs_DoubleClick(object sender, EventArgs e)
        {
            if (dgvNewJobs.CurrentRow.Index != -1)
            {
                job jb = new job();
                jb.jobID = Convert.ToInt32(dgvNewJobs.CurrentRow.Cells["jobID"].Value);
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    jb = db.jobs.Where(x => x.jobID == jb.jobID).FirstOrDefault();
                    jobDetails jd = new jobDetails(jb);
                    jd.Show();
                }
            }
        }

        //hold job click
        private void dgvHoldJobs_Click(object sender, EventArgs e)
        {
            if (dgvHoldJobs.CurrentRow.Index != -1)
            {
                job jb = new job();
                jb.jobID = Convert.ToInt32(dgvHoldJobs.CurrentRow.Cells["holdJobID"].Value);
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    jb = db.jobs.Where(x => x.jobID == jb.jobID).FirstOrDefault();
                    jobDetails jd = new jobDetails(jb);
                    jd.Show();
                }
            }
        }

        //ongoing job click
        private void dgvOngoingJobs_DoubleClick(object sender, EventArgs e)
        {
            if (dgvOngoingJobs.CurrentRow.Index != -1)
            {
                job jb = new job();
                jb.jobID = Convert.ToInt32(dgvOngoingJobs.CurrentRow.Cells["goingJobID"].Value);
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    jb = db.jobs.Where(x => x.jobID == jb.jobID).FirstOrDefault();
                    jobDetails jd = new jobDetails(jb);
                    jd.Show();
                }
            }
        }

        //exit button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            fillNewJobs();
            fillHoldJobs();
            fillOnGoingJobs();
        }
    }
}
