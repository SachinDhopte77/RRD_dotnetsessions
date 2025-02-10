
namespace Delegate_MathOperator
{
    delegate double MathOperator(double x, double y);

    internal class Program
    {
        static void Main(string[] args)
        {

            CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
          
            
            double reminderResult= Modulus((a,b) => a%b);
            Console.WriteLine($"Reminder result of " + reminderResult);
        }


        private static void CaseStudy1()
        {
            MathOperator plusOperation = Addition;
            Console.WriteLine("Addition Result is :"+ plusOperation(10, 5));
            MathOperator minusOperation = Subtraction;
            Console.WriteLine("Subtraction Result is :" + minusOperation(10, 5));
            MathOperator multiplicationOps = Multiplication;
            Console.WriteLine("Subtraction Result is :" + multiplicationOps(10, 5));

        }

        static  double Modulus(MathOperator fnCallBack)
        {
           return fnCallBack(16,3);
        }

        static double Addition(double x, double y)
        { 
          return x + y;
        }
        static double Subtraction(double x, double y)
        {
            return x - y;
        }
        static double Multiplication(double x, double y)
        {
            return x * y;
        }
    }
}
