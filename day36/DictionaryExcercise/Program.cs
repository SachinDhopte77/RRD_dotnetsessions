namespace DictionaryExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> employeeList = new Dictionary<string, string>();
            employeeList.Add("Sachin", "Mumbai");
            employeeList.Add("Akhilesh", "Chennai");
            employeeList.Add("Perm", "Chennai");
            employeeList.Add("Nitin", "Kerala");
            employeeList.Add("Sachin H", "Mumbai");
            employeeList.Add("Venkat", "Chennai");

            var citywiseEmployeelist = GetCitywiseGroupingofEmployee(employeeList);

            PrintCitywiseEmployeeList(citywiseEmployeelist);

        }

        private static Dictionary<string, List<string>> GetCitywiseGroupingofEmployee(Dictionary<string, string> employeeList)
        {
            Dictionary<string, List<string>> citywiseEmployeelist = new Dictionary<string, List<string>>();
            var enumerator = employeeList.GetEnumerator(); //GetEnumerator Method is used to returns an IEnumerator object that iterates through the List<T> /Collection
            while (enumerator.MoveNext())
            {
                var employee = enumerator.Current;
                if (!citywiseEmployeelist.ContainsKey(employee.Value))
                    citywiseEmployeelist[employee.Value] = new List<string>();
                citywiseEmployeelist[employee.Value].Add(employee.Key);
            }
            return citywiseEmployeelist;
        }

        private static void PrintCitywiseEmployeeList(Dictionary<string, List<string>> citywiseEmployeelist)
        {
            foreach (var city in citywiseEmployeelist)
            {
                foreach (var employee in city.Value)
                {
                    Console.WriteLine($"City : {city.Key} || Employee Name : {employee}");
                }
            }
        }
    }
}
