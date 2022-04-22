using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computationalMath2
{
    public partial class Form1 : Form
    {
        const double BEGIN = 0;
        double END = 2;
        public Form1()
        {
            InitializeComponent();
        }
        double function(double x)
        {
            return x * Math.Sinh(x);
        }
        double trapezoid(int numberIteration)
        {
            double step = (END - BEGIN) / numberIteration;
            double a = BEGIN;
            double b = a + step;
            double I = 0;
            for (int i = 0; i < numberIteration; i++)
            {
                I += (b - a) * ((function(a) / 2) + (function(b) / 2));
                a = b;
                b = a + step;
            }
            return I;
        }
        double newton(int numberIteration)
        {
            double step = (END - BEGIN) / numberIteration;
            double a = BEGIN;
            double b = a + step;
            double I = 0;
            for (int i = 0; i < numberIteration; i++)
            {
                I += (b - a) * ((function(a) / 8) + (3 * function((2 * a + b) / 3) / 8) + (3 * function((a + 2 * b) / 3) / 8) + (function(b) / 8));
                a = b;
                b = a + step;
            }
            return I;
        }
        double simpson(int numberIteration)
        {
            double step = (END - BEGIN) / numberIteration;
            double a = BEGIN;
            double b = a + step;
            double I = 0;
            for (int i = 0; i < numberIteration; i++)
            {
                I += (b - a) * ((function(a) / 6) + (2 * function((a + b) / 2) / 3) + (function(b) / 6));
                a = b;
                b = a + step;
            }
            return I;
        }


        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var swT = new Stopwatch();
            double error = Convert.ToDouble(ErrorBox.Value);
            double RungeT = 1000000;
            int iT = 1;
            swT.Start();
            while (error < RungeT)
            {
                RungeT = Math.Abs((trapezoid(iT) - trapezoid(iT * 2)) / 3);
                iT++;
            }
            iT*=2;
            swT.Stop();
            textBoxTrapezoid.Text = Convert.ToString(trapezoid(iT));
            timeTextBoxT.Text = Convert.ToString(swT.ElapsedTicks);

            var swS = new Stopwatch();
            double RungeS = 1000000;
            int iS = 1;
            swS.Start();
            while (error < RungeS)
            {
                RungeS = Math.Abs((simpson(iS) - simpson(iS * 2)) / 15);
                iS++;
            }
            iS*=2;
            swS.Stop();
            textBoxSimpson.Text = Convert.ToString(simpson(iT));
            timeTextBoxS.Text = Convert.ToString(swS.ElapsedTicks);

            var swN = new Stopwatch();
            double RungeN = 1000000;
            int iN = 1;
            swN.Start();
            while (error < RungeN)
            {
                RungeN = Math.Abs((newton(iN) - newton(iN * 2)) / 15);
                iN++;
            }
            iN*=2;
            swN.Stop();
            textBoxNewton.Text = Convert.ToString(newton(iT));
            timeTextBoxN.Text = Convert.ToString(swN.ElapsedTicks);

        }
    }
}
