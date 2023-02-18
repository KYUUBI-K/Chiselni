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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Завд._2_Вар._8
{
    public partial class Form1 : Form
    {
        private List<double> arrX = new List<double>();
        private List<double> arrY = new List<double>();
        private int n = 10;
        private int a = 4;
        private int b = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(numericUpDown1.Text);
            GenerateXY();

            Char1.Series[0].Points.Clear();
            for (int j = 0; j < arrX.Count; j++)
            {
                Char1.Series[0].Points.AddXY(arrX[j], P(arrX[j], 2));
            }

            Char1.Series[1].Points.Clear();
            for (int j = 0; j < arrX.Count; j++)
            {
                Char1.Series[1].Points.AddXY(arrX[j], P(arrX[j], 3));
            }

            Char2.Series[0].Points.Clear();
            for (int j = 0; j < arrX.Count; j++)
            {
                Char2.Series[0].Points.AddXY(arrX[j], P(arrX[j], 4));
            }

            Char2.Series[1].Points.Clear();
            for (int j = 0; j < arrX.Count; j++)
            {
                Char2.Series[1].Points.AddXY(arrX[j], P(arrX[j], 5));
            }

            Char3.Series[0].Points.Clear();
            for (int j = 0; j < arrX.Count; j++)
            {
                Char3.Series[0].Points.AddXY(arrX[j], P(arrX[j], 6));
            }

            Char3.Series[1].Points.Clear();
            for (int i = 0; i < arrX.Count; i++)
            {
                Char3.Series[1].Points.AddXY(arrX[i], arrY[i]);
            }


            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = 3;
            List<double> E = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double el1 = F(arrX[i]);
                double el2 = P(arrX[i], m+1);
                double el3 = el1 - el2;
                E.Add(el3);
                dataGridView3[0, i].Value = el1;
                dataGridView3[1, i].Value = el2;
                dataGridView3[2, i].Value =Math.Abs( Math.Round(el3, 5));
            }
            double es =  0;
            foreach (double item in E)
            {
                es += Math.Pow(item,2); 
            }
            textBox1.Text = Math.Sqrt(es / (n + 1)).ToString();

        }

        private double F(double x)
        {
            return Math.Pow(x,4)-Math.Pow(x,2);
        }

        private void GenerateXY()
        {
            double r = (b - a);
            double h = r / n;
            for (int i = 0; i < n; i++)
            {
                double x = a + h * i;
                arrX.Add(x);
                arrY.Add(F(x));
            }
        }
        private double P(double x, int m)
        {
            List<double[]> matrix = new List<double[]>();

            List<double> c = CreateC(m);
            List<double> d = CreateD(m);
            for (int i = 0; i < m; i++)
            {
                List<double> list = new List<double>();
                for (int j = i; j < m + i; j++)
                {
                    list.Add(c[j]);
                }
                list.Add(d[i]);
                matrix.Add(list.ToArray());
            }
            PerformOperation(matrix.ToArray(), m);
            double[] a = PrintResult(matrix.ToArray(), m);

            double P = 0;
            for (int i = 0; i < m; i++)
            {
                P += a[i] * Math.Pow(x, i);
            }
            return P;
        }

        private List<double> CreateC(int m)
        {
            List<double> c = new List<double>();
            for (int i = 0; i < 2 * m; i++)
            {
                double s = 0;
                for (int j = 0; j < arrX.Count; j++)
                {
                    s += Math.Pow(arrX[j], i);
                }
                c.Add(s);
            }
            return c;
        }

        private List<double> CreateD(int m)
        {
            List<double> d = new List<double>();
            for (int i = 0; i < m; i++)
            {
                double s = 0;
                for (int j = 0; j < arrX.Count; j++)
                {
                    s += arrY[j] * Math.Pow(arrX[j], i);
                }
                d.Add(s);
            }
            return d;
        }

        private int PerformOperation(double[][] a, int n)
        {
            int i, j, k = 0, c, flag = 0;

            for (i = 0; i < n; i++)
            {
                if (a[i][i] == 0)
                {
                    c = 1;
                    while ((i + c) < n && a[i + c][i] == 0)
                        c++;
                    if ((i + c) == n)
                    {
                        flag = 1;
                        break;
                    }
                    for (j = i, k = 0; k <= n; k++)
                    {
                        double temp = a[j][k];
                        a[j][k] = a[j + c][k];
                        a[j + c][k] = temp;
                    }
                }

                for (j = 0; j < n; j++)
                {

                    if (i != j)
                    {
                        double p = a[j][i] / a[i][i];

                        for (k = 0; k <= n; k++)
                            a[j][k] = a[j][k] - (a[i][k]) * p;
                    }
                }
            }
            return flag;

        }
        private double[] PrintResult(double[][] a, int n)
        {
            double[] res = new double[n];

            for (int i = 0; i < n; i++)
            {
                res[i] += a[i][n] / a[i][i];
            }
            return res;
        }
    }
}
