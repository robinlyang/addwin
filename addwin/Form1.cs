using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            double total, x, y;
            x = Convert.ToDouble(number1TxtBox.Text);
            y = Convert.ToDouble(number2TxtBox.Text);
            total = x + y;
            totalTxtBox.Text = total.ToString();
        }
    }
}
