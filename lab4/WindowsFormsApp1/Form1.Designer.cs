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
            this._n = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямокутниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трапеційToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сімпсонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this._a = new System.Windows.Forms.NumericUpDown();
            this._b = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Epsilon = new System.Windows.Forms.TextBox();
            this.E = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._n)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._b)).BeginInit();
            this.SuspendLayout();
            // 
            // _n
            // 
            this._n.Location = new System.Drawing.Point(104, 33);
            this._n.Margin = new System.Windows.Forms.Padding(2);
            this._n.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._n.Name = "_n";
            this._n.Size = new System.Drawing.Size(90, 20);
            this._n.TabIndex = 15;
            this._n.Value = new decimal(new int[] {
            100,
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
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямокутниківToolStripMenuItem,
            this.трапеційToolStripMenuItem,
            this.сімпсонаToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // прямокутниківToolStripMenuItem
            // 
            this.прямокутниківToolStripMenuItem.Name = "прямокутниківToolStripMenuItem";
            this.прямокутниківToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.прямокутниківToolStripMenuItem.Text = "Прямокутників";
            this.прямокутниківToolStripMenuItem.Click += new System.EventHandler(this.прямокутниківToolStripMenuItem_Click);
            // 
            // трапеційToolStripMenuItem
            // 
            this.трапеційToolStripMenuItem.Name = "трапеційToolStripMenuItem";
            this.трапеційToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.трапеційToolStripMenuItem.Text = "Трапецій";
            this.трапеційToolStripMenuItem.Click += new System.EventHandler(this.трапеційToolStripMenuItem_Click);
            // 
            // сімпсонаToolStripMenuItem
            // 
            this.сімпсонаToolStripMenuItem.Name = "сімпсонаToolStripMenuItem";
            this.сімпсонаToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.сімпсонаToolStripMenuItem.Text = "Сімпсона";
            this.сімпсонаToolStripMenuItem.Click += new System.EventHandler(this.сімпсонаToolStripMenuItem_Click);
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
            this._a.Location = new System.Drawing.Point(123, 134);
            this._a.Margin = new System.Windows.Forms.Padding(2);
            this._a.Name = "_a";
            this._a.Size = new System.Drawing.Size(90, 20);
            this._a.TabIndex = 22;
            this._a.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _b
            // 
            this._b.Location = new System.Drawing.Point(123, 93);
            this._b.Margin = new System.Windows.Forms.Padding(2);
            this._b.Name = "_b";
            this._b.Size = new System.Drawing.Size(90, 20);
            this._b.TabIndex = 23;
            this._b.Value = new decimal(new int[] {
            4,
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
            // Epsilon
            // 
            this.Epsilon.Location = new System.Drawing.Point(445, 33);
            this.Epsilon.Margin = new System.Windows.Forms.Padding(2);
            this.Epsilon.Multiline = true;
            this.Epsilon.Name = "Epsilon";
            this.Epsilon.Size = new System.Drawing.Size(76, 20);
            this.Epsilon.TabIndex = 26;
            this.Epsilon.Text = "0,01";
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Location = new System.Drawing.Point(414, 36);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(14, 13);
            this.E.TabIndex = 25;
            this.E.Text = "E";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 35);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(309, 195);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 35);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 195);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 35);
            this.textBox3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Rectangle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Trapecia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Simpson";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(309, 265);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 139);
            this.textBox4.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Epsilon);
            this.Controls.Add(this.E);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._b);
            this.Controls.Add(this._a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._n);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._n)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown _n;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _a;
        private System.Windows.Forms.NumericUpDown _b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Epsilon;
        private System.Windows.Forms.Label E;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem прямокутниківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трапеційToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сімпсонаToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
    }
}

