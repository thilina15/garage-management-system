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
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            jobDetails jb = new jobDetails();
            MessageBox.Show("clidked");
            jb.Show();
        }
    }
}
