using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangelEncapsulationExcercise.Models
{
    internal class Rectangle
    {

        private int _width;
        private int _height;

        private const int Minimum_Dimention = 10;
        private const int Maximum_Dimention = 100;

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetWidth(int UserWidth)
        {
            _width = ValidateUserHeightWidth(UserWidth);
        }
        public int GetWidth() { return _width; }


        public void SetHeight(int UserHeight)
        {
            _height = ValidateUserHeightWidth(UserHeight);
        }

        public int GetHeight() { return _height; }

        private int ValidateUserHeightWidth(int Dimention)
        {
            if (Dimention < Minimum_Dimention) return Minimum_Dimention;
            if (Dimention > Maximum_Dimention) return Maximum_Dimention;
            return Dimention;
        }


    }
}
