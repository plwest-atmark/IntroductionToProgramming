using System;
using System.Collections.Generic;
using System.Text;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;

namespace _12_DesignPattern_Factory.Factory_Design_Pattern.More_Complex_Example.CompanyFactory.Payroll_Systems
{
    class AdvancedPayrollSystem : IPayrollSystem
    {
        public void AdjustSalary(Employee employee)
        {
            // the advance payroll system will multiply everyone's salary by 100
            employee.AdjustedSalary = (employee.Salary * 100);
        }

        public void PayEmployees(Employee employee)
        {
            // we need to allow for every employee to have an "adjustment" to their pay based on some database information.
            AdjustSalary(employee);
            // get the payroll department from the company (THIS MIGHT BE HUMAN RESOURCES IN SOME COMPANIES, but we have to "fake" out the program and use payroll class)
            // basically, even if a company calls their payroll Human Resources, we need to use the payroll we created to actually pay people.

            // This is where we would use the properties of employee.Salary and employee.SalaryInterval to
            // calculate how much we need to pay, and depending on the date and when they were paid last.. 
            // IF we should pay them or not.
            if (EmployeeShouldBePaidToday(employee))
            {
                var salary = CalculateSalaryToBePaid(employee);
                Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} as paid {salary}. Their normal salary is {employee.Salary}");
            }

        }

        private bool EmployeeShouldBePaidToday(Employee employee)
        {
            // this is where we determine if the employee should be paid

            return true;  // let's just say everyone will be paid instead of creating an algorithm here.
        }

        private double CalculateSalaryToBePaid(Employee employee)
        {
            // this is where the salary will be calculated
            // We use the conditional if statement in this case.
            // In the real world, we would probably have all of this information inside a database so the "logic"
            // does not have to be used.
            if (employee.AdjustedSalary != 0)
                return employee.AdjustedSalary; // let's say everyone will be paid their max salary. (i.e. PAYDAY!!!)
            else
                return employee.Salary;
        }

    }
}
