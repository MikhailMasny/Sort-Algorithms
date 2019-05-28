using SortAlgorithms.BL;
using System;
using System.Windows.Forms;

namespace SortAlgorithms.UI
{
    public partial class BuubleSortForm : Form
    {
        AlgorithmsBase<int> algorithmsBase;

        public BuubleSortForm(string rText, int param)
        {
            InitializeComponent();
            richTextBox1.Text = rText;  
            
            switch(param)
            {
                case 1:
                    {
                        algorithmsBase = new BubbleSort<int>();
                        this.Text = Constants.BubbleSort;
                    }
                    break;

                case 2:
                    {
                        algorithmsBase = new CoctailSort<int>();
                        this.Text = Constants.CoctailSort;
                    }
                    break;

                case 3:
                    {
                        algorithmsBase = new InsertSort<int>();
                        this.Text = Constants.InsertionSort;
                    }
                    break;

                case 4:
                    {
                        algorithmsBase = new ShellSort<int>();
                        this.Text = Constants.ShellSort;
                    }
                    break;

                case 5:
                    {
                        algorithmsBase = new HeapSort<int>();
                        this.Text = Constants.HeapSort;
                    }
                    break;

                case 6:
                    {
                        algorithmsBase = new TreeSort<int>();
                        this.Text = Constants.TreeSort;
                    }
                    break;

                case 7:
                    {
                        algorithmsBase = new SelectionSort<int>();
                        this.Text = Constants.SelectionSort;
                    }
                    break;

                case 8:
                    {
                        algorithmsBase = new GnomeSort<int>();
                        this.Text = Constants.GnomeSort;
                    }
                    break;

                case 9:
                    {
                        algorithmsBase = new MergeSort<int>();
                        this.Text = Constants.MergeSort;
                    }
                    break;

                case 10:
                    {
                        algorithmsBase = new QuickSort<int>();
                        this.Text = Constants.QuickSort;
                    }
                    break;

                default: { } break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] words = richTextBox1.Text.Split(' ');
            foreach(var w in words)
            {
                if(int.TryParse(w, out int value))
                algorithmsBase.Items.Add(Convert.ToInt32(value));
            }

            if(algorithmsBase.Items.Count != 0)
            {
                richTextBox1.Clear();
                richTextBox1.ReadOnly = true;
                var timeSpan = algorithmsBase.Sort();

                foreach (var item in algorithmsBase.Items)
                {
                    richTextBox1.Text += item + " ";
                }

                button1.Enabled = false;

                MessageBox.Show($"Swap count: {algorithmsBase.SwapCount}, Time: {timeSpan}", "Result of sorting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            else
            {
                MessageBox.Show("List to sort is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            richTextBox1.ReadOnly = false;
            richTextBox1.Clear();
            algorithmsBase.Items.Clear();
        }
    }
}
