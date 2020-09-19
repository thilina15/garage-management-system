using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstApp
{
    public partial class jobDetailsForAdmin : Form
    {
        job jobRef;
        bool completed;
        public jobDetailsForAdmin(job j)
        {
            jobRef = j;
            completed = false;
            InitializeComponent();
            fillTextFields();
            setTotalCost();
        }

        //fill text fields
        private void fillTextFields()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                //job details
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                txtDescription.Text = jobRef.description;
                txtID.Text = jobRef.jobID.ToString();
                numItemCost.Value =Convert.ToInt32(jobRef.itemsCost);
                txtSpecialNote.Text = jobRef.specialNote;
                txtState.Text = jobRef.status;
                txtVehicle.Text = jobRef.vehicle;
                numServiceCost.Value=Convert.ToInt32(jobRef.serviceCost);

                //customer details
                customer c = db.customers.Where(x => x.customerNIC == jobRef.customerNIC).FirstOrDefault();
                lblCustomerAddress.Text = c.address;
                lblCustomerEmail.Text = c.email;
                lblCustomerMobile.Text = c.mobile.ToString();
                lblCustomerName.Text = c.name;
                

                //set the state of job
                if (jobRef.status == state.complete.ToString())
                {
                    completed = true;
                }
                else
                {
                    completed = false;
                }
                
            }
        }

        //calculating total cost
        private void setTotalCost()
        {
            int x = Convert.ToInt32(numItemCost.Value) + Convert.ToInt32(numServiceCost.Value);
            lblTotal.Text = x.ToString();
        }

        //close
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //on service cost changed
        private void numServiceCost_ValueChanged(object sender, EventArgs e)
        {
            setTotalCost();
        }


        private void numServiceCost_KeyUp(object sender, KeyEventArgs e)
        {
            setTotalCost();
        }


        //click complete job
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            jobRef.date = Date.Value;
            jobRef.description = txtDescription.Text;
            jobRef.specialNote = txtSpecialNote.Text;
            jobRef.serviceCost=Convert.ToInt32(numServiceCost.Value);
            jobRef.status = state.complete.ToString();
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                db.Entry(jobRef).State = EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("job completed successfully");
            fillTextFields();
        }

        //invoice click
        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            if (completed)
            {
                //do the invoice part
            }
            else
            {
                MessageBox.Show("please complete the job before get invoice");
            }
        }

        //show customer history page
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            jobHistory jh = new jobHistory(false, jobRef, this);
            jh.Show();
            this.Hide();
        }

        //show vehicle history page
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            jobHistory jh = new jobHistory(true, jobRef, this);
            jh.Show();
            this.Hide();
        }
    }
}
