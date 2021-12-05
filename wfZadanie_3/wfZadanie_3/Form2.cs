using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZadanie_3
{
    public partial class Form2 : Form
    {
        static double f(double x)
        {
            if (x == 1 || x == -1)
            {
                return 1;
            }
            else if (x >= 0 && x != 1)
            {
                return -1 / (1 - x);
            }
            else
            {
                return 1 / (1 + x);
            }
        }
        static void f(double x, out double y)
        {
            if (x == 1 || x == -1)
            {
                y = 1;
            }
            else if (x >= 0 && x != 1)
            {
                y = -1 / (1 - x);
            }
            else
            {
                y = 1 / (1 + x);
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string zad2 = "Задание 2: ";
                string zad3 = "Задание 3: ";
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                for (double x = a; x <= b; x += h)
                {
                    zad2 += f(x).ToString() + " ";
                }
                label4.Text = zad2;
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    f(x, out y);
                    zad3 += y + " ";
                }
                label5.Text = zad3;
            }
            catch (System.FormatException)
            {
                label4.Text = "Вы ввели что-то не то!";
                label5.Text = "Вы ввели что-то не то!";
            }
            finally
            {
                label4.Visible = label5.Visible = true;
            }
        }
    }
}
