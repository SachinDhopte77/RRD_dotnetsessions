using InterfaceExcercise.Models;
using System.Reflection;

namespace InterfaceExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();

            AttheParty(man);
            //AttheParty(boy);// Error: Boy class inherited from IEmotionable interface so boy should not be passed as a Imannarable interface  object
            //AttheMovie(man);// Error  Man class inherited from Imannarable interface so boy should not be passed as a IEmotionable interface  object 
            AttheMovie(boy);


            var arrayofImannarable = new[] { typeof(IMannarable) };
            PrintInterfaceDetail(arrayofImannarable);

        }

        private static void PrintInterfaceDetail(Type[] arrayofImannarable)
        {
            for (int i = 0; i < arrayofImannarable.Length; i++)
            {
                for (int j = 0; j < arrayofImannarable[i].GetMembers().Length; j++)
                {
                    Console.WriteLine($"Interface Name : {arrayofImannarable[i].Name} :Member Methods is {arrayofImannarable[i].GetMembers()[j]}");
                }

            }
        }


        private static void AttheMovie(IEmotionable obj)
        {
            obj.Cry();
            obj.Laugh();
        }

        private static void AttheParty(IMannarable obj)
        {
            obj.Wish();
            obj.Depart();
        }


    }
}



