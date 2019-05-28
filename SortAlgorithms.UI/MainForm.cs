using SortAlgorithms.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortAlgorithms.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // Принудительное переключение на en-US.
            //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            //System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            InitializeComponent();
        }

        #region Открытие определенных видов сортировки

        private void OpenNewForm(int param)
        {
            var buubleSortForm = new BuubleSortForm(richTextBox1.Text, param);
            buubleSortForm.ShowDialog();
        }

        private void BubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(1);
        }

        private void ШейкернаяСортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(2);
        }

        private void InsertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(3);
        }

        private void ShellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(4);
        }

        private void HeapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(5);
        }

        private void TreeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(6);
        }

        private void SelectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(7);
        }

        private void GnomeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(8);
        }

        private void MergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(9);
        }

        private void QuickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNewForm(10);
        }

        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            chart1.Series.Clear();

            button3.Enabled = false;
            button1.Enabled = true;
            button4.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;

                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                    }
                }

                if(fileContent != null && fileContent != "")
                {
                    richTextBox1.Text = fileContent;
                    MessageBox.Show("File successfully read!", "Operation result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = false;
                    button4.Enabled = false;
                    button3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The selected file is empty!", "Operation result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var list = new List<int>();
            var countItems = rnd.Next(0, 500);
            
            for(int i = 0; i < countItems; i++)
            {
                list.Add(rnd.Next(0,10000));
            }

            foreach(var l in list)
            {
                richTextBox1.Text += l.ToString() + " ";
            }

            button1.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = true;
        }

        private void richTextBoxParser(List<int> Items)
        {
            string[] words = richTextBox1.Text.Split(' ');
            foreach (var w in words)
            {
                if (int.TryParse(w, out int value))
                {
                    Items.Add(Convert.ToInt32(value));
                }
            }
        }
        private void AnalysisAlgorithm(AlgorithmsBase<int> algorithmsBase, List<int> Items, List<TimeSpan> timeSpan, List<int> swapCount)
        {
            algorithmsBase.Items.AddRange(Items);
            timeSpan.Add(algorithmsBase.Sort());
            swapCount.Add(algorithmsBase.SwapCount);
            algorithmsBase.Items.Clear();
        }
        private void chartDefaultSettings(int AxisXMax, int AxisYMax)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = AxisXMax;
            chart1.ChartAreas[0].AxisY.Minimum = 0; 
            chart1.ChartAreas[0].AxisY.Maximum = AxisYMax;
        }
        private void richTextBoxFill(string algorithmName, TimeSpan timeSpan, int swapCount)
        {
            richTextBox2.Text += algorithmName + "\n";
            richTextBox2.Text += $"Time: {timeSpan} \n";
            richTextBox2.Text += $"Number of replacements: {swapCount} \n";
            richTextBox2.Text += $"\n";
        }

        private void checkBoxCheckedAll(ref int countSeries, string[] seriesArray, int[] pointsArray, List<int> swapCount)
        {
            if (checkBox1.Checked)
            {
                seriesArray[0] = Constants.BubbleSort;
                pointsArray[0] = swapCount[0];
                countSeries++;
            }

            if (checkBox2.Checked)
            {
                seriesArray[1] = Constants.CoctailSort;
                pointsArray[1] = swapCount[1];
                countSeries++;
            }

            if (checkBox3.Checked)
            {
                seriesArray[2] = Constants.InsertionSort;
                pointsArray[2] = swapCount[2];
                countSeries++;
            }

            if (checkBox4.Checked)
            {
                seriesArray[3] = Constants.ShellSort;
                pointsArray[3] = swapCount[3];
                countSeries++;
            }

            if (checkBox5.Checked)
            {
                seriesArray[4] = Constants.SelectionSort;
                pointsArray[4] = swapCount[6];
                countSeries++;
            }

            if (checkBox6.Checked)
            {
                seriesArray[5] = Constants.GnomeSort;
                pointsArray[5] = swapCount[7];
                countSeries++;
            }

            if (checkBox7.Checked)
            {
                seriesArray[6] = Constants.MergeSort;
                pointsArray[6] = swapCount[8];
                countSeries++;
            }

            if (checkBox8.Checked)
            {
                seriesArray[7] = Constants.QuickSort;
                pointsArray[7] = swapCount[9];
                countSeries++;
            }
        }

        private async void Button3_Click(object sender, EventArgs e)
        { 
            AlgorithmsBase<int> algorithmsBase = null;
            var Items = new List<int>();
            var timeSpan = new List<TimeSpan>();
            var swapCount = new List<int>();

            richTextBoxParser(Items);

            #region Методы для вычисления сортировок.

            algorithmsBase = new BubbleSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.BubbleSort, timeSpan[0], swapCount[0]);
            }
            ));

            algorithmsBase = new CoctailSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.CoctailSort, timeSpan[1], swapCount[1]);
            }
            ));

            algorithmsBase = new InsertSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.InsertionSort, timeSpan[2], swapCount[2]);
            }
            ));

            algorithmsBase = new ShellSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.ShellSort, timeSpan[3], swapCount[3]);
            }
            ));

            algorithmsBase = new HeapSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.HeapSort, timeSpan[4], swapCount[4]);
            }
            ));

            algorithmsBase = new TreeSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.TreeSort, timeSpan[5], swapCount[5]);
            }
            ));

            algorithmsBase = new SelectionSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.SelectionSort, timeSpan[6], swapCount[6]);
            }
            ));

            algorithmsBase = new GnomeSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.GnomeSort, timeSpan[7], swapCount[7]);
            }
            ));

            algorithmsBase = new MergeSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.MergeSort, timeSpan[8], swapCount[8]);
            }
            ));

            algorithmsBase = new QuickSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill(Constants.QuickSort, timeSpan[9], swapCount[9]);
            }
            ));

            #endregion

            button3.Enabled = false;  

            string[] seriesArray = new string[10]; 
            int[] pointsArray = new int[10]; 

            chart1.Series.Clear();
            var countSeries = 0;
            checkBoxCheckedAll(ref countSeries, seriesArray, pointsArray, swapCount);
            chartDefaultSettings(countSeries, pointsArray.Max());

            for (int i = 0; i < seriesArray.Length; i++)
            {
                if (seriesArray[i] != null)
                {
                    Series series = chart1.Series.Add(seriesArray[i]);
                    series.Points.Add(pointsArray[i]);
                }
            }    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "App моё";
        }
    }
}
