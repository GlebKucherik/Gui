using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZad4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(tbN.Text);
                if (n % 2 != 0)
                {
                    throw new Exception("Число должно быть четное!");
                }
                prac p = new prac(n);
                labRes.Text = p.Str;
            }
            catch (System.FormatException)
            {
                labRes.Text = "Вы должны ввести целое число!";
            }
            catch (Exception exp)
            {
                labRes.Text = exp.Message;
            }

        }
    }
    class prac
    {
        string str1 = String.Empty;
        public string Str
        {
            get
            {
                return str1;
            }
        }
        public prac(int k)
        {
            rec(k, 0);
        }
        void str(int i, string c)
        {
            int j = 0;
            while (j < i)
            {
                j++;
                str1 += c;
            }
        }
        void rec(int n, int i)
        {
            if (n >= 0)
            {
                str(i, "*");
                str(n, " ");
                str(i, "*");
                str1 += '\n';
                rec(n - 2, i + 1);
                str(i, "*");
                str(n, " ");
                str(i, "*");
                str1 += '\n';
            }
        }
    }

}
