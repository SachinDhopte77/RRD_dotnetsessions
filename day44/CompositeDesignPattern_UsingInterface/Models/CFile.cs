using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern_UsingInterface.Models
{
    public class CFile : ITreeStructure
    {
        private string _name;

        public CFile(string name)
        {
            _name = name;
        }

        public void ShowDetails()
        {
            if (_name == "Folder2File3.txt")
            {
                Console.WriteLine($"  -------|------File: {_name}");
            }
            else if(_name== "Folder3File4.txt" || _name== "Folder3File5.txt")
            {
                Console.WriteLine($"  -------|------File: {_name}");
            }
            else { Console.WriteLine($"  -------|--File: {_name}"); }
           
        }

       
    }
}
