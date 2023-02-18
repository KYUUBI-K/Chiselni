
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Eps = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.комбінованоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // Eps
            // 
            this.Eps.Location = new System.Drawing.Point(666, 45);
            this.Eps.Margin = new System.Windows.Forms.Padding(2);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(76, 20);
            this.Eps.TabIndex = 16;
            this.Eps.Text = "0,01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Eps";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простоїToolStripMenuItem,
            this.комбінованоїToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // простоїToolStripMenuItem
            // 
            this.простоїToolStripMenuItem.Name = "простоїToolStripMenuItem";
            this.простоїToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.простоїToolStripMenuItem.Text = "Простої ";
            this.простоїToolStripMenuItem.Click += new System.EventHandler(this.простоїToolStripMenuItem_Click);
            // 
            // комбінованоїToolStripMenuItem
            // 
            this.комбінованоїToolStripMenuItem.Name = "комбінованоїToolStripMenuItem";
            this.комбінованоїToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.комбінованоїToolStripMenuItem.Text = "Комбінованої";
            this.комбінованоїToolStripMenuItem.Click += new System.EventHandler(this.комбінованоїToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 67);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 125);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 67);
            this.textBox2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 537);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Eps);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Eps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простоїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem комбінованоїToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

