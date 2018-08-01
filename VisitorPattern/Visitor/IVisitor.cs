using Visitor.Income_Sources;

namespace Visitor.Visitor
{
    interface IVisitor
    {
        void Visit(Share share);
        void Visit(Salary salary);
        void Visit(Training training);
    }
}
