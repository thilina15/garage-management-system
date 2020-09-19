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
    public partial class addingSpareParts : Form
    {
        job jobRef = new job();
        string selectedString;
        public addingSpareParts()
        {
            
            InitializeComponent();
            


        }

        public addingSpareParts(job job)
        {
            InitializeComponent();
            jobRef = job;
            fillItemComboBox();
            fillItemList();
        }

        //fill item combo box
        private void fillItemComboBox()
        {
            comboBoxItemName.Items.Clear();
            try
            {
                using (sunilGarageDBEntities db = new sunilGarageDBEntities())
                {
                    item[] inventoryItem = db.items.ToArray();
                    foreach (item x in inventoryItem)
                    {
                        comboBoxItemName.Items.Add(x.itemID+" || "+x.name.ToString());
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //fill text fields with selected inventory item details
        private void comboBoxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedString= comboBoxItemName.SelectedItem.ToString();
            var spitedWords = selectedString.Split(' ');
            int selectedItemID = Convert.ToInt32(spitedWords.ElementAt(0));

            item selectedItem = new item();
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                txtAvalableQuantity.Text = db.items.Where(x => x.itemID == selectedItemID).FirstOrDefault().stock.ToString();
            }
        }

        //add item to list
        private void button4_Click(object sender, EventArgs e)
        {
            //split selected sentence to words by space
            var spitedWords = selectedString.Split(' ');
            int selectedItemID = Convert.ToInt32(spitedWords.ElementAt(0));
            string selectedItemName = spitedWords.ElementAt(2);

            jobItem JItemRecord = new jobItem();
            item inventoryItem = new item();
            

            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                try
                {
                    //filter out the inventory object according to comboBox selection
                    inventoryItem = db.items.Where(x => x.itemID == selectedItemID).FirstOrDefault();
                    
                    //set jobItem object for submit to job
                    JItemRecord.jobID = jobRef.jobID;
                    int uq= Convert.ToInt32(txtUsedQuantity.Text);
                    JItemRecord.usedQuantity = uq;

                    //check requested quantity are avalable
                    if (uq > inventoryItem.stock)
                    {
                        throw new Exception("the added quantity is not avalable");
                    }
                    JItemRecord.itemID = inventoryItem.itemID;
                    JItemRecord.unitCost = inventoryItem.price;
                    JItemRecord.totalCost = JItemRecord.unitCost * JItemRecord.usedQuantity;

                    //add item to job
                    jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                    jobRef.jobItems.Add(JItemRecord);
                    db.Entry(jobRef).State = System.Data.Entity.EntityState.Modified;

                    //reduce the quantity from inventory
                    item updatedItem = db.items.Where(x => x.itemID == selectedItemID).FirstOrDefault();
                    updatedItem.stock = updatedItem.stock - uq;
                    //db.Entry(updatedItem).State = System.Data.Entity.EntityState.Modified;


                    db.SaveChanges();
                    fillItemList();
                }
               catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //fill item list.... and update total item cost
        private void fillItemList()
        {

            

            
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                var jobItemList = jobRef.jobItems;
                List<usedItemStruct> usedList = new List<usedItemStruct>();
                int total = 0;

                foreach (jobItem x in jobItemList)
                {
                    string itemName = db.items.Where(p => p.itemID == x.itemID).FirstOrDefault().name;
                    usedList.Add(new usedItemStruct { itemID = x.itemID, itemName = itemName, unitCost = Convert.ToInt32(x.unitCost), usedQuantity = Convert.ToInt32(x.usedQuantity), totalCost = Convert.ToInt32(x.totalCost) });
                    total = total + Convert.ToInt32(x.totalCost);
                }
                //update total item cost for job
                jobRef.itemsCost = total;
                db.SaveChanges();
                
                var source = new BindingSource();
                source.DataSource = usedList;
                dgvItemList.DataSource = usedList;
                LBL_totalCost.Text = total.ToString();


                
            }

            
        }

        //save button
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            fillItemList();
        }

        // delete from list
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                jobRef = db.jobs.Where(x => x.jobID == jobRef.jobID).FirstOrDefault();
                MessageBox.Show(jobRef.itemsCost.ToString());
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
