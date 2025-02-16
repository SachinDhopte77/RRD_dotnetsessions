using CompositeDesignPattern_UsingInterface.Models;

namespace CompositeDesignPattern_UsingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITreeStructure file1 = new CFile("Folder1File1.txt");
            ITreeStructure file2 = new CFile("Folder1File2.txt");
            ITreeStructure file3 = new CFile("Folder2File3.txt");
            ITreeStructure file4 = new CFile("Folder3File4.txt");
            ITreeStructure file5 = new CFile("Folder3File5.txt");

            Folder folder1 = new Folder("Folder1");
            Folder folder2 = new Folder("Folder2");
            Folder folder3 = new Folder("Folder3");

            folder1.AddComponent(file1);
            folder1.AddComponent(file2);
            folder1.AddComponent(folder2);
            folder2.AddComponent(file3);
            folder1.AddComponent(folder3);
            folder3.AddComponent(file4);
            folder3.AddComponent(file5);
                   

            Console.WriteLine("Folder structure:");
          
            folder1.ShowDetails();

           
        }

       
    }
}
