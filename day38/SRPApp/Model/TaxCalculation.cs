using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPApp.Models
{
    internal class TaxCalculation
    {


        public double CalculateTax(double tax, double cost)
        {
            return cost * tax;

        }

    }
}
