using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class PayrollSystemTest
    {
        public static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444 - 44 - 4444", 5000.00M, .04M, 300.00M );

            Console.WriteLine("Employees processed individually:\n");
            
            Console.WriteLine("{0}\nearned: {1:C}\n", salariedEmployee, salariedEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", hourlyEmployee, hourlyEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", commissionEmployee, commissionEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", basePlusCommissionEmployee, basePlusCommissionEmployee.Earnings());

            Employee[] employees = new Employee[4];

            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;

            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                if(currentEmployee is BasePlusCommissionEmployee)
                {
                    BasePlusCommissionEmployee employee = (BasePlusCommissionEmployee)currentEmployee;
                    employee.BaseSalary *= 1.10M;

                    Console.WriteLine("new base salary with 10% increase is: {0:C}", employee.BaseSalary);
                }
                
                Console.WriteLine( "earned {0:C}\n", currentEmployee.Earnings());
            }

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine("{0}\nearned: {1:C}\n", salariedEmployee, salariedEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", hourlyEmployee, hourlyEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", commissionEmployee, commissionEmployee.Earnings());
            Console.WriteLine("{0}\nearned: {1:C}\n", basePlusCommissionEmployee, basePlusCommissionEmployee.Earnings());
        }
    }
}
