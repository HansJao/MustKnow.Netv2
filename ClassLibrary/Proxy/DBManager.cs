using System;

namespace ClassLibrary.Proxy
{
    public class DBManager :IDBAction
    {

        public void Add()
        {
            Console.WriteLine("DB Add");
        }

        public void Delete()
        {
            Console.WriteLine("DB Delete");
        }

        public void View()
        {
            Console.WriteLine("DB View");
        }
    }
}
