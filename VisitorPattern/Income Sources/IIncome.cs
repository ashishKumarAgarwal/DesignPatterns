using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor;

namespace Visitor.Income_Sources
{
    interface IIncome
    {
        void Accept(IVisitor visitor);
    }
}
