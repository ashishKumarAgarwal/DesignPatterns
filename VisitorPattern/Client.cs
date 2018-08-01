using System;
using Visitor.Income_Sources;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareEngineer se = new SoftwareEngineer();

            se.Incomes.Add(new Salary
            {
                MonthlySalary = 70000,
                TaxApplicable = 0.10
            });
            se.Incomes.Add(new Share
            {
                MonthlyTransaction = 5000,
                TaxApplicable = 0.20
            });
            se.Incomes.Add(new Training
            {
                MonthlySalary = 30000,
                TaxApplicable = 0.15
            });

            MonthlyIncomeVisitor monthlyIncomeVisitor = new MonthlyIncomeVisitor();
            se.Accept(monthlyIncomeVisitor);

       
            Console.WriteLine("Monthly Income of Software Engineer is {0}", monthlyIncomeVisitor.MonthlyIncome);

            TaxVisitor taxVisitor = new TaxVisitor();
            se.Accept(taxVisitor);
            Console.WriteLine("Tax applicable is {0}", taxVisitor.Tax);

        }
    }
}
