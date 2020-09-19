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
    public partial class jobHistory : Form
    {
        bool vehicleBase;
        job initialJob;
        job[] jobArray;
        jobDetails previousPage;
        jobDetailsForAdmin previousPageAdmin;
        public jobHistory()
        {
            InitializeComponent();
        }

        //constructor for admin- from admin main page
        public jobHistory(bool x, job j)
        {
            InitializeComponent();
            vehicleBase = x;
            initialJob = j;
            dgvJobList.AutoGenerateColumns = false;
            fillJobList();
        }

        //comstructor for mechanic- from job details page
        public jobHistory(bool x, job j,jobDetails z)
        {
            InitializeComponent();
            vehicleBase = x;
            initialJob = j;
            previousPage = z;
            dgvJobList.AutoGenerateColumns = false;
            fillJobList();
        }

        //constructor for admin - from job details page
        public jobHistory(bool x, job j, jobDetailsForAdmin z)
        {
            InitializeComponent();
            vehicleBase = x;
            initialJob = j;
            previousPageAdmin = z;
            dgvJobList.AutoGenerateColumns = false;
            fillJobList();
        }


        //fill job history...........
        private void fillJobList()
        {
            //if showing vehicle history
            if (vehicleBase)
            {
                using(sunilGarageDBEntities db=new sunilGarageDBEntities())
                {
                    jobArray = db.jobs.Where(x => x.vehicle == initialJob.vehicle&&x.status==state.complete.ToString()).ToArray();
                }
            }
            else//if showing customer history
            {
                using(sunilGarageDBEntities db=new sunilGarageDBEntities())
                {
                    jobArray = db.jobs.Where(x => x.customerNIC == initialJob.customerNIC&&x.status==state.complete.ToString()).ToArray();
                }
            }
            dgvJobList.DataSource = jobArray;// fill job list

        }

        //set job details
        private void setJobDetails(job j)
        {
            
            lblCost.Text =(j.serviceCost+j.itemsCost).ToString();
            lblDate.Text = j.date.ToString();
            lblDescription.Text = j.description;
            lblJobID.Text = j.jobID.ToString();
            lblSpecialNote.Text = j.specialNote;
            lblVehicleID.Text = j.vehicle;
        }

        //when one job double cliked
        private void dgvJobList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvJobList.CurrentRow.Index != -1)
            {
                job jb = new job();
                jb.jobID = Convert.ToInt32(dgvJobList.CurrentRow.Cells["jobID"].Value);
                using(sunilGarageDBEntities db=new sunilGarageDBEntities())
                {
                    jb = db.jobs.Where(x => x.jobID == jb.jobID).FirstOrDefault();
                    setJobDetails(jb);
                    setItemList(jb);
                }
            }
        }

        //fill job item list
        private void setItemList(job j)
        {
            jobItem[] jobItemList = j.jobItems.ToArray();   
            List<usedItemStruct> usedList = new List<usedItemStruct>();

            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                foreach (jobItem x in jobItemList)
                {
                    string itemName = db.items.Where(p => p.itemID == x.itemID).FirstOrDefault().name;
                    usedList.Add(new usedItemStruct { itemID = x.itemID, itemName = itemName, unitCost = Convert.ToInt32(x.unitCost), usedQuantity = Convert.ToInt32(x.usedQuantity), totalCost = Convert.ToInt32(x.totalCost) });
                    
                }
                dgvItemList.DataSource = usedList;
            }
            
        }

        //close
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            if (previousPage != null)
            {
                previousPage.Show();
            }
            else if (previousPageAdmin != null)
            {
                previousPageAdmin.Show();
            }
        }

        
    }
}

  