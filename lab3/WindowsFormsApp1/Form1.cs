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
            dataGridView1.ColumnCount = 1;
            dataGridView2.ColumnCount = 1;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView2.RowCount = (int)numericUpDown1.Value;


        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView2.RowCount = (int)numericUpDown1.Value;

        }

        public void Chebishova()
        {

            double el1 = (b + a) / 2;
            double el2 = 0;
            for (int i = 0; i < n + 1; i++)
            {
                double el = (2 * i + 1);
                el2 =((b-a)/2)* Math.Cos(el / (2 * (n + 1)) * Math.PI);
                X.Add(el1 + el2);
            }
        }
        public double Lagrange(double z)
        {
            double S = 0;
            for (int i = 0; i < X.Count(); i++)
            {
                double s1 = Y[i];
                for (int j = 0; j < X.Count(); j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    s1 *= (z - X[j]) / (X[i] - X[j]);
                }
                S +=  s1;
                //Console.WriteLine(S);
                //z=3
                //X = new List<double> { 1, 2, 3, 4 };
                //Y = new List<double> { 1, 4, 9, 16 };
            }
            return S;
        }
        public double Newton(double z)
        {
            List<List<double>> arr = new List<List<double>>();
            arr.Add(Y);
            for (int i = 0; i < X.Count - 1; i++)
            {
                // стовпчик
                List<double> arrST = new List<double>();
                for (int j = 0; j < X.Count - i - 1; j++)
                {
                    double el = (arr[i][j + 1] - arr[i][j]) / (X[j + 1 + i] - X[j]);
                    arrST.Add(el);
                }
                arr.Add(arrST);
            }
            double N = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine($"arr:{arr[i][0]}");

                double m = arr[i][0];
                for (int j = 0; j < i; j++)
                {
                    m *= z - X[j];
                }
                N += m;
            }
            return N;

        }

        public double NewtonForward(double z)
        {
            double h = X[1] - X[0];
            List<List<double>> arr = new List<List<double>>();
            arr.Add(Y);
            for (int i = 0; i < X.Count - 1; i++)
            {
                // стовпчик
                List<double> arrST = new List<double>();
                for (int j = 0; j < X.Count - i - 1; j++)
                {
                    double el = (arr[i][j + 1] - arr[i][j]);
                    arrST.Add(el);
                }
                arr.Add(arrST);
                //Console.WriteLine(arr[i][0]);
            }
            double N = 0;
            //X = new List<double> { 1, 2, 3, 4 };
            //Y = new List<double> { 1, 4, 9, 16 };
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine($"arr:{arr[i][0]}");
                double m = arr[i][0];
                for (int j = 0; j < i; j++)
                {
                    m *= z - X[j];
                    //Console.WriteLine($"m={m}");
                }
                //Console.WriteLine($"factorial:{ Factorial(i)}");
                //Console.WriteLine($"H:{ H()}");

                //Console.WriteLine($"factorial*Math():{Factorial(i)*Math.Pow(H(),2)}");

                N += m / (Factorial(i) * Math.Pow(h,i));
            }
            return N;

        }

        public double NewtonBack(double z)
        {
            double h = X[1]-X[0];
            List<List<double>> arr = new List<List<double>>();
            arr.Add(Y);
            for (int i = 0; i < X.Count - 1; i++)
            {
                // стовпчик
                List<double> arrST = new List<double>();
                for (int j = 0; j < X.Count - i - 1; j++)
                {
                    double el = arr[i][j + 1] - arr[i][j];
                    arrST.Add(el);
                }
                arr.Add(arrST);
            }
            double N = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                //Console.WriteLine($"arr:{arr[i][arr[i].Count - 1]}");

                double m = arr[i][arr[i].Count - 1];
                for (int j = 0; j < i; j++)
                {
                    m *= z - X[arr.Count - j - 1];
                    //Console.WriteLine($"m= { m}");
                }
                N += m / (Factorial(i)*Math.Pow(h,i));

            }
            return N;

        }
        public List<double> X = new List<double>();
        public List<double> Y = new List<double>();


        public double a = 0;
        public double b = 0;
        public double n = 0;
        public double m = 0;

        public double F(double x)
        {
            return Math.Pow(x, 4) - Math.Pow(x, 2);
        }
        public double Factorial(double number)
        {
            if (number == 0) return 1;
            if (number < 0) return -1;
            else if (number == 1) return 1;

            return number * Factorial(number - 1);
        }
        public double H()
        {
            return (b -a) /n;
        }

        private void лагранжToolStripMenuItem_Click(object sender, EventArgs e)
        {

            n = Convert.ToInt32(this._n.Text);
            m = Convert.ToInt32(this._m.Text);
            a = Convert.ToDouble(this._a.Text);
            b = Convert.ToDouble(this._b.Text);
            X = new List<double>();
            Y = new List<double>();

            Chebishova();
            //for (int i = 0; i < X.Count(); i++)
            //{
            //    Console.WriteLine(X[i]);
            //}
            //for (int i = 0; i < numericUpDown1.Value; i++)
            //{
            //    //double[] x = new double[dataGridView1.ColumnCount];
            //    //x[i] = Convert.ToDouble(dataGridView1[0,i].Value);
            //    X.Add(Convert.ToDouble(dataGridView1[0, i].Value));
            //}

            //for (int i = 0; i < numericUpDown1.Value; i++)
            //{

            //    Y.Add(Convert.ToDouble(dataGridView2[0,i].Value));
            //}

            for (int i = 0; i < X.Count(); i++)
            {
                Y.Add(F(X[i]));
            }
            //for (int i = 0; i < Y.Count(); i++)
            //{
            //    Console.WriteLine(Y[i]);
            //}
            double max = 0;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < m; i++)
            {
                double el = a + ((b - a) / m) * i;
                double s = Math.Abs( F(el) - Lagrange(el));
                chart1.Series[0].Points.AddXY(el,F(el));
                chart2.Series[0].Points.AddXY(el,Lagrange(el));
                if (max < s)
                {
                    max = s;
                }

            }
            Console.WriteLine(max);
            textBox1.Text = max.ToString();
            
        }
       

        private void ньютонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(this._n.Text);
            m = Convert.ToInt32(this._m.Text);
            a = Convert.ToDouble(this._a.Text);
            b = Convert.ToDouble(this._b.Text);
            X = new List<double>();
            Y = new List<double>();

            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < n; i++)
            {
                
                
                    X.Add(rand.Next(0, 100));
                
            }
            //X = new List<double> { 4, 4.1, 3, 4 };



            //Console.WriteLine(NewtonForward(6));

            //Chebishova();
            for (int i = 0; i < X.Count(); i++)
            {
                Y.Add(F(X[i]));
            }
            double max = 0;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < m; i++)
            {
                double el = a + ((b - a) / m) * i;
                double s = Math.Abs(F(el) - Newton(el));
                    chart1.Series[0].Points.AddXY(el, F(el));
                    chart2.Series[0].Points.AddXY(el, Newton(el));
                if (max < s)
                {
                    max = s;
                }

            }
            Console.WriteLine(max);
            textBox1.Text = max.ToString();

        }



        private void ньютонавпередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(this._n.Text);
            m = Convert.ToInt32(this._m.Text);
            a = Convert.ToDouble(this._a.Text);
            b = Convert.ToDouble(this._b.Text);
            X = new List<double>();
            Y = new List<double>();
            //X = new List<double> { 1, 2, 3, 4 };
            //Y = new List<double> { 1, 4, 9, 16 };
            //Console.WriteLine(NewtonForward(6));
            for (int i = 0; i < n + 1; i++)
            {
                X.Add(this.a + i * H());
            }

            for (int i = 0; i < X.Count(); i++)
            {
                Y.Add(F(X[i]));
            }
            //X =  new List<double> {1,2,3,4 };
            //Y =  new List<double> {2,4,9,16 };
            //Console.WriteLine( NewtonForward(5));
            double max = 0;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < m; i++)
            {
                double el = a + ((b - a) / m) * i;
                double s = Math.Abs(F(el) - NewtonForward(el));
                chart1.Series[0].Points.AddXY(el, F(el));
                chart2.Series[0].Points.AddXY(el, NewtonForward(el));
                if (max < s)
                {
                    max = s;
                }

            }
            Console.WriteLine(max);
            textBox1.Text = max.ToString();



        }

        private void ньютонаназадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(this._n.Text);
            m = Convert.ToInt32(this._m.Text);
            a = Convert.ToDouble(this._a.Text);
            b = Convert.ToDouble(this._b.Text);
            X = new List<double>();
            Y = new List<double>();
            //X = new List<double> { 1,3, 5 };
            //Y = new List<double> { 1,9, 25 };
            //Console.WriteLine(NewtonBack(9));

            for (int i = 0; i < n + 1; i++)
            {
                X.Add(this.a + i * H());
            }

            for (int i = 0; i < X.Count(); i++)
            {
                Y.Add(F(X[i]));
            }
            double max = 0;
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            for (int i = 0; i < m; i++)
            {
                double el = a + ((b - a) / m) * i;
                double s = Math.Abs(F(el) - NewtonBack(el));
                chart1.Series[0].Points.AddXY(el, F(el));
                chart2.Series[0].Points.AddXY(el, NewtonBack(el));
                if (max < s)
                {
                    max = s;
                }

            }
            Console.WriteLine(max);
            textBox1.Text = max.ToString();
        }

        private void знайтиЗначенняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double z = Convert.ToDouble(this.z.Text);
            n = Convert.ToInt32(this._n.Text);
            m = Convert.ToInt32(this._m.Text);
            a = Convert.ToDouble(this._a.Text);
            b = Convert.ToDouble(this._b.Text);
            X = new List<double>();
            Y = new List<double>();

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                //double[] x = new double[dataGridView1.ColumnCount];
                //x[i] = Convert.ToDouble(dataGridView1[0,i].Value);
                X.Add(Convert.ToDouble(dataGridView1[0, i].Value));
                Console.WriteLine(X[i]);
            }

            for (int i = 0; i < numericUpDown1.Value; i++)
            {

                Y.Add(Convert.ToDouble(dataGridView2[0, i].Value));
                Console.WriteLine(Y[i]);

            }

            Console.WriteLine($"Лагранжа: {Lagrange(z)}");
            Console.WriteLine($"Ньютона: {Newton(z)}");
            Console.WriteLine($"Ньютона вперед: {NewtonForward(z)}");
            Console.WriteLine($"Ньютона назад: {NewtonBack(z)}");
        }
    }
}
