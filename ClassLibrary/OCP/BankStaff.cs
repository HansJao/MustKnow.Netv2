namespace ClassLibrary.OCP
{
    public class BankStaff
    {
        private IProcess _process;

        public void HandleProcess(Client client)
        {
            _process = client.CreateProcess();
            _process.Process();;
        }
    }
}
