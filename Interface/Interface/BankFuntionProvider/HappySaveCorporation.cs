using System;

namespace Interface.BankFuntionProvider
{
    class HappySaveCorporation : ISavable
    {
        public void Save(double money)
        {
            Console.WriteLine($"HappySave is saving money {money} CZK");
        }
    }
}
