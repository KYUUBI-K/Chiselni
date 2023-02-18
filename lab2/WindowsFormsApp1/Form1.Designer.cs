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
            this.label3 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rows = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.згенеруватиМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЯкобіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЗейделяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методРелаксаціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.E = new System.Windows.Forms.Label();
            this.Epsilon = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Корені\r\n";
            // 
            // Columns
            // 
            this.Columns.Location = new System.Drawing.Point(182, 80);
            this.Columns.Margin = new System.Windows.Forms.Padding(2);
            this.Columns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(90, 20);
            this.Columns.TabIndex = 16;
            this.Columns.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Columns.ValueChanged += new System.EventHandler(this.Columns_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(76, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 122);
            this.dataGridView1.TabIndex = 14;
            // 
            // Rows
            // 
            this.Rows.Location = new System.Drawing.Point(182, 31);
            this.Rows.Margin = new System.Windows.Forms.Padding(2);
            this.Rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(90, 20);
            this.Rows.TabIndex = 15;
            this.Rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Rows.ValueChanged += new System.EventHandler(this.Rows_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Кількість стовпців";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 282);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 70);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Кількість рядків";
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
            this.згенеруватиМасивToolStripMenuItem,
            this.методЯкобіToolStripMenuItem,
            this.методЗейделяToolStripMenuItem,
            this.методРелаксаціїToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // згенеруватиМасивToolStripMenuItem
            // 
            this.згенеруватиМасивToolStripMenuItem.Name = "згенеруватиМасивToolStripMenuItem";
            this.згенеруватиМасивToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.згенеруватиМасивToolStripMenuItem.Text = "згенерувати масив";
            this.згенеруватиМасивToolStripMenuItem.Click += new System.EventHandler(this.згенеруватиМасивToolStripMenuItem_Click);
            // 
            // методЯкобіToolStripMenuItem
            // 
            this.методЯкобіToolStripMenuItem.Name = "методЯкобіToolStripMenuItem";
            this.методЯкобіToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.методЯкобіToolStripMenuItem.Text = "метод Якобі";
            this.методЯкобіToolStripMenuItem.Click += new System.EventHandler(this.методЯкобіToolStripMenuItem_Click);
            // 
            // методЗейделяToolStripMenuItem
            // 
            this.методЗейделяToolStripMenuItem.Name = "методЗейделяToolStripMenuItem";
            this.методЗейделяToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.методЗейделяToolStripMenuItem.Text = "метод Зейделя";
            this.методЗейделяToolStripMenuItem.Click += new System.EventHandler(this.методЗейделяToolStripMenuItem_Click);
            // 
            // методРелаксаціїToolStripMenuItem
            // 
            this.методРелаксаціїToolStripMenuItem.Name = "методРелаксаціїToolStripMenuItem";
            this.методРелаксаціїToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.методРелаксаціїToolStripMenuItem.Text = "метод релаксації";
            this.методРелаксаціїToolStripMenuItem.Click += new System.EventHandler(this.методРелаксаціїToolStripMenuItem_Click);
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(435, 38);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(14, 13);
            this.E.TabIndex = 19;
            this.E.Text = "E";
            // 
            // Epsilon
            // 
            this.Epsilon.Location = new System.Drawing.Point(466, 35);
            this.Epsilon.Margin = new System.Windows.Forms.Padding(2);
            this.Epsilon.Multiline = true;
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(76, 20);
            this.Epsilon.TabIndex = 20;
            this.Epsilon.Text = "0,01";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(471, 80);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(303, 48);
            this.dataGridView2.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "x0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 34);
            this.textBox2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Кількість ітерацій";
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(657, 35);
            this.w.Margin = new System.Windows.Forms.Padding(2);
            this.w.Multiline = true;
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(76, 20);
            this.w.TabIndex = 25;
            this.w.Text = "0,5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "w";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.w);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.E);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Columns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rows)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Columns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown Rows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem згенеруватиМасивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЯкобіToolStripMenuItem;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.TextBox Epsilon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem методЗейделяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методРелаксаціїToolStripMenuItem;
        private System.Windows.Forms.TextBox w;
        private System.Windows.Forms.Label label6;
    }
}

