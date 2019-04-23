﻿using SortAlgorithms.BL;
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
    public partial class BuubleSortForm : Form
    {
        AlgorithmsBase<int> algorithmsBase = new BubbleSort<int>();

        public BuubleSortForm(string rText)
        {
            InitializeComponent();
            richTextBox1.Text = rText;         
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
                richTextBox1.Enabled = false;
                algorithmsBase.Sort();

                foreach (var item in algorithmsBase.Items)
                {
                    richTextBox1.Text += item + " ";
                }

                button1.Enabled = false;
            }  
            else
            {
                MessageBox.Show("Список для сортировки пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox1.Clear();
            algorithmsBase.Items.Clear();
        }
    }
}
