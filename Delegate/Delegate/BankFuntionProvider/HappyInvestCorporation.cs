using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.BankFuntionProvider
{
    class HappyInvestCorporation
    {
        public static double Invest(double money)
        {
            double investedResult = money * 1.2;
            Console.WriteLine($"HappyInvest bulked the money up..  Final amount : {investedResult} CZK");

            return investedResult;
        }
    }
}
