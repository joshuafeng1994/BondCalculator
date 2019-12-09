using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BondYieldCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPrice_Click(object sender, EventArgs e)
        {
            int years = (int)Years.Value;
            double coupon = (double)Coupon.Value, 
                face = (double)Face.Value, 
                rate = (double)YTM.Value;

            double price = Calculator.CalcPrice(coupon, years, face, rate);
            Price.Value = (decimal)price;
        }

        private void GetYTM_Click(object sender, EventArgs e)
        {
            int years = (int)Years.Value;
            double coupon = (double)Coupon.Value, 
                face = (double)Face.Value, 
                price = (double)Price.Value;

            double rate = Calculator.CalcYield(coupon, years, face, price);
            YTM.Value = (decimal)rate;
        }

        
    }
}
