namespace ClassLibrary.DIP
{
    public class BankClient
    {
        private string _clientType;

        public BankClient(string clientType)
        {
            _clientType = clientType;
        }

        public IBankProcess CreateProcess()
        {
            switch (_clientType)
            {
                case "領錢":
                    return new DepositProcessing();
                    break;
                case "存錢":
                    return new DrawMoneyProcessing();
                    break;
                default:
                    return null;
                    break;;
            }
        }
    }
}
