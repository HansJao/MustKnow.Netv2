namespace ClassLibrary.DIP
{
    public class DepositClient : IBankClient
    {
        public IBankProcess CreaBankProcess()
        {
            return new DepositProcessing();
        }
    }
}
