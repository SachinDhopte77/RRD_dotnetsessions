using Attrubute_Custume.Models;
using Attrubute_Custume.Models;

namespace AttributeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var methods = AppDomain.CurrentDomain.GetAssemblies() // Returns all currenlty loaded assemblies
           .SelectMany(x => x.GetTypes()) // returns all types defined in this assemblies
           .Where(x => x.IsClass) // only yields classes
           .SelectMany(x => x.GetMethods()) // returns all methods defined in those classes
           .Where(x => x.GetCustomAttributes(typeof(ActiveAttribute), false).FirstOrDefault() != null); // returns only methods that have the InvokeAttribute

            foreach (var method in methods) // iterate through all found methods
            {
                var obj = Activator.CreateInstance(method.DeclaringType); // Instantiate the class
                method.Invoke(obj, null); // invoke the method
            }
        }
    }
}

/*Attributes provide a powerful method of associating metadata, or declarative information,
 with code (assemblies, types, methods, properties, and so forth). After an attribute is
 associated with a program entity, the attribute can be queried at run time by using
 a technique called reflection.
 Attributes add metadata to your program. All .NET assemblies contain a specified set of metadata
 that describes the types and type members defined in the assembly.
 You can add custom attributes to specify any additional information that is required.
 Attributes can accept arguments in the same way as methods and properties.
 You can apply one or more attributes to entire assemblies, modules, or smaller program elements such as classes and properties.
 Your program can examine its own metadata or the metadata in other programs by using reflection.
 *Reflection *
 Reflection provides objects (of type Type) that describe assemblies, modules, and types.
 You can use reflection to dynamically create an instance of a type, bind the type to an existing object,
 or get the type from an existing object and invoke its methods or access its fields and properties.
 If you're using attributes in your code, reflection enables you to access them. 
 *Uses :*
 Marking methods using the WebMethod attribute in Web services to indicate that the method should be callable over the SOAP protocol. 
 Describing how to marshal method parameters when interoperating with native code. 
 Describing the COM properties for classes, methods, and interfaces.
 // COM properties" refers to properties within a class that are designed to interact with a
 Component Object Model (COM) object, allowing your C# code to access and manipulate data
 from external COM components through a well-defined interface,
 essentially providing a way to "talk" to COM objects using familiar C# syntax. */
