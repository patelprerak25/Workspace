using System;
using EmployeeDAL;
using EmpolyeeBAL;

namespace TryDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee objEmp = new EmpolyeeBAL.Employee();
            objEmp.FirstName = "Prerak";
            objEmp.LastName = "Patel";
            objEmp.BirthDate = DateTime.Now;
            objEmp.Email = "patelprerak@gmail.com";

            EmployeeADO objEmpADO = new EmployeeADO();
            objEmpADO.Add(objEmp);

            Console.WriteLine("Hello World!");

        }
    }
}
