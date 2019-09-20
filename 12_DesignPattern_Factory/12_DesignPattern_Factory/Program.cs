using _12_DesignPattern_Factory.CompanyFactory;
using _12_DesignPattern_Factory.CompanyFactory.DepartmentFactory.Departments;
using _12_DesignPattern_Factory.DocumentFactory.AbstractFactory;
using _12_DesignPattern_Factory.DocumentFactory.AbstractProduct;
using _12_DesignPattern_Factory.DocumentFactory.ConcreteFactory;
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

            documents[0] = new ConcreteResumeFactory();
            documents[1] = new ConcreteReportFactory();

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

            Company[] companies = new Company[1];
            companies[0] = new SoftwareCompany("My Awesome Software Company", new PayRollSystem());

            foreach (Company company in companies)
            {
                Console.WriteLine($"Company Name: {company.CompanyName}");
                foreach (Department department in company.Departments)
                {
                    Console.WriteLine($"    Department: {department.DepartmentName}");
                }
                Console.WriteLine();

                Console.WriteLine("Let's pay our employees");
                Console.WriteLine();
                company.PayEmployees();
            }
        }
    }
}
