using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExAssignment
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuInputData_Click(object sender, EventArgs e)
        {
            fCalcu f = new fCalcu();
            f.MdiParent = this;
            f.Show();
        }

        
        
    }
}
