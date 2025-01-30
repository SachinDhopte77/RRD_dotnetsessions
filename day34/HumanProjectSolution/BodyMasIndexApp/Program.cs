using System.Collections;
using HumanCommanLib.Exceptions;
using HumanCommanLib.Models;

namespace BodyMasIndexApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var dataBMI = new ArrayList();
            dataBMI.Add(new Human("sachin", 40, 1.70, 65, "Male"));
            dataBMI.Add(new Human("minu", 25, 1.60, 45, "Female"));
            dataBMI.Add(new Human("puja", 13, 1.05, 25, "Female"));           
            

            //Check All method working and Exceptions
             PrintDetailsAfterMethodExcecution(dataBMI);
            
            // Print Body Mass Index and Body Structure
             SummarryofPhysicalFitness(dataBMI);

            //Check Exception working
            
            //Human human1 = new Human("puja", 13, 1.05, 35, "Female");
            //try
            //{
            //    human1.Workout();
            //}
            //catch (Notallowedtoworkout notAllowedex)
            //{
            //    Console.WriteLine(notAllowedex.Message);
            //}


            Console.WriteLine("Exceution End here!!");


        }

        private static void PrintDetailsAfterMethodExcecution(ArrayList arrayList)
        {
            foreach (var item in arrayList) 
            {
               Human human=(Human)item;
                try
                {
                   human.Workout();
                }
                catch (Notallowedtoworkout notallowedworkout)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(notallowedworkout.Message);
                    Console.ResetColor();
                    break;
                }
               Console.WriteLine($"Name : {human.Name} Weight : {human.Weight} Height : {human.Height}");
               human.Eat();
               Console.WriteLine($"Name : {human.Name} Weight after Eat : {human.Weight} Height : {human.Height}");
               human.Workout();
               Console.WriteLine($"Name : {human.Name} Weight after Workout : {human.Weight} Height after Workout : {human.Height}");

            }
            Console.WriteLine("Print Detail Completed");
        }

        private static void SummarryofPhysicalFitness(ArrayList arrayList) // Check Body Mass Index and Body Structure Detail
        {
           Console.WriteLine("////Summary of Physical Fitness");
            foreach(var item in arrayList)
            {
                Human human = (Human)item;
                if(human.Age>14)
                Console.WriteLine($"Name is {human.Name} : Age is {human.Age} : Body Mass Index is {human.CalculateBMI()} : Body Structure is {human.GetBodyStructure()}");
            }
        }
    } 
}
