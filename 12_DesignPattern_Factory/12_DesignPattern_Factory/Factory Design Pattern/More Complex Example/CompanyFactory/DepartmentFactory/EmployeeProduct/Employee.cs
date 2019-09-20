using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments;
using System;
using System.Collections.Generic;
using System.Text;

namespace _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct
{

    /// <summary>
    /// This is an enumerator that we will use to calculate Salary within the Payroll Class
    /// We could do this in the Employee class, however, this is just a Model class and should not have much if any logic inside of it.
    /// 
    /// Since the Payroll department is responsible for paying people, this should be calcuated in Payroll.
    /// 
    /// We will use the "Company.Department.Employees" to send to Payroll to "Pay people based on the date"
    /// 
    /// We will have this method done every day, and based on "when they got paid last" we will either send them money, or not.
    /// </summary>
    public enum SalaryInterval
    {
        Weekly,
        BiWeekly,
        Monthly,
        Yearly
    }


    /// <summary>
    /// The Employee Class. This should have very little logic inside of it. The "Employee" is simply a Model Class
    /// 
    /// We could also have this be a "factory" and have something like "CreateSkills" inside of this to allow for
    /// multiple "Employee Types", however, as we are only going to do "2 levels" of factories, this will be our final
    /// product for the "Department" factory.
    /// </summary>
    public class Employee
    {

        /// <summary>
        /// Constructor for the employee.  This we send all the "necessary" information.
        /// 
        /// In the real world we would also have methods for adding Addresses, Family Members, Insurance, etc... 
        /// 
        /// Classes can become complex, and this is why we use Factories to create things. This allows us to create
        /// very complex objects with little steps and allows each of the steps do handle creating itself.  This means
        /// that the bigger (higher level) classes do not have to worry about "HOW" this is done, because the higher
        /// level classes should not have to worry about this. They have their own responsibilies.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="department"></param>
        /// <param name="salary"></param>
        /// <param name="salaryInterval"></param>
        public Employee(string firstName, string lastName, Department department, double salary, SalaryInterval salaryInterval)
        {

            // a GUID or Guid is a randomly generated "alphanumeric" code that will be unique.  There is less than
            // 1 in 6 billion chance for the same Guid to be generated in any given program execution.
            // This means that it's very good to be used as an ID number, since it will be unique.
            this._employeeID = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = salary;
            SalaryInterval = salaryInterval;
        }

        private Guid _employeeID;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
        public double Salary { get; set; }
        public double AdjustedSalary { get; set; }
        public SalaryInterval SalaryInterval { get; set; }
    }
}
