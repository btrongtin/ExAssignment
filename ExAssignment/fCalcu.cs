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
    public partial class fCalcu : Form
    {
        public fCalcu()
        {
            InitializeComponent();
            loadN();
        }

        void loadN()
        {
            for (int i=100; i<=1000; i=i+100)
            {
                cbInput.Items.Add(i);
            }
        }

        bool checkSNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
            for (int i = 1; i <= (int)cbInput.SelectedItem; i++)
            {
                if(checkSNT(i))
                    lstResult.Items.Add(i);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int row = lstResult.SelectedIndex;
            if(row != -1)
                lstResult.Items.RemoveAt(row);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }
    }
}
