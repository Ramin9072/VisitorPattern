using VisitorPattern.Model.Visitor;

namespace VisitorPattern.Model.Aggrigates
{
    public class Car : Asset
    {
        public long Price { get; set; }
        public long MonthlyCost { get; set; }

        public override void AcceptVisitor(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
