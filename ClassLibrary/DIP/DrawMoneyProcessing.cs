using System;

namespace ClassLibrary.DIP
{
    public class DrawMoneyProcessing : IBankProcess
    {
        public void Process()
        {
            Console.WriteLine("DrawMoneyProcess");
        }
    }
}
