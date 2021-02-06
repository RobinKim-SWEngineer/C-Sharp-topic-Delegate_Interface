using System;

namespace Interface.BankFuntionProvider
{
    class GloomyTransactCorporation : ITransactionable
    {
        public bool TranactionPermitted { get; set; } = true;

        public void Transfer(double money)
        {
            Console.WriteLine($"GloomyTransaction is sending money, extra fast : {money} CZK");
        }
    }
}
