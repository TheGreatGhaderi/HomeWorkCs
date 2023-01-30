using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examples3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtTool.Text);
            double b = Convert.ToDouble(txtArz.Text);
            double c = Convert.ToDouble(txtErtefaa.Text);
            double Result = a * b * c;
            MessageBox.Show("Hajm Mokaab Is: " + Result.ToString());

        }
    }
}
