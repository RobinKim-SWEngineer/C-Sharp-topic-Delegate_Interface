namespace Delegate
{
    public delegate void TransactionDelegate(double money);
    public delegate void SavingDelegate(double money);
    public delegate double InvestmentDelegate(double money);
    public class Bank
    {
        public string Address { get; set; }
        private TransactionDelegate _transactionDelegate { get; set; }
        private SavingDelegate _savingDelegate { get; set; }
        private InvestmentDelegate _investmentDelegate { get; set; }

        public Bank(TransactionDelegate transactionDelegate, SavingDelegate savingDelegate, InvestmentDelegate investmentDelegate)
        {
            _transactionDelegate = transactionDelegate;
            _savingDelegate = savingDelegate;
            _investmentDelegate = investmentDelegate;
        }

        public void Transact(double money)
        {
            _transactionDelegate(money);
        }

        public void Save(double money)
        {
            _savingDelegate(money);
        }

        public double Invest(double money)
        {
            return _investmentDelegate(money);
        }
    }
}
