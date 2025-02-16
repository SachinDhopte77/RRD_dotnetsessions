using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern_UsingInterface.Models
{
    public class Folder : ITreeStructure
    {
        private string _name;
        private List<ITreeStructure> _components = new List<ITreeStructure>();

        public Folder(string name)
        {
            _name = name;
        }

        public void AddComponent(ITreeStructure component)
        {
            _components.Add(component);
        }       

        public void ShowDetails()
        {
            if(_name== "Folder2")
            { Console.WriteLine($"---------|--Folder: {_name}"); }
            else if(_name== "Folder3")
            { Console.WriteLine($"  -------|--Folder--: {_name}"); }
            else { Console.WriteLine($"Root--: {_name}"); }
            
            foreach (var component in _components)
            {
                component.ShowDetails();
            }


        }        

      
    }
}
