using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculaor
{
    public partial class Form1 : Form
    {
        ICalculator cal;
        public Form1()
        {
            InitializeComponent();
            cal = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnplus_Click(object sender, EventArgs e)
        {
            if (Validateinput())
            {
                double sum = cal.plus((double)txtnumber1.Value, (double)txtnumber2.Value);
                MessageBox.Show("Plus Is:" + sum.ToString());
            }

        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            if (true)
            {
                if (Validateinput())
                {
                    double minus = cal.minus((double)txtnumber1.Value, (double)txtnumber2.Value);
                    MessageBox.Show("Minus is : " + minus.ToString());
                }
            }

        }
        private void btnmultiples_Click(object sender, EventArgs e)
        {
            if (Validateinput())
            {
                double multiples = cal.multiples((double)txtnumber1.Value, (double)txtnumber2.Value);
                MessageBox.Show("Multiples is : " + multiples.ToString());
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Validateinput())
            {
                double divide = cal.divide((double)txtnumber1.Value, (double)txtnumber2.Value);
                MessageBox.Show("Divide is :" + divide.ToString());
            }
        }
        private void btnPower_Click(object sender, EventArgs e)
        {
           
                double Power = cal.Power(Convert.ToInt32(txtnumber1.Value), (int)txtnumber2.Value);
                MessageBox.Show("Power  is :" + Power.ToString());
            
        }

        bool Validateinput()
        {
            bool isvalid = true;
            if (txtnumber1.Value == 0)
            {
                MessageBox.Show("لطفا عدد اول راوارد کنید");
                isvalid = false;
            }
            else if (txtnumber2.Value == 0)
            {
                MessageBox.Show("لطفا عدد دوم راوارد کنید");
                isvalid = false;
            }
            return isvalid;

        }

    }

}
