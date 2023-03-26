using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Model.Aggrigates;

namespace VisitorPattern.Model.Visitor
{
    public class NetworthCalculatory : IVisitor
    {
        public long _networth;
        public void Accept(Car car)
        {
            _networth += car.Price; 
        }

        public void Accept(BankAccount bankAccount)
        {
            _networth += bankAccount.Balance;
            _networth += bankAccount.Loan/12;
        }

        public void Accept(RealState realState)
        {
            _networth += realState.MonthlyTax;
            _networth -= realState.Price;
        }

        public long GetAmount() => _networth; 
    }
}
