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
using MySql.Data.MySqlClient;

namespace myFirstApp
{
    public partial class adminPage : Form
    {
        startPage stPage;
        
        public adminPage(startPage st )
        {
            stPage = st;
            InitializeComponent();
            checkInventoryWarnings();
            fillJobSearchComboBox();
            timer1.Start();

        }

        private void adminPage_Load(object sender, EventArgs e)
        {
           
            
            //set inventory grid font details
            dgvInventory.DefaultCellStyle.Font = new Font("Tahoma", 15);

            //set customer grid font details
            dgvCustomerReg.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCustomerReg.ColumnHeadersDefaultCellStyle.Font = new Font("Thoma", 15);

            //load customers to reg table
            fillCustomerReg();

            //fill ongoing repairs
            fillOngoingRepairs();

            //set ongoing repairs grid fonts
            bunifu_DGV_ongoingRepairs.DefaultCellStyle.Font = new Font("Thoma", 10);
            bunifu_DGV_ongoingRepairs.ColumnHeadersHeight = 50;

            //inventory warning table
            dgvInventoryWarnings.DefaultCellStyle.Font = new Font("Thoma", 10);

            //user table
            dgvUser.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvUser.ColumnHeadersDefaultCellStyle.Font = new Font("Thoma", 15);

        }

        //check inventory warnings
        private void checkInventoryWarnings()
        {
            dgvInventoryWarnings.AutoGenerateColumns = false;
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                item[] warnings = db.items.Where(x => x.stock < x.minStock).ToArray();
                dgvInventoryWarnings.DataSource = warnings;

            }
        }
        
        private void tabPage3_Click(object sender, EventArgs e)
        {

            
        }


