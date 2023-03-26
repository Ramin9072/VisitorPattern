using VisitorPattern.Model.Visitor;

namespace VisitorPattern.Model
{
    public abstract class Asset
    {
        public long OwnerId { get; set; }
        // این کار باعث میشود که همه ساب کلاس های زیرین محسابه هم کدام از این موارد را پیاده سازی کنن
        //public abstract Asset CalculatePrice();
        //public abstract Asset CalculateMonthlyIncome();

        /// <summary>
        /// Duble dispatching
        /// </summary>
        public abstract void AcceptVisitor(IVisitor visitor); // این کار برای این است که هر با این ویزیتور به جاهایی که نیاز است سر بزند

    }
}
