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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.видыСортировокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шейкернаяСортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gnomeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            this.selectionSortToolStripMenuItem,
            this.gnomeSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem,
            this.quickSortToolStripMenuItem});
            this.видыСортировокToolStripMenuItem.Name = "видыСортировокToolStripMenuItem";
            resources.ApplyResources(this.видыСортировокToolStripMenuItem, "видыСортировокToolStripMenuItem");
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            resources.ApplyResources(this.bubbleSortToolStripMenuItem, "bubbleSortToolStripMenuItem");
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.BubbleSortToolStripMenuItem_Click);
            // 
            // шейкернаяСортировкаToolStripMenuItem
            // 
            this.шейкернаяСортировкаToolStripMenuItem.Name = "шейкернаяСортировкаToolStripMenuItem";
            resources.ApplyResources(this.шейкернаяСортировкаToolStripMenuItem, "шейкернаяСортировкаToolStripMenuItem");
            this.шейкернаяСортировкаToolStripMenuItem.Click += new System.EventHandler(this.ШейкернаяСортировкаToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            resources.ApplyResources(this.insertionSortToolStripMenuItem, "insertionSortToolStripMenuItem");
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.InsertionSortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            resources.ApplyResources(this.shellSortToolStripMenuItem, "shellSortToolStripMenuItem");
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.ShellSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            resources.ApplyResources(this.heapSortToolStripMenuItem, "heapSortToolStripMenuItem");
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.HeapSortToolStripMenuItem_Click);
            // 
            // treeSortToolStripMenuItem
            // 
            this.treeSortToolStripMenuItem.Name = "treeSortToolStripMenuItem";
            resources.ApplyResources(this.treeSortToolStripMenuItem, "treeSortToolStripMenuItem");
            this.treeSortToolStripMenuItem.Click += new System.EventHandler(this.TreeSortToolStripMenuItem_Click);
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            resources.ApplyResources(this.selectionSortToolStripMenuItem, "selectionSortToolStripMenuItem");
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.SelectionSortToolStripMenuItem_Click);
            // 
            // gnomeSortToolStripMenuItem
            // 
            this.gnomeSortToolStripMenuItem.Name = "gnomeSortToolStripMenuItem";
            resources.ApplyResources(this.gnomeSortToolStripMenuItem, "gnomeSortToolStripMenuItem");
            this.gnomeSortToolStripMenuItem.Click += new System.EventHandler(this.GnomeSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            resources.ApplyResources(this.mergeSortToolStripMenuItem, "mergeSortToolStripMenuItem");
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.MergeSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            resources.ApplyResources(this.quickSortToolStripMenuItem, "quickSortToolStripMenuItem");
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.QuickSortToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            title3.Name = "Title1";
            title3.Text = "Number of replacements when using algorithms";
            this.chart1.Titles.Add(title3);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // richTextBox2
            // 
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Controls.Add(this.button3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem gnomeSortToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
    }
}