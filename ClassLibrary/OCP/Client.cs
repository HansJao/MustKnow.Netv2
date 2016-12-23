namespace ClassLibrary.OCP
{
    public class Client
    {
        private string _clientType;

        public Client(string clientType)
        {
            _clientType = clientType;
        }

        public IProcess CreateProcess()
        {
            switch (_clientType)
            {
                case "領錢":
                    return new DepositProcess();
                    break;
                case "存錢":
                    return new DrawMoneyProcess();
                    break;
                default:
                    return null;
                    break;;
            }
        }
    }
}
