using EngineeringApp.LowLevel;
using EngineeringCommonLib.HighLevel;
using EngineeringCommonLib.Models;

namespace EngineeringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EngineeringCollage collageStudent = new EngineeringCollage(1001, "Ratnagiri", "15/10/2015");
            PrintStudentDetail(collageStudent);

            EngineeringCollage collageProfessor = new EngineeringCollage(5001, "Mumbai", "10/12/1983");
            PrintProfessorDetail(collageProfessor);

        }

        private static void PrintStudentDetail(EngineeringCollage collageStudent)
        {
            Students student = new Students(700, 565, CollageBranchList.Mumbai);
            Console.WriteLine($"Student ID : {collageStudent.Id} Address: {collageStudent.Address} DOB: {collageStudent.Date} Branch : {student.CollageBranchList}");
            Console.WriteLine($"Mark Obtained in Exam : {student.TotalPercentageObtained()}");
        }

        private static void PrintProfessorDetail(EngineeringCollage collageProfessor)
        {

            Console.WriteLine($"Student ID : {collageProfessor.Id} Address: {collageProfessor.Address} DOB: {collageProfessor.Date} ");
            Professor professor = new Professor(50000, 25000, 12000);
            Console.WriteLine($"Salary of Professor : {professor.SalaryCalculation()}");
        }
    }
}
