using System;

namespace Interface.BankFuntionProvider
{
    class HappyTransactionCorporation : ITransactionable
    {
        public bool TranactionPermitted { get; set; } = true;

        public void Transfer(double money)
        {
            Console.WriteLine($"HappyTransaction is sending money : {money} CZK");
        }
    }
}
