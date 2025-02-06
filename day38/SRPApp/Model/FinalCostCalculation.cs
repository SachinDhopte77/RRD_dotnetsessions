using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPApp.Models
{
    internal class FinalCostCalculation
    {
        public double FinalCost(double cost, double _taxCalculation, double _discountCalculation)
        {
            return cost + (_taxCalculation - _discountCalculation);
        }
    }
}
