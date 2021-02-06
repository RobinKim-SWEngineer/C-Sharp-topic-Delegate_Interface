using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.BankFuntionProvider
{
    class GloomyTransactionCorporation
    {
        public static void Transact(double money)
        {
            Console.WriteLine($"GloomyTransaction is sending money, extra fast : {money} CZK");
        }
    }
}
