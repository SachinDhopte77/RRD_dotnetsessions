namespace FileCreateWriteExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\lIvesessionkoenig\RRD\C#.Net\DataFile\Leraning.txt";
            FileInfo fileInfo = new FileInfo(fileName);

            try
            {
                // Check if file already exists. If yes, delete it.
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }

                // Create and update a new file
                using (StreamWriter sw = fileInfo.CreateText())
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    Console.WriteLine("Please Enter a Name :");
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("Please Enter a Address :");
                    sw.WriteLine(Console.ReadLine());
                }

                // Read Content from file
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)//System error 
            {
                Console.WriteLine(Ex.ToString());
            }

        }
    }
}
