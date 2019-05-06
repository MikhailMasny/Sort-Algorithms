namespace SortAlgorithms.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видыСортировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шейкернаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видыСортировокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // видыСортировокToolStripMenuItem
            // 
            this.видыСортировокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.шейкернаяСортировкаToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.treeSortToolStripMenuItem});
            this.видыСортировокToolStripMenuItem.Name = "видыСортировокToolStripMenuItem";
            this.видыСортировокToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.видыСортировокToolStripMenuItem.Text = "Виды сортировок";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.bubbleSortToolStripMenuItem.Text = "Пузырьковая сортировка";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.BubbleSortToolStripMenuItem_Click);
            // 
            // шейкернаяСортировкаToolStripMenuItem
            // 
            this.шейкернаяСортировкаToolStripMenuItem.Name = "шейкернаяСортировкаToolStripMenuItem";
            this.шейкернаяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.шейкернаяСортировкаToolStripMenuItem.Text = "Шейкерная сортировка";
            this.шейкернаяСортировкаToolStripMenuItem.Click += new System.EventHandler(this.ШейкернаяСортировкаToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.insertionSortToolStripMenuItem.Text = "Сортировка вставками";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.InsertionSortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.shellSortToolStripMenuItem.Text = "Сортировка Шелла";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.ShellSortToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(348, 168);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить данные с файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(348, 173);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Количество замен при использовании алгоритмов";
            this.chart1.Titles.Add(title5);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(348, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Запустить все ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(152, 277);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 222);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(378, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о работе";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(12, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 244);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "График";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart2);
            this.groupBox4.Location = new System.Drawing.Point(378, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 164);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Диаграмма";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(6, 19);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(152, 139);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Время работы";
            this.chart2.Titles.Add(title6);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.heapSortToolStripMenuItem.Text = "Сортировка кучей";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.HeapSortToolStripMenuItem_Click);
            // 
            // treeSortToolStripMenuItem
            // 
            this.treeSortToolStripMenuItem.Name = "treeSortToolStripMenuItem";
            this.treeSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.treeSortToolStripMenuItem.Text = "Сортировка бинарным деревом";
            this.treeSortToolStripMenuItem.Click += new System.EventHandler(this.TreeSortToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видыСортировокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem шейкернаяСортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeSortToolStripMenuItem;
    }
}