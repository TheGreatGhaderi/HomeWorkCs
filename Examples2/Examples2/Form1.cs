using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            double Result = a + b + c;
            if (a+b>c && a+c>b && b+c>a)
            {
                MessageBox.Show("Mohit Is:" + Result.ToString());
            }
            else
            {
                MessageBox.Show("Mosalas Tashkil Nemidehad!!");
            }
        }
    }
}
