using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class PaymentOperation
    {
        private IPayment _payment;
        public PaymentOperation(IPayment payment)
        {
            this._payment = payment;
        }
        public void MakePayment()
        {
            this._payment.MakePayment();
        }
    }
}
