
namespace Завд._2_Вар._8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.y = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЕйлераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удосконаленийМетодЕйлераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЕйлераКошіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // y
            // 
            this.y.AllowUserToAddRows = false;
            this.y.AllowUserToDeleteRows = false;
            this.y.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.y.ColumnHeadersVisible = false;
            this.y.Location = new System.Drawing.Point(151, 138);
            this.y.Margin = new System.Windows.Forms.Padding(2);
            this.y.Name = "y";
            this.y.RowHeadersVisible = false;
            this.y.RowHeadersWidth = 51;
            this.y.RowTemplate.Height = 24;
            this.y.Size = new System.Drawing.Size(670, 44);
            this.y.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "a:";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(320, 42);
            this.A.Margin = new System.Windows.Forms.Padding(2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(38, 20);
            this.A.TabIndex = 9;
            this.A.Text = "1";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(480, 43);
            this.B.Margin = new System.Windows.Forms.Padding(2);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(38, 20);
            this.B.TabIndex = 14;
            this.B.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "b:";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(663, 42);
            this.y1.Margin = new System.Windows.Forms.Padding(2);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(76, 20);
            this.y1.TabIndex = 16;
            this.y1.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "y(1):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "n:";
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(57, 43);
            this.Columns.Margin = new System.Windows.Forms.Padding(2);
            this.Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(90, 20);
            this.Columns.TabIndex = 6;
            this.Columns.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Х:";
            // 
            // x
            // 
            this.x.AllowUserToAddRows = false;
            this.x.AllowUserToDeleteRows = false;
            this.x.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x.ColumnHeadersVisible = false;
            this.x.Location = new System.Drawing.Point(151, 78);
            this.x.Margin = new System.Windows.Forms.Padding(2);
            this.x.Name = "x";
            this.x.RowHeadersVisible = false;
            this.x.RowHeadersWidth = 51;
            this.x.RowTemplate.Height = 24;
            this.x.Size = new System.Drawing.Size(670, 44);
            this.x.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Y:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1458, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методЕйлераToolStripMenuItem,
            this.удосконаленийМетодЕйлераToolStripMenuItem,
            this.методЕйлераКошіToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // методЕйлераToolStripMenuItem
            // 
            this.методЕйлераToolStripMenuItem.Name = "методЕйлераToolStripMenuItem";
            this.методЕйлераToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.методЕйлераToolStripMenuItem.Text = "Метод Ейлера";
            this.методЕйлераToolStripMenuItem.Click += new System.EventHandler(this.методЕйлераToolStripMenuItem_Click_1);
            // 
            // удосконаленийМетодЕйлераToolStripMenuItem
            // 
            this.удосконаленийМетодЕйлераToolStripMenuItem.Name = "удосконаленийМетодЕйлераToolStripMenuItem";
            this.удосконаленийМетодЕйлераToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.удосконаленийМетодЕйлераToolStripMenuItem.Text = "Удосконалений Ейлер";
            this.удосконаленийМетодЕйлераToolStripMenuItem.Click += new System.EventHandler(this.удосконаленийМетодЕйлераToolStripMenuItem_Click);
            // 
            // методЕйлераКошіToolStripMenuItem
            // 
            this.методЕйлераКошіToolStripMenuItem.Name = "методЕйлераКошіToolStripMenuItem";
            this.методЕйлераКошіToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.методЕйлераКошіToolStripMenuItem.Text = "Коші";
            this.методЕйлераКошіToolStripMenuItem.Click += new System.EventHandler(this.методЕйлераКошіToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(151, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 44);
            this.dataGridView1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Y*:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(825, 26);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "(X;Y)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Y*";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(622, 513);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 537);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.B);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView y;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Columns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView x;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЕйлераToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem удосконаленийМетодЕйлераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЕйлераКошіToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

