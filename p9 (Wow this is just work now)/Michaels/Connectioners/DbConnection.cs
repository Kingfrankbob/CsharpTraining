using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeWork
{
    public abstract class DbConnection
    {
        public string connectionString;
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectioner)
        {
            if(!String.IsNullOrWhiteSpace(connectioner))
            {
                connectionString = connectioner;
            }
            else
            {   
                Console.WriteLine("Please try again u nerd!!!!");
            }
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();

    }
}