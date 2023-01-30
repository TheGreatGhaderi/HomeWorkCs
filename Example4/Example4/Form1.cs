using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double Result = Math.Abs(Math.Pow(x, 2) + Math.Pow(2, x) + Math.Sqrt(x));
            MessageBox.Show("Final Result Is: " + Result.ToString());
        }
    }
}
