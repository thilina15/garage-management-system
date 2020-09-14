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
        
        public adminPage()
        {
            

            InitializeComponent();

        }

        private void adminPage_Load(object sender, EventArgs e)
        {
           // DB.ConnectDB();
            
            //set inventory grid font details
            dgvInventory.DefaultCellStyle.Font = new Font("Tahoma", 15);

            //set customer grid font details
            dgvCustomerReg.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvCustomerReg.ColumnHeadersDefaultCellStyle.Font = new Font("Thoma", 15);

            //load customers to reg table
            fillCustomerReg();
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
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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


        //customer registration................................................................

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

        // customer NIC select comboBox selection changed..................
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

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

   
}
