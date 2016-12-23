namespace ClassLibrary.DIP
{
    public class DrawMoneyClient:IBankClient
    {
        
        public IBankProcess CreaBankProcess()
        {
           return new DrawMoneyProcessing();
        }
    }
}
