using _12_DesignPattern_Factory.CompanyFactory;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.EmployeeProduct;
using _12_DesignPattern_Factory.Factory_Design_Pattern.More_Complex_Example.CompanyFactory.Payroll_Systems;
using System;
using System.Collections.Generic;

/// <summary>
/// Abstract company class
/// This will be the base class for different TYPES of companies

/// Fill this out to ensure that there is a Constructor that
///     calls an abstract "Factory Method"
///     
/// At first we will only create one method. "CreateDepartments()"
/// 
/// However, as our company "factory" becomes more complex, we can add additional
/// functionality to the foundation of "CreateDepartment()" method and also have
/// it create employees.
/// 
/// However, this now creates the problem of breaking SOLID principles. What we want to do is
/// actually use additional "factories" to create departments, create employees.
/// 
/// Let's break down the functionality of a company.
/// 
///     1. A Company has:
///         a. Name (or Aliases)
///         b. A Company Logo
///         c. Perhaps company nicknames (this may or may not be important in the creation of the class
///                                       and will depend on the client needs and the software needs.)
///         d. A headquarter location
///         e. Possibly additional locations (Not all companies have multiple locations, but we must account
///                                           for those that do. Therefore creating a company that does not allow
///                                           this would break the concept of future use of the code. This is an
///                                           important concept and should always be taken into consideration when
///                                           creating classes.)
///         f. Departments
///         g. Employees
///         h. Clients
///     2. Departments have:
///         a. Employees (Not all employees will be the same type and this is important to understand and why
///                       we try and use "Generics" and Polymorphism.)
///         b. Locations within the buildings
///         c. 
///     2. When a company in the real world is created, 
/// </summary>
public abstract class Company
{
    // This is the "payroll" system for this company.  Notice that we are telling the company what kind of payroll system to use
    // when we create the company. Notice also this is an interface (IPayrollSystem) and not a concrete class.  This way, when we
    // use dependency injection, we can change the payroll system without changing the company class. (For now, we are sending a
    // concrete payroll system to the constructor. However, later we will allow dependency injection to do this, and we will not
    // have to send a specfic payroll system when we create the company.
    internal IPayrollSystem _payroll;


    // obviously all companies have a company name.
    internal string _companyName;
    public string CompanyName { get { return _companyName; }}

    // We would also create all the other propertie of a company here and set them in the constructor. Some we will make properties that are
    // set after we create the company. Things that change(or are allowed to change) are set with properties. Things like the company logo (which
    // can change over time) is usually set with properties and not with the constructor.

    // This is our internal departments field. This will be used internally in this class only and should never be passed or
    // given to anything outside of this class. The "private" keyword will ensure this does not happen.
    internal List<Department> _departments;

    public Company(string companyName, IPayrollSystem payrollSystem)
    {
        this._companyName = companyName;
        this._payroll = payrollSystem;
        this._departments = new List<Department>();

        // This is the constructor of the asbstract base class calling the factory method
        // This is ALWAYS neccessary in a factory pattern and what makes it a factory pattern.
        this.CreateDepartments();
    }


    /// <summary>
    /// With this method we are "ASSUMING" that all companies will have a Payroll and HumanResources department.
    /// 
    /// This may or may not be the case. This will depend on the client that wants the software built. We always need to consider
    /// that software is based on the needs of the client. If the client says... I need a web site that manages companies, and ALL companies
    /// will have a Payroll and Human Resources department. This is the best way to code the requirements. However, if this is not stated,
    /// then we would NOT put this here and allow for each "Concrete" company to determine if Payroll and Human Resources are a part of it.
    /// 
    /// This is similiar to the other example where the "document" class did not add any pages, but the "resume" and "report" concrete classed
    /// did ALL of the work.  THIS IS ALWAYS DEPENDENT ON THE NEEDS OF THE CLIENT ASKING FOR THE SOFTWARE.  Just be aware that there
    /// are many ways we can create factories. Some always do certain actions, sometimes they do nothing at all.
    /// </summary>
    public virtual void CreateDepartments()
    {
        _departments.Add(new Payroll());
        _departments.Add(new HumanResources());
    }

    public virtual void DisplayCompanyName()
    {
        Console.WriteLine($"Company Name: {this.CompanyName}");
    }

    public virtual void DisplayCompanyDepartments()
    {
        foreach (Department department in _departments)
        {
            Console.WriteLine($"    Department: {department.DepartmentName}");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Remember, ALL companies pay their employees.  We created this company with a specific "payroll system" that will handle HOW the employees are paid
    /// but, it's the companies job to tell the payroll system to pay the companies. IN THIS CASE. Sometimes we may want to just "register" the company with
    /// a payroll system, and then the payroll system will determine everything else. Again, this is all based on what the company asking for the software wants.
    /// 
    /// There are an infinite number of ways to build software!!!!!!!!!!!!
    /// 
    /// This is a good example of a system that can be VERY complicated on the inside, but to "use" or "consume" the
    /// system, it is very easy.  It is even easier in the real world because the company would not send the employee to the
    /// system, but the payroll system would get the information from a secured database.  This could make this method as simple
    /// as: 
    /// 
    /// _payroll.PayEmployees();
    /// 
    /// 
    /// </summary>
    internal void PayEmployees()
    {
        Console.WriteLine("Let's pay our employees");
        Console.WriteLine();
        foreach (Department department in this._departments)
        {
            foreach (Employee employee in department.Employees)
            {
                _payroll.PayEmployees(employee);
            }
        }
    }
}