        //when tab changed.........
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillInventory();
            fillCustomerComboBox();
            fillNextJobID();
            fillOngoingRepairs();
            fillNextUserID();
            fillUserTable();
            fillJobSearchComboBox();
        }


        



        //inventory.................................................................................................
        private void fillInventory()//fill the inventory data grid view
        {
            dgvInventory.AutoGenerateColumns = false;
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                dgvInventory.DataSource = db.items.ToList<item>();
            }
            
            
        }

        private void additem()//add a new inventory item
        {


            item inventory = new item();
            using(sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                try
                {
                    inventory.name = txtItemName_Inventory.Text;
                    inventory.minStock = Convert.ToInt32(txtMinQuantity_Inventory.Text);
                    inventory.price = Convert.ToInt32(txtUnitPrice_Inventory.Text);
                    inventory.stock = Convert.ToInt32(txtAvalableQuantity_Inventory.Text);
                    db.items.Add(inventory);
                    db.SaveChanges();
                    MessageBox.Show("new inventory item added");
                    fillInventory();
                    clearInventoryField();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }



            

        }

        private void clearInventoryField()
        {
            txtItemID_Inventory.Text = txtAvalableQuantity_Inventory.Text =txtItemName_Inventory.Text=txtMinQuantity_Inventory.Text=txtUnitPrice_Inventory.Text = null;
            
        }

        //add button inventory
        private void button2_Click(object sender, EventArgs e)
        {
            additem();
            fillInventory();
        }

        //inventory double click
        private void dgvInventory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow.Index != -1)
            {
                item inventory = new item();
                inventory.itemID = Convert.ToInt32(dgvInventory.CurrentRow.Cells["itemID"].Value);
                using(sunilGarageDBEntities db=new sunilGarageDBEntities())
                {
                    inventory = db.items.Where(x => x.itemID == inventory.itemID).FirstOrDefault();
                    txtAvalableQuantity_Inventory.Text = inventory.stock.ToString();
                    txtItemName_Inventory.Text = inventory.name;
                    txtMinQuantity_Inventory.Text = inventory.minStock.ToString();
                    txtUnitPrice_Inventory.Text = inventory.price.ToString();
                    txtItemID_Inventory.Text = inventory.itemID.ToString();
                }
            }
        }

        //update inventory
        private void button8_Click(object sender, EventArgs e)
        {
            item inventory = new item();
            try
            {
                inventory.name = txtItemName_Inventory.Text;
                inventory.minStock = Convert.ToInt32(txtMinQuantity_Inventory.Text);
                inventory.price = Convert.ToInt32(txtUnitPrice_Inventory.Text);
                inventory.stock = Convert.ToInt32(txtAvalableQuantity_Inventory.Text);
                inventory.itemID = Convert.ToInt32(txtItemID_Inventory.Text);

                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    db.Entry(inventory).State = EntityState.Modified;
                    db.SaveChanges();
                    fillInventory();
                    clearInventoryField();
                }
                MessageBox.Show("inventory item updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }

        //delete from inventory
        private void button7_Click(object sender, EventArgs e)
        {
            item inventory = new item();
            try
            {
                inventory.name = txtItemName_Inventory.Text;
                inventory.minStock = Convert.ToInt32(txtMinQuantity_Inventory.Text);
                inventory.price = Convert.ToInt32(txtUnitPrice_Inventory.Text);
                inventory.stock = Convert.ToInt32(txtAvalableQuantity_Inventory.Text);
                inventory.itemID = Convert.ToInt32(txtItemID_Inventory.Text);

                if(MessageBox.Show("are you sure you want to delete this item?","delete inventory item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                    {
                        db.Entry(inventory).State = EntityState.Modified;
                        var entry = db.Entry(inventory);
                        if (entry.State == EntityState.Detached)
                            db.items.Attach(inventory);
                        db.items.Remove(inventory);
                        db.SaveChanges();
                        fillInventory();
                        clearInventoryField();
                    }
                    MessageBox.Show("inventory item deleted");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //customer registration...........................................................................................................................

        //add customer
        private void button12_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            using (sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                try
                {
                    cus.customerNIC = txtCustomerID_people.Text;
                    cus.name = txtCustomerName_People.Text;
                    cus.mobile = Convert.ToInt32(txtcustomerMobile_People.Text);
                    cus.address = txtCustomerAddress_People.Text;
                    cus.email = txtCustomerEmail_People.Text;

                    db.customers.Add(cus);
                    db.SaveChanges();
                    clearCustomerFields();
                    fillCustomerReg();
                    MessageBox.Show("customer added");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        //clear customer registration fields
        private void clearCustomerFields()
        {
            txtcustomerMobile_People.Text = txtCustomerAddress_People.Text = txtCustomerEmail_People.Text = txtCustomerID_people.Text = txtCustomerName_People.Text = null;
        }

        //fill customer registration table
        private void fillCustomerReg()
        {
            dgvCustomerReg.AutoGenerateColumns = false;
            using (sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                dgvCustomerReg.DataSource = db.customers.ToList<customer>();
            }
        }

        //customer reg double click
        private void dgvCustomerReg_DoubleClick(object sender, EventArgs e)
        {
            customer cus = new customer();
            if (dgvCustomerReg.CurrentRow.Index != -1)
            {
                cus.customerNIC = dgvCustomerReg.CurrentRow.Cells["customerID"].Value.ToString();
                using(sunilGarageDBEntities db=new sunilGarageDBEntities())
                {
                    cus = db.customers.Where(x => x.customerNIC == cus.customerNIC).FirstOrDefault();
                    txtcustomerMobile_People.Text = cus.mobile.ToString();
                    txtCustomerAddress_People.Text = cus.address.ToString();
                    txtCustomerEmail_People.Text = cus.email.ToString();
                    txtCustomerID_people.Text = cus.customerNIC.ToString();
                    txtCustomerName_People.Text = cus.name.ToString();
                }

            }


        }


        //job sheet................................................................................................................................................................................

        //fill customer NIC combo box
        private void fillCustomerComboBox()
        {
            using (sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                comboBoxCusNIC.Items.Clear();
                customer[] cus = db.customers.ToArray();
                foreach (customer x in cus)
                {
                    comboBoxCusNIC.Items.Add(x.customerNIC.ToString());
                }

            }
        }

        // customer NIC select comboBox selection changed
        private void comboBoxCusNIC_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer cus = new customer();
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                cus = db.customers.Where(x => x.customerNIC == comboBoxCusNIC.SelectedItem.ToString()).FirstOrDefault();
                lblCustomerEmail.Text = cus.email;
                lblCustomerMobile.Text = cus.mobile.ToString();
                lblCustomerName.Text = cus.name;
                lblCustomerAddress.Text = cus.address;
            }
        }

        //making job object.............
        private void makeJob()
        {
            job jb = new job();
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
               try
                {
                    jb.customerNIC = comboBoxCusNIC.SelectedItem.ToString();
                    jb.jobID = Convert.ToInt32(txtJobID_JobSheet.Text);
                    jb.description = txt_JobDescription_JobSheet.Text;
                    jb.vehicle = MTB_VehicleID_JobSheet.Text;
                    jb.status = state.created.ToString();
                    jb.customer = db.customers.Where(x => x.customerNIC == comboBoxCusNIC.SelectedItem.ToString()).FirstOrDefault();
                    jb.specialNote = "";
                    jb.date = null;
                    jb.serviceCost = 0;

                    db.jobs.Add(jb);
                    db.SaveChanges();
                    MessageBox.Show("job creater succesfully.. JobID is:"+jb.jobID);
                    fillNextJobID();

                    //clear the job sheet
                    txt_JobDescription_JobSheet.Text = null;
                    comboBoxCusNIC.Text = "";
                    MTB_VehicleID_JobSheet.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //fill create job field with new jobID
        private void fillNextJobID()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                int jobID = db.jobs.Max(p => p.jobID)+1;
                txtJobID_JobSheet.Text = jobID.ToString();
            }
        }

        //make job sheet
        private void button3_Click(object sender, EventArgs e)
        {
            makeJob();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        //fill ongoing repairs.................
        private void fillOngoingRepairs()
        {
            bunifu_DGV_ongoingRepairs.AutoGenerateColumns = false;
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                bunifu_DGV_ongoingRepairs.DataSource = db.jobs.Where(x => x.status != state.complete.ToString()).ToList<job>();
            }
        }

        //ongoing repairs double click
        private void bunifu_DGV_ongoingRepairs_DoubleClick(object sender, EventArgs e)
        {
            if (bunifu_DGV_ongoingRepairs.CurrentRow.Index != -1)
            {
                job jb = new job();
                jb.jobID = Convert.ToInt32(bunifu_DGV_ongoingRepairs.CurrentRow.Cells["jobID"].Value);
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    jb = db.jobs.Where(x => x.jobID == jb.jobID).FirstOrDefault();
                    jobDetailsForAdmin jdfa = new jobDetailsForAdmin(jb);
                    jdfa.Show();
                }
            }
        }

        //fill job search combo box
        private void fillJobSearchComboBox()
        {
            using (sunilGarageDBEntities db = new sunilGarageDBEntities())
            {
                comboBoxJobs.Items.Clear();
                //get only completed jobs
                job[] jb = db.jobs.Where(x=>x.status==state.complete.ToString()).ToArray();
                List<string> vehicleList = new List<string>();
                foreach (job x in jb)
                {
                    vehicleList.Add(x.vehicle);
                }

                //removing duplicates (completed vehicle list)
                List<string> finalList = vehicleList.Distinct().ToList();

                //adding to combo box
                foreach(string x in finalList)
                {
                    comboBoxJobs.Items.Add(x);
                }

            }
        }


     

        //search job by vehicle button
        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            string vehicleID = comboBoxJobs.SelectedItem.ToString();
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                job j = db.jobs.Where(x => x.vehicle == vehicleID && x.status == state.complete.ToString()).FirstOrDefault();
                jobHistory jh = new jobHistory(true, j);
                jh.Show();
            }

        }

        // user registration details.........................................................................................................................................
        //user add button
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                string name = txtUserName.Text;
                string password = txtUserPassword.Text;
                bool admin = radioAdmin.Checked;

                user u = new user();
                u.isAdmin = admin;
                u.name = name;
                u.password = password;
                db.users.Add(u);
                db.SaveChanges();
                MessageBox.Show("user added done");
                clearUserTextFields();
            }
            
        }

        //fill next user id
        private void fillNextUserID()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                int nextID = db.users.Max(x => x.ID) + 1;
                txtUserID.Text = nextID.ToString();
            }
        }

        //clear user text fields
        private void clearUserTextFields()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            fillNextUserID();
            fillUserTable();
        }

        //fill user data table
        private void fillUserTable()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                user[] userList = db.users.ToArray();
                dgvUser.DataSource = userList;
            }
        }

        //user table row click
        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            user u = new user();
            if (dgvUser.CurrentRow.Index != -1)
            {

                u.ID = Convert.ToInt32(dgvUser.CurrentRow.Cells["userID"].Value);
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    u = db.users.Where(x => x.ID == u.ID).FirstOrDefault();
                    txtUserID.Text = u.ID.ToString();
                    txtUserName.Text = u.name;
                    txtUserPassword.Text = u.password;
                    if (u.isAdmin)
                    {
                        radioAdmin.Checked = true;
                    }
                    else
                    {
                        radioMechanic.Checked = true;
                    }
                }

            }
        }

        //user edit (save)
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            user u = new user();
            u.ID = Convert.ToInt32(txtUserID.Text);
            u.name = txtUserName.Text;
            u.password = txtUserPassword.Text;
            u.isAdmin = radioAdmin.Checked;

            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                try
                {
                    db.Entry(u).State = EntityState.Modified;
                    db.SaveChanges();
                    fillUserTable();
                    clearUserTextFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //delete user..
        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            user u = new user();
            try
            {
                u.ID = Convert.ToInt32(txtUserID.Text);
                u.name = txtUserName.Text;
                u.password = txtUserPassword.Text;
                u.isAdmin = radioAdmin.Checked;

                


                if (MessageBox.Show("are you sure you want to delete this user?", "delete user", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                    {
                        db.Entry(u).State = EntityState.Modified;
                        var entry = db.Entry(u);
                        if (entry.State == EntityState.Detached)
                            db.users.Attach(u);
                        db.users.Remove(u);
                        db.SaveChanges();
                        fillUserTable();
                        fillNextUserID();
                        clearUserTextFields();
                    }
                    MessageBox.Show("user deleted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //log out
        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            this.Close();
            stPage.Show();
        }

        //exit button
        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        //refresh events with timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            fillOngoingRepairs();
            checkInventoryWarnings();
            
        }

        //generate Report
        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            report r = new report();
            r.Show();
            
        }

        
    }

   
}
