using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exaples5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNahaayi_Click(object sender, EventArgs e)
        {
            double Mian = Convert.ToDouble(txtMian.Text);
            double Payan = Convert.ToDouble(txtPayan.Text);
            double Nahaayi = (Mian * 0.35) + (Payan * 0.65);
            if (Mian>=0 && Mian<=20 && Payan>=0 && Payan<=20)
            {
                MessageBox.Show("Nomreh Nahaayi Is: " + Nahaayi.ToString());
            }
            else
            {
                MessageBox.Show("Wrong Number!");
            }
        }
    }
}
