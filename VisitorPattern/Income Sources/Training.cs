using Visitor.Visitor;

namespace Visitor.Income_Sources
{
    class Training : IIncome
    {
        public int MonthlySalary { get; set; }
        public double TaxApplicable { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}
