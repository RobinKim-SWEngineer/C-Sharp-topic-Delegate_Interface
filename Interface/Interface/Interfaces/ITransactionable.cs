namespace Interface
{
    public interface ITransactionable 
    { 
        void Transfer(double money);
        bool TranactionPermitted { get; set; }
    }
}
