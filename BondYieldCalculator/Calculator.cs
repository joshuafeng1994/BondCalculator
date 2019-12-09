using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondYieldCalculator
{
    public class Calculator
    {
        public static double CalcPrice(double coupon, int years, double face, double rate)
        {
            double price = 0, couponPayment = coupon * face;

            for (int year = 1; year <= years; year++)
            {
                price += couponPayment / (Math.Pow(rate + 1, year));
            }
            price += face / (Math.Pow(1 + rate, years));

            return price;
        }
        public static double CalcYield(double coupon, int years, double face, double price)
        {
            double rate = 0, couponPayment = coupon * face, epsilon = 1;

            rate = (((face - price) / years) + couponPayment) / ((face + price) / 2);
            double estPrice = CalcPrice(coupon, years, face, rate);

            int max_iterations = 100, iterations_done = 0;

            while (Math.Abs(price - estPrice) > 0.0000001 && iterations_done < max_iterations)
            {
                if (estPrice > price)
                {
                    rate += epsilon;
                }
                else
                {
                    rate -= epsilon;
                }

                estPrice = CalcPrice(coupon, years, face, rate);
                epsilon = epsilon / 2;
                iterations_done++;
            }
            return rate;
        }
    }
}
