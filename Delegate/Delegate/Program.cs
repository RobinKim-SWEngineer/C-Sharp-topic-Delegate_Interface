using Delegate.BankFuntionProvider;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bank happyBank = new Bank(HappyTransactionCorporation.TransactMoney, HappySaveCorporation.Save, HappyInvestCorporation.Invest);
            Bank happyBank = new Bank(GloomyTransactionCorporation.Transact, HappySaveCorporation.Save, HappyInvestCorporation.Invest);

            happyBank.Transact(45000);

            happyBank.Save(12000);

            happyBank.Invest(75000);

            System.Console.ReadLine();
        }
    }
}
