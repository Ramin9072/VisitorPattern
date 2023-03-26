using VisitorPattern.Model.Visitor;

namespace VisitorPattern.Model.Aggrigates
{
    public class RealState : Asset
    {
        public long Price { get; set; }
        public long MonthlyTax { get; set; }
        public long RentIncome { get; set; }
        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
