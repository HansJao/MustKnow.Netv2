
using System;

namespace ClassLibrary.Encapsulation
{
    class ATM
    {
        private string _account;
        public string Account
        {
            get { return _account; }
            set
            {
                if (value.Contains("@"))
                {
                    _account = "";
                }
                _account = value;
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Contains("#"))
                {
                    _password = "";
                }
                _password = value;
            }
        }


        public int GetCashProcess(string account, string password, int cash)
        {
            Account = account;
            var user = GetUserName(Account, password);
            if (IsValideUser(user))
            {
                GetCash(cash);
            }
            else
            {
                Console.WriteLine("Unvalide");


            }
            return 1;
        }

        private void GetCash(int cash)
        {
            throw new NotImplementedException();
        }

        private bool IsValideUser(string user)
        {
            throw new NotImplementedException();
        }

        private string GetUserName(string account, string password)
        {
            throw new NotImplementedException();
        }
    }
}
