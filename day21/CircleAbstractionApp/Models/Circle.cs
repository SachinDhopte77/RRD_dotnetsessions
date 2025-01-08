
namespace CircleAbstractionApp.Models
{
    class Circle
    {
        public float radius;
        public float pi;

        public float CalculateCircleArea()
        {
            return pi * radius * radius;
        }
    }

}
