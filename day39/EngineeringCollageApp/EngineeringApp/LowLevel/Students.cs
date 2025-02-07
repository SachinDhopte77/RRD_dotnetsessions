using EngineeringCommonLib.HighLevel;
using EngineeringCommonLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringApp.LowLevel
{
    public class Students
    {
        private readonly double _totalMark;
        private readonly double _markObtained;
        public CollageBranchList _collageBranchList;

        public Students(double totalMark, double markObtained, CollageBranchList collageBranchList)
        {
            _totalMark = totalMark;
            _markObtained = markObtained;
            _collageBranchList = collageBranchList;
        }

        public double TotalMark { get { return _totalMark; } }

        public double MarkObtained { get { return _markObtained; } }

        public CollageBranchList CollageBranchList { get { return _collageBranchList; } }

        public double TotalPercentageObtained()
        {
            return (MarkObtained * 100) / TotalMark;
        }



    }
}
