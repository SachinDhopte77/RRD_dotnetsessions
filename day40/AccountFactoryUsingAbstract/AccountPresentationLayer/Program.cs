using AccountFactoryAbstractCommonLib.AccountServices;

namespace AccountPresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BankAccountFactory bankAccountFactory = new BankAccountFactory();
           Account account1=bankAccountFactory.GenerateAccount(AccountType.Saving);
           var diposit= account1.Diposit(2000);
            var withdraw=account1.Withdraw(5000);

            Console.WriteLine($"Balance After Diposit: {diposit} ");
            Console.WriteLine($"Balance After withdraw: {withdraw} ");
        }
    }
}

//Factory method is a creational design pattern which solves the problem of creating product objects without
//specifying their concrete classes.
//Identification: Factory methods can be recognized by creation methods that construct objects from
//concrete classes. While concrete classes are used during the object creation, the return type of the
//factory methods is usually declared as either an abstract class or an interface.
//The Factory Method Pattern is a creational design pattern that defines an interface for creating an object
//but lets subclasses decide which class to instantiate. The Factory Method allows a class to defer
//instantiation to subclasses, promoting loose coupling and greater flexibility.
