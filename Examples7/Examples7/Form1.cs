using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtTavaan.Text);
            double x2 = Math.Pow(x, 2);
            double x3 = Math.Pow(x, 3);
            MessageBox.Show("Tavaan 2: " + x2.ToString() + "\nTavaan 3: " + x3.ToString());
        }
    }
}
