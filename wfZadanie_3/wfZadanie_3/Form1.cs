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
    public partial class Form1 : Form
    {
        double f(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        string Result(double ab, double ac, double cd)
        {
            string str = (ab + ac + cd + f(f(ab, ac), cd)).ToString();
            return str;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double AB = Double.Parse(tbAB.Text);
                double AC = Double.Parse(tbAC.Text);
                double DC = Double.Parse(tbDC.Text);
                labRes.Text = Result(AB, AC, DC);
            }
            catch (System.FormatException)
            {
                labRes.Text = "Ввели что-то не то!";
            }
            finally
            {
                labRes.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
