using CircleAbstractionApp.Models;

namespace CircleAbstractionApp
{
    internal class CircleTest
    {
        static void Main()
        {

            Circle circle = new Circle();
            circle.pi = 3.14f;
            Console.WriteLine("Enter a radius of circle to calculate area:");
            circle.radius = Single.Parse(Console.ReadLine());
            Console.WriteLine($"area of Circle of radius {circle.radius} is {circle.CalculateCircleArea()} ");


        }

    }
}
