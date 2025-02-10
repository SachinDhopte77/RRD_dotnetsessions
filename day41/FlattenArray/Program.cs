using FlattenArray.Models;

namespace FlattenArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[,,] array3D = new string[,,] {
            { { "a" }, { "b" }, {"c"} } };

            CutumeArray<string> cutumeArray = new CutumeArray<string>();
           
            string[] array1D = CutumeArray<string>.Flatten(array3D);
           
                      
            foreach (var item in array1D)
            {  Console.WriteLine(item); }


            //Convert Object to Array type
            var stringArray = new string[,] { { "a" }, { "b" }, { "C" } };
            string[] flat = stringArray.Cast<string>().ToArray(); 
            Console.WriteLine("[{0}]", string.Join(", ", flat));

        }

        
    }
}
