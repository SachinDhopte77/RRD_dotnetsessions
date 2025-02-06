using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPApp.Models
{
    internal class DiscountCalculation
    {

        public double CalculateDiscount(double cost, double discountPercent)
        {

            return cost * discountPercent;
        }

    }
}
