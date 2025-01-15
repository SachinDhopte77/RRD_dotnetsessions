using RectangleExcerciseEnumandPropertySyntax.Models;

namespace RectangleExcerciseEnumandPropertySyntax
{
    internal class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Width = 15;
            rectangle1.Height = 25;
            rectangle1.Color = ColorOptions.blue;

            Rectangle rectangle2 = new Rectangle();
            rectangle2.Width = 5;
            rectangle2.Height = 255;
            rectangle2.Color = ColorOptions.green;

            Rectangle[] rectangles = { rectangle1, rectangle2 };

            PrintAllRectangleDetail(rectangles);

            PrintBiggestRectangleByArea(rectangles);

        }

        private static void PrintAllRectangleDetail(Rectangle[] rectangles)
        {
            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine($"Width of Rectangle : {i + 1} is :{rectangles[i].Width}");
                Console.WriteLine($"Height of Rectangle : {i + 1} is : {rectangles[i].Height}");
                Console.WriteLine($"Color of Rectangle : {i + 1} is : {rectangles[i].Color}");
                Console.WriteLine($"Area of Rectangle : {i + 1} is : {rectangles[i].CalculateArea()}");
            }
        }

        private static void PrintBiggestRectangleByArea(Rectangle[] rectangles)
        {
            int BiggestRectangleArea = 0;
            int BiggestRectangleIndex = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].CalculateArea() > BiggestRectangleArea)
                {
                    BiggestRectangleArea = rectangles[i].CalculateArea();
                    BiggestRectangleIndex = i + 1;
                }
            }
            Console.WriteLine("Biggest Rectangle at array position {0} and area of Rectangle is {1}", BiggestRectangleIndex, BiggestRectangleArea);
        }
    }
}
