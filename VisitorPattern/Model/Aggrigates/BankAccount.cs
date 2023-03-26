using VisitorPattern.Model.Visitor;

namespace VisitorPattern.Model.Aggrigates
{
    public class BankAccount : Asset
    {
        public long Balance { get; set; }
        public long Loan { get; set; }
        public long MonthlyIntreset { get; set; }
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
