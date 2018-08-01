using Visitor.Visitor;

namespace Visitor.Income_Sources
{
    class Share : IIncome
    {
        public int MonthlyTransaction { get; set; }
        public double TaxApplicable { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}
