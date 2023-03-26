using VisitorPattern.Model.Aggrigates;

namespace VisitorPattern.Model.Visitor
{
    public class MonthlyIncomeCalculator : IVisitor
    {
        private long _income; 
        public void Accept(Car car)
        {
            _income += car.MonthlyCost; 
        }

        public void Accept(BankAccount bankAccount)
        {
            _income += bankAccount.Balance;
            _income += bankAccount.MonthlyIntreset;
        }

        public void Accept(RealState realState)
        {
            _income += realState.MonthlyTax; 
        }

        public long GetIncome() => _income;
    }
}
