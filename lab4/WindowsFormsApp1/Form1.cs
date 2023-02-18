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
        public double Func(double x)
        {
            //return 1 / (1 + Math.Pow(x, 5));
            //return Math.Pow(x, 3);
            return   Math.Pow(x, 3);
            //return Math.Sin(x);
            //return Math.Pow(Math.E, x) / (4 + 5 * Math.Pow(Math.E, x));
        }
        public double Integral(double x, double y)
        {
            return Math.Abs(Math.Pow(y, 5) - Math.Pow(x, 5));

            //return -Math.Cos(x) - (-Math.Cos(y));

            //return Math.Log(4 + 5 * Math.Pow(Math.E, x)) / 5 - Math.Log(4 + 5 * Math.Pow(Math.E, y)) / 5;
        }
   
       
        
        public double Rect(double a, double b, int n)
        {
            var h = (b - a) / n;
            double sum = 0;
            double x = a + h / 2;

            for (var i = 0; i < n; i++)
            {
                sum += Func(x);
                x += h;
            }
            return sum * h;

        }
        double Simpson(double a, double b, int n)
        {
            double h = (b - a) / n;
            double s = (Func(a) + Func(b)) / 2;
            for (int i = 1; i <= n - 1; i++)
            {
                double xk = a + h * i;
                double xk1 = a + h * (i - 1);
                s += Func(xk) + 2 * Func((xk1 + xk) / 2);
            }
            var x = a + h * n;
            var x1 = a + h * (n - 1);
            s += 2 * Func((x1 + x) / 2);

            return s * h / 3;

        }
        double Trapeze(double a, double b, int n)
        {
            double  h, s;
            h = (b - a) / n;
            s = (Func(a) + Func(b)) / 2;
            for (int i = 1; i < n; i++)
            {
                s += Func(a + i * h);
            }
            return s * h;
        }

        private void прямокутниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(this._b.Text);
            int n = Convert.ToInt32(this._n.Text);
            double a = Convert.ToDouble(this._a.Text);
            double eps = Convert.ToDouble(this.Epsilon.Text);
            int i = 1;
            double diff;
            do
            {
                i++;
                diff = Math.Abs(Rect(b, a, i) - Rect(b, a, i + 1));
            }
            while (diff > eps);
            textBox1.Text = $"iter= {i + 1}   Rect={Rect(b, a, i + 1)}";
            textBox4.Text = $"Integrals {Integral(b, a)}";


        }

        private void трапеційToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(this._b.Text);
            int n = Convert.ToInt32(this._n.Text);
            double a = Convert.ToDouble(this._a.Text);
            double eps = Convert.ToDouble(this.Epsilon.Text);
            int i = 0;
            double diff;
            do
            {
                i++;
                diff = Math.Abs(Trapeze(b, a, i) - Trapeze(b, a, i + 1));
            }
            while (diff > eps);
            textBox2.Text = $"iter= {i + 1}   Trapeze={Trapeze(b, a, i + 1)}";
            textBox4.Text = $"Integrals {Integral(b, a)}";


        }

        private void сімпсонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(this._b.Text);
            int n = Convert.ToInt32(this._n.Text);
            double a = Convert.ToDouble(this._a.Text);
            double eps = Convert.ToDouble(this.Epsilon.Text);
            int i = 0;
            double diff;
            do
            {
                i++;
                diff = Math.Abs(Simpson(b, a, i) - Simpson(b, a, i + 1));
            }
            while (diff > eps);
            textBox3.Text = $"iter= {i + 1}   Simpson={Simpson(b, a, i + 1)}";
            textBox4.Text = $"Integrals {Integral(b, a)}";

        }
    }
}
