using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeWork
{
    public class SQLConnecctor : DbController
    {
        private Boolean Connectionset = false;
        public override void OpenConnection()
        {
            Console.WriteLine("Connection to {0} Opened!!!!!!", this.connectionString);
        }
                public override void CloseConnection()
        {
            Console.WriteLine("Connection to {0} Closed??????", this.connectionString);
        }
        public static void Controller()
        {

            Console.WriteLine("Enter a connection type or something along the lines!");
            var input = Console.ReadLine();
            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Try Again!");
                Controller();
            }
            Connectionset == true;
            var sqlcon = new SqlConnection(input);
            while(Connectionset == true){
            Console.WriteLine(@"Please enter an input
            1. open
            2. C1OsE
            3. Exit");
            var inputint = int.Parse(Console.ReadLine() ?? "");
            switch(inputint)
            {
                case 1:
                    sqlcon.OpenConnection();
                    break;
                case 2:
                    sqlcon.CloseConnection();
                    break;
                case 3:
                Connectionset == false;
                break;
            }
            }
        }
    }
}