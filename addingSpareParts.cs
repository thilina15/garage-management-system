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
        public addingSpareParts()
        {
            
            InitializeComponent();
            fillItemComboBox();



        }

        public addingSpareParts(job job)
        {
            jobRef = job;
            fillItemComboBox();
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
                        comboBoxItemName.Items.Add(x.name.ToString());
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //add item to list
        private void button4_Click(object sender, EventArgs e)
        {
            string selectedName = comboBoxItemName.SelectedItem.ToString();
            jobItem JIRecord = new jobItem();
            item inventoryItem = new item();
            JIRecord.jobID = 4;
            JIRecord.usedQuantity = Convert.ToInt32(txtUsedQuantity.Text);
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                //try
                {
                    inventoryItem = db.items.Where(x => x.name == selectedName).FirstOrDefault();
                    JIRecord.itemID = inventoryItem.itemID;
                    JIRecord.unitCost = inventoryItem.price;
                    JIRecord.totalCost = JIRecord.unitCost * JIRecord.usedQuantity;


                    MessageBox.Show(JIRecord.jobID + " " + JIRecord.itemID + " " + JIRecord.usedQuantity + " " + JIRecord.unitCost + " " + JIRecord.totalCost);
                    //db.jobItems.Add(JIRecord);
                   // db.SaveChanges();
                    //fillItemComboBox();
                }
               // catch(Exception ex)
                {
               //     MessageBox.Show(ex.Message);
                }
            }

        }

        //fill item list....
        private void fillItemList()
        {
            using(sunilGarageDBEntities db=new sunilGarageDBEntities())
            {
                //listBoxItems.Items.Clear();
               // listBoxItems.DataSource = db.jobItems.Where(x => x.jobID ==4).ToList();
                //jobItem[] jobItems = db.jobItems.Where(x => x.jobID == jobRef.jobID).ToArray<jobItem>;
                dgvItemList.Rows.Add(67, "asd0",78,78,90);
            }
        }
    }
}
