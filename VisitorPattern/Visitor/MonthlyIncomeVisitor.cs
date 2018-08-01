using Visitor.Income_Sources;

namespace Visitor.Visitor
{
    class MonthlyIncomeVisitor : IVisitor
    {
        public int MonthlyIncome { get; set; }
        public void Visit(Share share)
        {
            MonthlyIncome += share.MonthlyTransaction;
        }

        public void Visit(Salary salary)
        {
            MonthlyIncome += salary.MonthlySalary;

        }

        public void Visit(Training training)
        {
            MonthlyIncome += training.MonthlySalary;

        }
    }
}
