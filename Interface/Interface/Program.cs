using Interface.BankFuntionProvider;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bank happyBank = new Bank(new HappyTransactionCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());
            Bank happyBank = new Bank(new GloomyTransactCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());
            
            happyBank.Transact(45000);

            happyBank.Save(12000);

            happyBank.Invest(75000);

            System.Console.ReadLine();
        }
    }
}
