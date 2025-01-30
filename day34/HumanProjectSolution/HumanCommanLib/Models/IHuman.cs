using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanCommanLib.Models
{
    internal interface IHuman
    {
        void Eat();
        void Workout();
        double CalculateBMI();
        string GetBodyStructure();
        
    }
}
