using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRPApp.Models
{
    internal class Invoice
    {
        private readonly int _id;
        private readonly string _description;
        private readonly double _cost;
        private readonly double _discountPercent;
        private const double _tax = .10;
        private double _taxCalculation;
        private double _discountCalculation;
        private double _finalcostCalculation;

        TaxCalculation _taxMethodcall = new TaxCalculation();
        DiscountCalculation _discountMethodCall = new DiscountCalculation();
        FinalCostCalculation _finalCostMethodCall = new FinalCostCalculation();

        public Invoice(int id, string description, double cost, double discountPercent)
        {
            _id = id;
            _description = description;
            _cost = cost;
            _discountPercent = discountPercent;
            _taxCalculation = _taxMethodcall.CalculateTax(_tax, _cost);
            _discountCalculation = _discountMethodCall.CalculateDiscount(cost, _discountPercent);
            _finalcostCalculation = _finalCostMethodCall.FinalCost(_cost, _taxCalculation, _discountCalculation);
        }

        public int ID { get { return _id; } }
        public string Description { get { return _description; } }
        public double Cost { get { return _cost; } }
        public double DiscountPercent { get { return _discountPercent; } }
        public double Tax { get { return _tax; } }
        public double TaxCalculation { get { return _taxCalculation; } }
        public double DiscountCalculation { get { return _discountCalculation; } }
        public double FinalcostCalculation { get { return _finalcostCalculation; } }


        public string PrintInvoice()
        {
            string template = $"Id :{ID} " +
                $",description:{Description}" +
                $" cost is :{Cost}" +
                $" tax amt is :{TaxCalculation}" +
                $" discount amt is {DiscountCalculation}" +
                $" Final cost is :{FinalcostCalculation}";
            return template;
        }
    }
}
