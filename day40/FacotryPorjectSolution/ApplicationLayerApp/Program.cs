using AutofacotryCommonLib.Products;

namespace ApplicationLayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var factory = new AutoMobileFactory();
            IAutoMobile auto = factory.Make(AutoType.TESLA);
            auto.Start();
            auto.Stop();
            Console.WriteLine(auto.GetType());

        }
    }
}