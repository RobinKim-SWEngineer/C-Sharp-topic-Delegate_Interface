using System;

namespace Interface.BankFuntionProvider
{
    class HappyInvestCorporation : IInvestable
    {
        public double Invest(double money)
        {
            double investedResult = money * 1.2;
            Console.WriteLine($"HappyInvest bulked the money up..  Final amount : {investedResult} CZK");

            return investedResult;
        }
    }
}
