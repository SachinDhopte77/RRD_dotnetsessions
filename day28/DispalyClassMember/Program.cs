using DispalyClassMember.Models;

using System.Reflection;

namespace DispalyClassMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var member = typeof(Employee);
           
            DoRelfection(member);

        }

        private static void DoRelfection(Type member)
        {
            for (int i = 0; i < member.GetMembers().Length; i++)
            {
                Console.WriteLine($"Class {member.Name} : MemberType {member.GetMembers()[i].MemberType}: Member Name is {member.GetMembers()[i].Name}");
            }
        }

   
    }
}
