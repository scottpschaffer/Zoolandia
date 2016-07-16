using System;

namespace Zoolandia
{

    public interface IAccountSaver
    {
        bool Save (string account);

        string Get ();
    }

    public class sqlAccountSaver : IAccountSaver
    {
        public bool Save(string account)
        {
            return true;
        }

        public string Get()
        {
            return "Here's the account.";
        }
    }
}