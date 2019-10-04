using _12_DesignPattern_Factory.CompanyFactory;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments;
using _12_DesignPattern_Factory.DocumentFactory.AbstractFactory;
using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;
using _12_DesignPattern_Factory.DocumentFactory.ConcreteFactory;
using _12_DesignPattern_Factory.Factory_Design_Pattern.More_Complex_Example.CompanyFactory.Payroll_Systems;
using System;

namespace _12_DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Formatting
            Console.WriteLine();
            Console.WriteLine("----------------------------- Document Factory -----------------------------");
            #endregion

            // Note: constructors call Factory Method
            AbstractDocumentFactory[] documents = new AbstractDocumentFactory[2];

            documents[0] = new ConcreteResumeFactory(); // we create a "resume factory"
            documents[1] = new ConcreteReportFactory(); // we create a "report factory"

            // Display document pages
            foreach (AbstractDocumentFactory document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (AbstractPageProduct page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            #region Formatting
            Console.WriteLine();
            Console.WriteLine(@"----------------------------- Company Factory with ""Payroll"" -----------------------------");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Company[] companies = new Company[2];
            // we create our software company
            companies[0] = new SoftwareCompany("My Software Company", new BasicPayRollSystem());
            companies[1] = new SoftwareCompany("My Awesome Software Company", new AdvancedPayrollSystem());

            foreach (Company company in companies)
            {
                company.DisplayCompanyName();
                // let the company display it's own departments. Each company may choose
                // a different way to display, or use the default "Company" base class to
                // do this.
                company.DisplayCompanyDepartments();

                // Let's pay the employees.
                company.PayEmployees();


                // Just to seperate company informmation being displayed on the console.
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
