using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var buubleSortForm = new BuubleSortForm();
            buubleSortForm.ShowDialog();
        }
    }
}
