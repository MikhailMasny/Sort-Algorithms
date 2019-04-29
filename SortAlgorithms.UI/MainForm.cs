using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        #endregion

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            chart1.Series.Clear();

            button2.Enabled = true;
            button3.Enabled = false;
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

        private void Button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

            // TODO: Добавить асинхронность каждого метода сортировки

            // TODO: Реализовать через Dictionary
            string[] seriesArray = { "Bubble", "Coctail", "Insert" }; // TODO: список алгоритмов
            int[] pointsArray = { 1, 2, 3 }; // TODO: значения от сортировок

            chart1.Palette = ChartColorPalette.SeaGreen;

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
