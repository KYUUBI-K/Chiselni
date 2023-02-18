namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this._n = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лагранжToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ньютонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ньютонавпередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ньютонаназадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this._m = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._a = new System.Windows.Forms.NumericUpDown();
            this._b = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.знайтиЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.z = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._n)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            this.SuspendLayout();
            // 
            // _n
            // 
            this._n.Location = new System.Drawing.Point(104, 33);
            this._n.Margin = new System.Windows.Forms.Padding(2);
            this._n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._n.Name = "_n";
            this._n.Size = new System.Drawing.Size(90, 20);
            this._n.TabIndex = 15;
            this._n.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "n";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лагранжToolStripMenuItem,
            this.ньютонаToolStripMenuItem,
            this.ньютонавпередToolStripMenuItem,
            this.ньютонаназадToolStripMenuItem,
            this.знайтиЗначенняToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // лагранжToolStripMenuItem
            // 
            this.лагранжToolStripMenuItem.Name = "лагранжToolStripMenuItem";
            this.лагранжToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лагранжToolStripMenuItem.Text = "Лагранж";
            this.лагранжToolStripMenuItem.Click += new System.EventHandler(this.лагранжToolStripMenuItem_Click);
            // 
            // ньютонаToolStripMenuItem
            // 
            this.ньютонаToolStripMenuItem.Name = "ньютонаToolStripMenuItem";
            this.ньютонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ньютонаToolStripMenuItem.Text = "Ньютона";
            this.ньютонаToolStripMenuItem.Click += new System.EventHandler(this.ньютонаToolStripMenuItem_Click);
            // 
            // ньютонавпередToolStripMenuItem
            // 
            this.ньютонавпередToolStripMenuItem.Name = "ньютонавпередToolStripMenuItem";
            this.ньютонавпередToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ньютонавпередToolStripMenuItem.Text = "Ньютона(вперед)";
            this.ньютонавпередToolStripMenuItem.Click += new System.EventHandler(this.ньютонавпередToolStripMenuItem_Click);
            // 
            // ньютонаназадToolStripMenuItem
            // 
            this.ньютонаназадToolStripMenuItem.Name = "ньютонаназадToolStripMenuItem";
            this.ньютонаназадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ньютонаназадToolStripMenuItem.Text = "Ньютона(назад)";
            this.ньютонаназадToolStripMenuItem.Click += new System.EventHandler(this.ньютонаназадToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "m";
            // 
            // _m
            // 
            this._m.Location = new System.Drawing.Point(341, 35);
            this._m.Margin = new System.Windows.Forms.Padding(2);
            this._m.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._m.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._m.Name = "_m";
            this._m.Size = new System.Drawing.Size(90, 20);
            this._m.TabIndex = 20;
            this._m.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "a";
            // 
            // _a
            // 
            this._a.Location = new System.Drawing.Point(104, 88);
            this._a.Margin = new System.Windows.Forms.Padding(2);
            this._a.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._a.Name = "_a";
            this._a.Size = new System.Drawing.Size(90, 20);
            this._a.TabIndex = 22;
            this._a.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // _b
            // 
            this._b.Location = new System.Drawing.Point(104, 134);
            this._b.Margin = new System.Windows.Forms.Padding(2);
            this._b.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._b.Name = "_b";
            this._b.Size = new System.Drawing.Size(90, 20);
            this._b.TabIndex = 23;
            this._b.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "b";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 253);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Blue;
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.Legend = "Legend1";
            series3.LegendText = "Графік функції";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(407, 185);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(445, 253);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "Графік Метода ";
            series4.Name = "Series2";
            series4.YValuesPerPoint = 4;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(343, 185);
            this.chart2.TabIndex = 26;
            this.chart2.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "max";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 28;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(715, 95);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(73, 148);
            this.dataGridView2.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(583, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(73, 148);
            this.dataGridView1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "y";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(639, 35);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // знайтиЗначенняToolStripMenuItem
            // 
            this.знайтиЗначенняToolStripMenuItem.Name = "знайтиЗначенняToolStripMenuItem";
            this.знайтиЗначенняToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.знайтиЗначенняToolStripMenuItem.Text = "Знайти значення";
            this.знайтиЗначенняToolStripMenuItem.Click += new System.EventHandler(this.знайтиЗначенняToolStripMenuItem_Click);
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(663, 68);
            this.z.Margin = new System.Windows.Forms.Padding(2);
            this.z.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(47, 20);
            this.z.TabIndex = 34;
            this.z.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.z);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._b);
            this.Controls.Add(this._a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._m);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._n);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._n)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown _n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лагранжToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _m;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _a;
        private System.Windows.Forms.NumericUpDown _b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem ньютонаToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ньютонавпередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ньютонаназадToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem знайтиЗначенняToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown z;
    }
}

