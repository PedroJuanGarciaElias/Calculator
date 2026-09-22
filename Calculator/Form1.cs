using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txb3.ReadOnly = true;
            txb6.ReadOnly = true;
            txb9.ReadOnly = true;
            txb12.ReadOnly = true;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txb1.Text);
            int number2 = int.Parse(txb2.Text);
            txb3.Text = (number1 + number2).ToString();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txb4.Text);
            int number2 = int.Parse(txb5.Text);
            txb6.Text = (number1 - number2).ToString();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txb7.Text);
            int number2 = int.Parse(txb8.Text);
            txb9.Text = (number1 * number2).ToString();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(txb10.Text);
            int number2 = int.Parse(txb11.Text);
            txb12.Text = (number1 / number2).ToString();
        }
    }
}
