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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видыСортировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шейкернаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.treeSortToolStripMenuItem,
            this.selectionSortToolStripMenuItem});
            this.видыСортировокToolStripMenuItem.Name = "видыСортировокToolStripMenuItem";
            this.видыСортировокToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.видыСортировокToolStripMenuItem.Text = "Виды сортировок";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.bubbleSortToolStripMenuItem.Text = "Пузырьковая сортировка";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.BubbleSortToolStripMenuItem_Click);
            // 
            // шейкернаяСортировкаToolStripMenuItem
            // 
            this.шейкернаяСортировкаToolStripMenuItem.Name = "шейкернаяСортировкаToolStripMenuItem";
            this.шейкернаяСортировкаToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.шейкернаяСортировкаToolStripMenuItem.Text = "Шейкерная сортировка";
            this.шейкернаяСортировкаToolStripMenuItem.Click += new System.EventHandler(this.ШейкернаяСортировкаToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.insertionSortToolStripMenuItem.Text = "Сортировка вставками";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.InsertionSortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.shellSortToolStripMenuItem.Text = "Сортировка Шелла";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.ShellSortToolStripMenuItem_Click);
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(348, 173);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Количество замен при использовании алгоритмов";
            this.chart1.Titles.Add(title1);
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
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(378, 335);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 164);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Показывать на графике";
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            this.selectionSortToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.selectionSortToolStripMenuItem.Text = "Сортировка выбором";
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.SelectionSortToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Пузырьковая сортировка";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(145, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Шейкерная сортировка";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Сортировка вставками";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(122, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Сортировка Шелла";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(135, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Сортировка выбором";
            this.checkBox5.UseVisualStyleBackColor = true;
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
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionSortToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}