using EngineeringCommonLib.HighLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.LowLevel
{
    public class Professor : ISalaryCalculation
    {
        private readonly double _basicSalary;
        private readonly double _housingallownce;
        private readonly double _deduction;

        public Professor(double basicSalary, double housingallownces, double deduction)
        {
            _basicSalary = basicSalary;
            _housingallownce = housingallownces;
            _deduction = deduction;
        }

        public double BasicSalary { get { return _basicSalary; } }
        public double HousingAllownce { get { return _housingallownce; } }
        public double Deduction { get { return _deduction; } }



        public double SalaryCalculation()
        {
            return BasicSalary + (HousingAllownce - Deduction);
        }
    }
}
