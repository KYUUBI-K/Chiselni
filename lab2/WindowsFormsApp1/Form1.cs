using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)Rows.Value;
            dataGridView1.ColumnCount = (int)Columns.Value;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = (int)Rows.Value;

        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)Rows.Value;
            dataGridView2.ColumnCount = (int)Rows.Value;

        }

        private void Columns_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)Columns.Value;
        }


        private void згенеруватиМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = rand.Next(-10, 10);
                }
            }
        }
        static void PrintMatrix(double[,] a, int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        //static void PrintMatrix(double[,] a, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j <= n; j++)
        //            Console.Write(a[i, j] + " ");
        //        Console.WriteLine();
        //    }
        //}
        //static void PrintMatrixForNxN(double[,] a, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //            Console.Write(a[i, j] + " ");
        //        Console.WriteLine();
        //    }
        //}
        public void Iteration(double[,] temp, int row, double[] X0, double[] XI, double inpEps, int iter)
        {
            string x = "";

            double[,] dop = new double[row, row + 1];
            double error = 0;
            do
            {
                error = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j <= row; j++)
                    {

                        if (j != 0)
                        {
                            dop[i, j] = temp[i, j] * X0[j - 1];
                        }
                        else
                        {
                            dop[i, j] = temp[i, j];
                        }

                        XI[i] += dop[i, j];
                    }
                    //Console.WriteLine($"x{i + 1}= " + XI[i]);
                    double eps = Math.Abs(XI[i] - X0[i]);
                    //Console.WriteLine($"{XI[i]}-{X0[i]}= " + eps);
                    if (eps > error) { error = eps; }
                }
                for (int i = 0; i < row; i++)
                {
                    X0[i] = XI[i];
                    XI[i] = 0;
                    //Console.WriteLine($"new x:{ X0[i]}");
                }
                iter++;
            }
            while (error >= inpEps);
            for (int i = 0; i < row; i++)
            {
                x += $"X{i + 1}= {X0[i]}";

            }
            textBox1.Text = x;
            textBox2.Text = Convert.ToString(iter);

        }

        public void Seidel(double[,] temp, int row, double[] X0, double[] XI, double inpEps, int iter)
        {
            string x = "";
            double[] local = new double[row];
            double[,] dop = new double[row, row + 1];
            double error = 0;
            do
            {
                error = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j <= row; j++)
                    {

                        if (j != 0)
                        {
                            dop[i, j] = temp[i, j] * X0[j - 1];
                        }
                        else
                        {
                            dop[i, j] = temp[i, j];
                        }

                        XI[i] += dop[i, j];
                    }
                    local[i] = X0[i];
                    X0[i] = XI[i];
                    //Console.WriteLine($"x{i + 1}= " + XI[i]);
                    double eps = Math.Abs(XI[i] - local[i]);
                    //Console.WriteLine($"{XI[i]}-{local[i]}= " + eps);
                    if (eps > error) { error = eps; }
                }
                for (int i = 0; i < row; i++)
                {
                    XI[i] = 0;
                    //Console.WriteLine($"new x:{ X0[i]}");
                }
                iter++;
            }
            while (error >= inpEps);
                for (int i = 0; i < row; i++)
                {
                    x += $"X{i + 1}= {X0[i]} \n";

                }
            textBox1.Text = x;
            textBox2.Text = Convert.ToString(iter);

        }

        public void Relaxation(double[,] A, double[] b, int row,double[] X0, double inpEps, double w)
        {
            double norma;
            double[] x = new double[row];
            //for (int i = 0; i < row; i++)
            //{
            //    x[i] = X0[i];

            //}
            int k = 0;
            do
            {
                k++;
                norma = 0;
                for (int i = 0; i < row; i++)
                {
                    x[i] = b[i];
                    for (int j = 0; j < row; j++)
                    {
                        if (i != j)
                        {
                            //Console.WriteLine($"{x[i]} - {A[i, j]} * {x[j]}");
                            x[i] = x[i] - A[i, j] * x[j];
                            //Console.WriteLine("x[i]==" + x[i]);
                        }
                    }
                    x[i] /= A[i, i];
                    //Console.WriteLine("x[i]=/A[i,i]" + x[i]);

                    x[i] = w * x[i] + (1 - w) * X0[i];
                    //Console.WriteLine($"x[i]= w * x[i] + (1 - w) * {X0[i]}" +  $"{x[i]}");

                    if (Math.Abs(x[i] - X0[i]) > norma)
                        norma = Math.Abs(x[i] - X0[i]);
                    X0[i] = x[i];

                }

            }
            while (norma >= inpEps);
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(X0[i]);

            }
            string x_iter = "";
            for (int i = 0; i < row; i++)
            {
                x_iter += $"X{i + 1}= {X0[i]} \n";

            }
            textBox1.Text = x_iter;
            textBox2.Text = Convert.ToString(k);

        }




        private void методЯкобіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            double[] X0 = new double[dataGridView1.RowCount];

            int row = dataGridView1.RowCount;
            int col = dataGridView1.ColumnCount;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        arr[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                    }
                    X0[i] = Convert.ToDouble(dataGridView2[i, 0].Value);
                }
            double Epsilon = Convert.ToDouble(this.Epsilon.Text);
            double[,] A = new double[row, col];
            double[] diagonal = new double[row];
            for (int i = 0; i < row; i++)
            {
                diagonal[i] = arr[i, i];
                arr[i, i] = 0;
                for (int j = 0; j < col; j++)
                {

                    A[i, j] = arr[i, j];
                }

            }



            PrintMatrix(arr, dataGridView1.RowCount, dataGridView1.ColumnCount);

            double[,] temp = new double[row, col];

            //double[,] A = {{ 0, -1,2, 12 },
            //      { 3, 0, -2,7 },
            //      { 1, 1, 0 ,11 }};
            //double[] b = { 5, 8, 4 };

            //double[] X0 = { 0, 0, 0 };

            for (int i = 0; i < row; i++)
            {
                double n = A[i, row] / diagonal[i];
                temp[i, 0] = n;
                int k = 1;
                for (int j = 0; j < row; j++)
                {
                    temp[i, k] = -1 * (A[i, j] / diagonal[i]);

                    k++;
                }
            }
            PrintMatrix(temp, row, col);

            double[] XI = new double[dataGridView1.RowCount];
            int iter = 0;
            Iteration(temp, row, X0, XI, Epsilon, iter);
        }

        private void методЗейделяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            double[] X0 = new double[dataGridView1.RowCount];

            int row = dataGridView1.RowCount;
            int col = dataGridView1.ColumnCount;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                }
                X0[i] = Convert.ToDouble(dataGridView2[i, 0].Value);
            }
            double Epsilon = Convert.ToDouble(this.Epsilon.Text);
            double[,] A = new double[row, col];
            double[] diagonal = new double[row];
            for (int i = 0; i < row; i++)
            {
                diagonal[i] = arr[i, i];
                arr[i, i] = 0;
                for (int j = 0; j < col; j++)
                {

                    A[i, j] = arr[i, j];
                }

            }



            //PrintMatrix(arr, dataGridView1.RowCount, dataGridView1.ColumnCount);
            //double[,] A = {{ 0, -1, 4, 12 },
            //               { 3, 0, 0,7 },
            //               { -1, 0, 0 ,11}};

            //double[,] A = {{ 2, -1, 4, 12 },
            //               { 3, 2, 0,7 },
            //               { -1, 0, 4 ,11}};
            //double[,] arr =new double [row, col];
            //PrintMatrix(A,row,col);

            //for(int i = 0; i < row; i++)
            //{
            //    for (int j=0;j<=row;j++)
            //    {
            //        if()
            //        if (A[j, i] > A[j+1, i])
            //        {
            //            arr[i, j] = A[j, i];
            //        }
            //    }
            //}
            //double[] diagonal = { 2, 2, 4 };

            //double[] X0 = { 0, 0, 0 };

            double[,] temp = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                double n = A[i, row] / diagonal[i];
                temp[i, 0] = n;
                int k = 1;
                for (int j = 0; j < row; j++)
                {
                    temp[i, k] = -1 * (A[i, j] / diagonal[i]);

                    k++;
                }
            }
            PrintMatrix(temp, row, col);

            double[] XI = new double[dataGridView1.RowCount];
            int iter = 0;
            Seidel(temp, row, X0, XI, Epsilon, iter);

        }

        private void методРелаксаціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double[,] arr = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            double[] X0 = new double[dataGridView1.RowCount];

            int row = dataGridView1.RowCount;
            int col = dataGridView1.ColumnCount;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = Convert.ToDouble(dataGridView1[j, i].Value);
                }
                X0[i] = Convert.ToDouble(dataGridView2[i, 0].Value);
            }
            double Epsilon = Convert.ToDouble(this.Epsilon.Text);
            double w = Convert.ToDouble(this.w.Text);

            PrintMatrix(arr, dataGridView1.RowCount, dataGridView1.ColumnCount);

            double[,] A = new double[row, row];
            double[] b = new double[row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    if (j == row)
                    {
                        b[i] = arr[i, j];
                    }
                    else
                    {

                        A[i, j] = arr[i, j];
                    }
                }

                Console.WriteLine(b[i]);

            }
            PrintMatrix(A, dataGridView1.RowCount, dataGridView1.RowCount);

            Relaxation(A, b, row,X0, Epsilon, w);
        }
    }
}
