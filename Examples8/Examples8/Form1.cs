using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(txtAge.Text);
            int y, m, w;
            y = d / 365;
            d %= 365;
            m = d / 30;
            d %= 30;
            w = d / 7;
            d %= 7;
            MessageBox.Show("You Have " + y.ToString() + " Years And " + m.ToString() + " Months And " + w.ToString() + " Weeks And " + d.ToString() + " Days In Your Life.\n Enjoy It =))");
        }
    }
}
