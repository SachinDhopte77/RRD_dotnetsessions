using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleExcerciseEnumandPropertySyntax.Models
{
    internal class Rectangle
    {
        private int _Width;
        private int _Height;

        private int MinimumDimention = 10;
        private int MaximumDimention = 100;
        private ColorOptions _colorOptions;

        public int CalculateArea()
        { return _Width * _Height; }

        public int Width
        {
            get { return _Width; }

            set { _Width = SetCorrectDimention(value); }
        }

        private int SetCorrectDimention(int value)
        {
            if (value < MinimumDimention) { return MinimumDimention; }
            if (value > MaximumDimention) { return MaximumDimention; }
            return value;
        }
        public int Height
        {
            get { return _Height; }
            set { _Height = SetCorrectDimention(value); }
        }

        public ColorOptions Color
        {
            get { return _colorOptions; }
            set { _colorOptions = value; }
        }


    }
}
