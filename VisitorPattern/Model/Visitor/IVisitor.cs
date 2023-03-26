using VisitorPattern.Model.Aggrigates;

namespace VisitorPattern.Model.Visitor
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(BankAccount bankAccount);
        void Accept(RealState realState);
    }
}
