using System;

namespace ClassLibrary.DIP
{
    public class DepositProcessing : IBankProcess
    {
        public void Process()
        {
            Console.WriteLine("DepositProcess");
        }
    }
}
