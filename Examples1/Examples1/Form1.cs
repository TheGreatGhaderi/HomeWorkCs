using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples1
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
            double y = Convert.ToDouble(txtY.Text);
            double Result = Math.Sqrt(Math.Pow(Math.Abs(x - y), Math.Abs(y)));
            MessageBox.Show("The Result Is: " + Result.ToString());

        }
    }
}
