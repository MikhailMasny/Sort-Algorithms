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

        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            chart1.Series.Clear();

            button3.Enabled = false;
            button1.Enabled = true;
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
                    MessageBox.Show("Файл успешно считан!", "Результат операции", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    button1.Enabled = false;
                    button3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Выбранный файл пуст!", "Результат операции", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        // TODO: Рефракторинг + в публичный
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
            richTextBox2.Text += $"Время: {timeSpan} \n";
            richTextBox2.Text += $"Количество замен: {swapCount} \n";
            richTextBox2.Text += $"\n";
        }

        private async void Button3_Click(object sender, EventArgs e)
        { 
            AlgorithmsBase<int> algorithmsBase = null;
            List<int> Items = new List<int>();
            List<TimeSpan> timeSpan = new List<TimeSpan>();
            List<int> swapCount = new List<int>();

            richTextBoxParser(Items);

            algorithmsBase = new BubbleSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Bubble sort", timeSpan[0], swapCount[0]);
            }
            ));

            algorithmsBase = new CoctailSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Coctail sort", timeSpan[1], swapCount[1]);
            }
            ));

            algorithmsBase = new InsertSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Insert sort", timeSpan[2], swapCount[2]);
            }
            ));

            algorithmsBase = new ShellSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Shell sort", timeSpan[3], swapCount[3]);
            }
            ));

            // TODO: Добавить swapCount для Heap и Tree сортировок.
            algorithmsBase = new HeapSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Heap sort", timeSpan[4], swapCount[4]);
            }
            ));

            algorithmsBase = new TreeSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Tree sort", timeSpan[5], swapCount[5]);
            }
            ));

            algorithmsBase = new SelectionSort<int>();
            await Task.Run(() => AnalysisAlgorithm(algorithmsBase, Items, timeSpan, swapCount));
            await Task.Run(() => richTextBox2.Invoke((Action)delegate
            {
                richTextBoxFill("Selection sort", timeSpan[6], swapCount[6]);
            }
            ));

            button3.Enabled = false;

            chartDefaultSettings(swapCount.Count, swapCount.Max());

            string[] seriesArray = { "Bubble", "Coctail", "Insert", "Shell", "Heap", "Tree", "Selection" }; // TODO: список алгоритмов
            int[] pointsArray = { swapCount[0], swapCount[1], swapCount[2], swapCount[3], swapCount[4], swapCount[5], swapCount[6] }; // TODO: значения от сортировок

            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
