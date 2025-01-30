using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanCommanLib.Exceptions;

namespace HumanCommanLib.Models
{
    public class Human :IHuman
    {
        private readonly string _name;
        private readonly int _age;
        private double _height;
        private double _weight;
        private readonly string _gender;
        private const double _weightIncrementbyeataction = .10;
        private const double _weightDecreasebyWorkoutaction = .05;
        private const double _heightIncreasebyWorkoutaction = .02;
        private const double _minmumAgetoworkout = 14;
        private double _weightPercentvalue;
        private double _heightPercentvalue;
        private double _calculatedBMI;

        public Human(string name,int age,double height,double weight,string gender)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            _gender = gender;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public double Height { get { return _height; } }
        public double Weight { get { return _weight; } }
        public string Gender { get { return _gender; } }

        public void Eat()
        {
            _weightPercentvalue = _weight * _weightIncrementbyeataction;
            _weight=_weight+_weightPercentvalue;
        }
        public void Workout()
        {
            if(_age<14)
            {
                throw new Notallowedtoworkout(this);
            }
            _weightPercentvalue = _weight * _weightDecreasebyWorkoutaction;
            _weight = _weight - _weightPercentvalue;
            _heightPercentvalue = _height * _heightIncreasebyWorkoutaction;
            _height = _height + _heightPercentvalue;
        }
        public double CalculateBMI()
        {
            return _weight / (_height * _height);

        }
        public string GetBodyStructure()
        {
            _calculatedBMI = CalculateBMI();
            if(_calculatedBMI<=18.5) { return "underweight"; }
            else if(_calculatedBMI>18.5 && _calculatedBMI <= 24.9) { return "normal weight"; }
            else if(_calculatedBMI>24.9 && _calculatedBMI<=29.9) { return "overweight"; }
            else { return "Obese"; }
           

        }

      
    }
}
