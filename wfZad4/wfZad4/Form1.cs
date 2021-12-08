using System.Windows.Forms;

namespace wfZad4
{
    public partial class Form1 : Form
    {
        int nod(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a > b)
            {
                return nod(a - b, b);
            }
            else
            {
                return nod(a, b - a);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                int a = int.Parse(tb1.Text);
                int b = int.Parse(tb2.Text);
                labRes.Text = "Ответ: " + nod(a, b);
            }
            catch(System.FormatException)
            {
                labRes.Text = "Вы должны ввести целые числа!";
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
    

}
