using System.Collections.Generic;
using Visitor.Income_Sources;
using Visitor.Visitor;

namespace Visitor
{
    class SoftwareEngineer
    {
       public List<IIncome> Incomes = new List<IIncome>();

        public void Accept(IVisitor visitor)
        {
            foreach (var income in Incomes)
            {
                income.Accept(visitor);
            }
        }
    }
}
