using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Завд._2_Вар._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            y.RowCount = 1;
            y.ColumnCount = (int)Columns.Value+1;
            x.RowCount = 1;
            x.ColumnCount = (int)Columns.Value+1;
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = (int)Columns.Value + 1;
        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {
            y.RowCount = 1;
            x.RowCount = 1;
            dataGridView1.RowCount = 1;
        }

        private void Columns_ValueChanged(object sender, EventArgs e)
        {
            y.ColumnCount = (int)Columns.Value+1;
            x.ColumnCount = (int)Columns.Value+1;
            dataGridView1.ColumnCount = (int)Columns.Value + 1;
        }



        private void методЕйлераToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(A.Text);
            double b = Convert.ToInt32(B.Text);
            double n = (int)Columns.Value;
            double h = (b - a) / n;
            double[] X = new double[x.ColumnCount];
            double[] Y = new double[y.ColumnCount];
            double[] exactAnsw = new double[dataGridView1.ColumnCount];
            int row = x.ColumnCount;
            X[0] = a;
            Y[0] = 1;
            Console.WriteLine(Y[0] + " =Y[0]");
            x[0, 0].Value = a;
            y[0, 0].Value = Convert.ToDouble(y1.Text);
            Console.WriteLine($"x[i]=={X[0]}; X[i]=={x[0, 0]}");

            for (int i = 1; i < row; i++)
            {
                X[i] = X[i - 1] + h;
                Console.WriteLine($"x[{i}]=={X[i]};");
                x[i, 0].Value = X[i];
            }

            for (int i = 1; i < row; i++)
            {
                Y[i] = Y[i - 1] + h * ((Math.Pow(Y[i - 1], 2) - X[i - 1]) / (2 * Y[i - 1] * (X[i - 1] + 1)));

                Console.WriteLine($"Y[{i}]=={Y[i]};");
                y[i, 0].Value = Y[i];
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < row; i++)
            {
                exactAnsw[i] = Math.Sqrt(X[i] - (X[i] - 1) * Math.Log((X[i] + 1) / 2));
                Console.WriteLine($"exactAnsw[{i}]=={exactAnsw[i]};");
                dataGridView1[i, 0].Value = exactAnsw[i];
                chart1.Series[0].Points.AddXY(X[i], Y[i]);
                chart1.Series[1].Points.AddXY(X[i], exactAnsw[i]);

            }
        }

        private void удосконаленийМетодЕйлераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(A.Text);
            double b = Convert.ToInt32(B.Text);
            double n = (int)Columns.Value;
            double h = (b - a) / n;
            double[] X = new double[x.ColumnCount];
            double[] Y = new double[y.ColumnCount];
            double[] exactAnsw = new double[dataGridView1.ColumnCount];
            int row = x.ColumnCount;
            X[0] = a;
            Y[0] = Convert.ToDouble(y1.Text);
            Console.WriteLine(Y[0] + " =Y[0]");
            x[0, 0].Value = a;
            y[0, 0].Value = Convert.ToDouble(y1.Text);
            Console.WriteLine($"x[i]=={X[0]}; X[i]=={x[0, 0]}");

            for (int i = 1; i < row; i++)
            {
                X[i] = X[i - 1] + h;
                Console.WriteLine($"x[{i}]=={X[i]};");
                x[i, 0].Value = X[i];
            }

            for (int i = 1; i < row; i++)
            {
                double x1_2 = X[i - 1] + h / 2;
                double y1_2 = Y[i - 1] + h / 2 * ((Math.Pow(Y[i - 1], 2) - X[i - 1]) / (2 * Y[i - 1] * (X[i - 1] + 1)));
                Y[i] = Y[i - 1] + h * ((Math.Pow(y1_2, 2) - x1_2) / (2 * y1_2 * (x1_2 + 1)));
                Console.WriteLine($"Y[{i}]=={Y[i]};");
                y[i, 0].Value = Y[i];
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < row; i++)
            {
                exactAnsw[i] = Math.Sqrt(X[i] - (X[i] - 1) * Math.Log((X[i] + 1) / 2));
                Console.WriteLine($"exactAnsw[{i}]=={exactAnsw[i]};");
                dataGridView1[i, 0].Value = exactAnsw[i];
                chart1.Series[0].Points.AddXY(X[i], Y[i]);
                chart1.Series[1].Points.AddXY(X[i], exactAnsw[i]);

            }
        }

        private void методЕйлераКошіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(A.Text);
            double b = Convert.ToInt32(B.Text);
            double n = (int)Columns.Value;
            double h = (b - a) / n;
            double[] X = new double[x.ColumnCount];
            double[] Y = new double[y.ColumnCount];
            double[] exactAnsw = new double[dataGridView1.ColumnCount];
            int row = x.ColumnCount;
            X[0] = a;
            Y[0] = Convert.ToDouble(y1.Text);
            Console.WriteLine(Y[0] + " =Y[0]");
            x[0, 0].Value = a;
            y[0, 0].Value = Convert.ToDouble(y1.Text);
            Console.WriteLine($"x[i]=={X[0]}; X[i]=={x[0, 0]}");

            for (int i = 1; i < row; i++)
            {
                X[i] = X[i - 1] + h;
                Console.WriteLine($"x[{i}]=={X[i]};");
                x[i, 0].Value = X[i];
            }

            for (int i = 1; i < row; i++)
            {
                double f_x0_y0 =(Math.Pow(Y[i - 1], 2) - X[i - 1]) / (2 * Y[i - 1] * (X[i - 1] + 1));
                double x0 = X[i - 1] + h;
                double y0 = Y[i - 1] + h * f_x0_y0;
                Y[i] = Y[i - 1] + h/2 *(f_x0_y0+(Math.Pow(y0, 2) - x0) / (2 * y0 * (x0 + 1)));
                Console.WriteLine($"Y[{i}]=={Y[i]};");
                y[i, 0].Value = Y[i];
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < row; i++)
            {
                exactAnsw[i] = Math.Sqrt(X[i] - (X[i] - 1) * Math.Log((X[i] + 1) / 2));
                Console.WriteLine($"exactAnsw[{i}]=={exactAnsw[i]};");
                dataGridView1[i, 0].Value = exactAnsw[i];
                chart1.Series[0].Points.AddXY(X[i],Y[i]);
                chart1.Series[1].Points.AddXY(X[i],exactAnsw[i]);
            }
        }
    }
}
