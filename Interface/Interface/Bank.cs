namespace Interface
{
    public class Bank
    {
        public string Address { get; set; }

        private ITransactionable _Transact;
        private ISavable _savable;
        private IInvestable _investable;

        public Bank(ITransactionable transferable, ISavable savable, IInvestable investable)
        {
            _Transact = transferable;
            _savable = savable;
            _investable = investable;
        }

        public void Transact(double money)
        {

            if (_Transact.TranactionPermitted)
            {
                _Transact.Transfer(money);
                return;
            }
            System.Console.WriteLine("Transaction is not allowed currently");
        }
        public void Save(double meony)
        {
            _savable.Save(meony);
        }
        public double Invest(double money)
        {
            return _investable.Invest(money);
        }

        public void ChangeTransactionAuthorization()
        {
            _Transact.TranactionPermitted = !_Transact.TranactionPermitted;
        }
    }
}
