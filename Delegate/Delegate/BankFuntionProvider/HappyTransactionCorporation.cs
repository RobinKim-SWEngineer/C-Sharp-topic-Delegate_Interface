using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.BankFuntionProvider
{
    class HappyTransactionCorporation
    {
        public static void TransactMoney(double money)
        {
            Console.WriteLine($"HappyTransaction is sending money : {money} CZK");
        }
    }
}
