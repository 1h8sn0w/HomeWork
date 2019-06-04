using System.Collections.Generic;
using System.Data.Entity;

namespace Chat_Client
{
    internal class Auth
    {
        public class UserContext : DbContext
        {
            public UserContext() :
                base("Chat_Client.Properties.Settings.ConnectionString")
            {
            }
        }

        public DbSet<User> Users { get; set; }

        public bool AuthCheck(string message)
        {
            Dictionary<string, string> usersDict = new Dictionary<string, string>();

            using (var db = new UserContext())
            {
                foreach (var item in Users)
                {
                    usersDict.Add(item.Name, item.Password);
                }
            }

            if (usersDict.ContainsKey(message))
            {
                new FormChat().textBoxChat.AppendText("\r\nUser " + message + " WELCOME");
                return true;
            }

            return false;
            
        }
    }
}