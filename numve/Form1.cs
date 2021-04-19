using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1=5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3")+ "\n");
            richTextBox1.AppendText(d1.ToString("N0")+ "\n");
            richTextBox1.AppendText(d1.ToString("0")+ "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0")+ "\n");
            richTextBox1.AppendText(d1.ToString("0.00e00")+ "\n");

            double pi = 3.141592653589793;
         double c = 299792458;

            richTextBox1.AppendText(pi.ToString("0.00e00") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00e00") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00e00") + "\n");

            richTextBox1.AppendText(c .ToString("0.00e00") + "\n");
            richTextBox1.AppendText(c .ToString("0.00e00") + "\n");
            richTextBox1.AppendText(c .ToString("0.00e00") + "\n");
            richTextBox1.AppendText(c .ToString("0.00e00") + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + "is not an interger");
            }
            string s2 = "3.2";
            try
            {
                int i2 = int.Parse(s2);
            }
            catch
            {
                MessageBox.Show(s2 + "is not an interger");
                int i2=0
            }

            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);
            }
            catch
            {
                double d2 = 0;
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
