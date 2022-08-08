using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeWork
{
    public class SqlConnection : DbConnection
    {
                public SqlConnection(string connectioner) : base(connectioner)
        {
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Connection to Connection Opened!");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Connection to the Connection Closed?!");
        }
    }
}