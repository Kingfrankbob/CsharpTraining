using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeWork
{
    public abstract class DbController
    {
        public static void Controller()
        {

        }
        public abstract void CloseConnection();
        public abstract void OpenConnection();

    }
}