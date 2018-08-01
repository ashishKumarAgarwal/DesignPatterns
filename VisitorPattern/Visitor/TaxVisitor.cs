using Visitor.Income_Sources;

namespace Visitor.Visitor
{
    class TaxVisitor : IVisitor
    {
        public double Tax { get; set; }
        public void Visit(Share share)
        {
            Tax += share.MonthlyTransaction * share.TaxApplicable;
        }

        public void Visit(Salary salary)
        {
            Tax += salary.MonthlySalary * salary.TaxApplicable;

        }

        public void Visit(Training training)
        {
            Tax += training.MonthlySalary * training.TaxApplicable;

        }
    }
}
