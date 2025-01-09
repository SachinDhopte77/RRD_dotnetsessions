using RectangelEncapsulationExcercise.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RectangelEncapsulationExcercise
{
    internal class RectangleTest
    {
        static void Main()
        {


            Rectangle rectangle1 = new Rectangle();
            rectangle1.SetWidth(9);
            rectangle1.SetHeight(20);


            Rectangle rectangle2 = new Rectangle();
            rectangle2.SetWidth(25);
            rectangle2.SetHeight(150);


            Rectangle rectangle3 = new Rectangle();
            rectangle3.SetWidth(5);
            rectangle3.SetHeight(98);


            Rectangle rectangle4 = new Rectangle();
            rectangle4.SetWidth(25);
            rectangle4.SetHeight(75);


            Rectangle[] rectangles = { rectangle1, rectangle2, rectangle3, rectangle4 };


            BiggestRectangle(rectangles);

        }

        private static void BiggestRectangle(Rectangle[] rectangles)
        {
            int[][] AreaRec;
            AreaRec = new int[rectangles.Length][];
            for (int i = 0; i < rectangles.Length; i++)
            {
                AreaRec[i] = [rectangles[i].CalculateArea(), i + 1];
            }
            var SortRectanglebyArea = AreaRec.OrderByDescending(y => y[0]);

            PrintRectangleArray(SortRectanglebyArea);

        }

        private static void PrintRectangleArray(IOrderedEnumerable<int[]> sortRectanglebyArea)
        {
            var results = string.Join(Environment.NewLine, sortRectanglebyArea.Select(x => string.Join(" Area of rectangle of rectangle No : ", x)));
            Console.WriteLine(results);

        }
    }
}
