using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum.Text);
            if (a%2!=0)
            {
                int sum = 0, multip = 1;
                for (int j = 1; j <= a; j++)
                {
                    sum = sum + j;
                    multip = multip * j;
                }
                MessageBox.Show("Adad Fard Ast\nSum Is: " + sum.ToString() + "\nMultip Is: " + multip.ToString());
            }
            else
            {
                MessageBox.Show("Adad Zoj Ast");
            }
        }
    }
}
