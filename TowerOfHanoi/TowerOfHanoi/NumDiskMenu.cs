using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class NumDiskMenu : Form
    {
        public NumDiskMenu()
        {
            InitializeComponent();
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(numDisksTextBox.Text);

            if (num > 8 || num < 1)
            {
                MessageBox.Show("Must be greater than or equal to 1 and less than or equal to 8");
                numDisksTextBox.Text = "";
            }

            else
            {
                mainWindow mw = new mainWindow(num);
                mw.ShowDialog();
            }
        }
    }
}
