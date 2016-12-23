namespace ClassLibrary.DIP
{
    public class EasyBankStaff
    {
        private IBankProcess _process;

        public void HandleProcess(IBankClient client)
        {
            client.CreaBankProcess().Process();
        }
    }
}
