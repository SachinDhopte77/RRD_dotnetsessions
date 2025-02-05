using Read_CSV_and_GroupingOperation.Models;

namespace Read_CSV_and_GroupingOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\RRD_Training\CSharpDotNET\day37\Data\emp_duplicate.csv";
            EmployeeFileRead readEmployeefile = new EmployeeFileRead();
            var uniqueEmployeeList = readEmployeefile.ReadFromCSVFile(filePath);

            // PrintUniqueEmployeeList(uniqueEmployeeList);

            JobWiseEmployeeSummarry(uniqueEmployeeList);

        }

        private static void JobWiseEmployeeSummarry(HashSet<Employee> uniqueEmployeeList)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (var employee in uniqueEmployeeList)
            {
                if (!map.ContainsKey(employee.EmployeeJob))
                    map.Add(employee.EmployeeJob, 1);
                else
                    map[employee.EmployeeJob] = map[employee.EmployeeJob] + 1;
            }
            int totalEmployeeCount = 0;
            foreach (var key in map.Keys)
            {
                Console.Write($"Job Name : {key} || Employee Count : {map[key]}" + "\n");
                totalEmployeeCount += map[key];
            }
            Console.WriteLine("Total Employee Count :" + totalEmployeeCount);
        }

        private static void PrintUniqueEmployeeList(HashSet<Employee> uniqueEmployeeList)
        {
            foreach (var item in uniqueEmployeeList)
            {
                Console.WriteLine(item.EmpNo);
            }
        }
    }
}
