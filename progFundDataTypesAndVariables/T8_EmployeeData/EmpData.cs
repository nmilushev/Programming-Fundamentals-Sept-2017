using System;

namespace T8_EmployeeData
{
    class EmpData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            double id = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}\r\n" +
                              $"Last name: {lastName}\r\n" +
                              $"Age: {age}\r\n" +
                              $"Gender: {gender}\r\n" +
                              $"Personal ID: {id}\r\n" +
                              $"Unique Employee number: {employeeNumber}");
        }
    }
}
