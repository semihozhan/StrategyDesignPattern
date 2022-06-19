using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class EftOrderPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Successfully with EFT");
        }
    }
}
