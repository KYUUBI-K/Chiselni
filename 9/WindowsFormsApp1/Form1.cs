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
           


        }

        private List<double> arrX = new List<double>();
        private List<double> arrY = new List<double>();
        private int Mmax = 5;


        //public void Chebishova()
        //{

        //    double el1 = (b + a) / 2;
        //    double el2 = 0;
        //    for (int i = 0; i < n + 1; i++)
        //    {
        //        double el = (2 * i + 1);
        //        el2 =((b-a)/2)* Math.Cos(el / (2 * (n + 1)) * Math.PI);
        //        X.Add(el1 + el2);
        //    }
        //}

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


        private void найменшКвадратівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int m = 0; m < Mmax; m++)
            {
                chart1.Series[m].Points.Clear();
                for (int j = 0; j < arrX.Count; j++)
                {
                    chart1.Series[m].Points.AddXY(arrX[j], P(arrX[j], m));
                }
            }
            chart1.Series[Mmax].Points.Clear();
            for (int i = 0; i < arrX.Count; i++)
            {
                chart1.Series[Mmax].Points.AddXY(arrX[i], arrY[i]);
            }

        }






    }
}
