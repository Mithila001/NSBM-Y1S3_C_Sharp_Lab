using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_14__Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 10000;
            Employee emp1 = new Employee(101,"John Doe", salary);

            /*Console.WriteLine("ID:"+emp1.employeeID);
            Console.WriteLine("FUll name:"+emp1.fUllName);
            Console.WriteLine("Salary:"+emp1.salary);*/
            emp1.displayEmployeeInfo();
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int employeeID { get; set; }
        public string fUllName { get; set; }
        public double salary;

        public Employee(int employeeID, string fUllName, double salary)
        {
            this.employeeID = employeeID;
            this.fUllName = fUllName;
            this.salary = salary;
        }

        void employee()
        {

        }

        public void displayEmployeeInfo()
        {
            Console.WriteLine("ID:" + employeeID);
            Console.WriteLine("FUll Name:" + fUllName);
            Console.WriteLine("Salary:" + salary);

        }
    }
}
