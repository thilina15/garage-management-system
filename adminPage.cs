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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
            comboBox1.Items.Add("thilinasd");
        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("hellow");
        }
    }
}
