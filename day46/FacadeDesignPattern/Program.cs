using FacadeDesignPattern.Models;

namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Client will use the Facade Interface instead of the Subsystems
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
/*
 *The Facade Design Pattern is a structural pattern that provides a simplified interface to a complex system
 *of classes, libraries, or frameworks. The primary goal of the Facade pattern is to present a clear, 
 *simplified, and minimized interface to the external clients while delegating all the complex underlying
 *operations to the appropriate classes within the system. The Facade (usually a wrapper) class sits on 
 *the top of a group of subsystems and allows them to communicate in a unified manner.

Example : As the name suggests, Facade means the Face of the Building. Suppose you created one building. 
The people walking outside the building can only see the walls and glass of the Building. 
The People do not know anything about the wiring, the pipes, the interiors, 
and other complexities inside the building. That means the Facade hides all the complexities of the 
building and displays a friendly face to people walking outside the building.
*/