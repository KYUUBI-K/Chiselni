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

        }

        private void Rows_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Columns_ValueChanged(object sender, EventArgs e)
        {

        }


        public double Function(double x)
        {
            return Math.Sqrt(x)-Math.Cos(0.2*x);
            //return Math.Cos(2 / x) - 2 * Math.Sin(1 / x) + 1 / x;
        }
        public double DerivativeFirst(double x)
        {
            return 2 / (x * Math.Log(x, 2));
            //return (2 * Math.Sin(2 / x)) / Math.Pow(x, 2) + (2 * Math.Cos(1 / x)) / Math.Pow(x, 2) - 1 / Math.Pow(x, 2);

        }

        private void простоїToolStripMenuItem_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double epsilon = Convert.ToDouble(Eps.Text);
            double x0 = a,
                k = 0,
                xk, x,
                temp;
                while (true)
                {
                    xk = x0 + Function(x0);
                    temp = x0;
                    x0 = xk;
                    k += 1;
                    if (Math.Abs(xk - temp) < epsilon) break;
                    x = b;
                }
                textBox2.Text = $"{xk}, iter = {k}";

            
        }

        private void комбінованоїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(A.Text);
            double b = Convert.ToDouble(B.Text);
            double epsilon = Convert.ToDouble(Eps.Text);
            double k = 0;
            double x = a, xn, temp;
            do
            {
                xn = x - Function(x) / DerivativeFirst(x);
                temp = x;
                x = xn;
                k += 1;
            }
            while (Math.Abs(xn - temp) < epsilon);

            textBox1.Text = $"{xn}, iter = {k}";
        }

       
    }
}