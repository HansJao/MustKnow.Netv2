namespace ClassLibrary.Proxy
{
    public class DBManagerProxy : IDBAction
    {
        private readonly IDBAction _dbManager;
        private readonly int _id;

        public DBManagerProxy(IDBAction dbAction, int id)
        {
            _dbManager = dbAction;
            _id = id;
        }
        public string GetPermission(int id)
        {
            return "CanAdd";
        }
        public void Add()
        {

            if (GetPermission(_id) == "CanAdd")
            {
                _dbManager.Add();
            }
        }

        public void Delete()
        {
            _dbManager.Delete();
        }

        public void View()
        {
            _dbManager.View();
        }
    }
}
