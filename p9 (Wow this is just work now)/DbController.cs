using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWork
{
  public abstract class DbController
  {
    public abstract void Controller();
    public abstract void OpenConnection();
    public abstract void CloseConnection();
    public static int getInput()
    {
      Console.WriteLine("\n1. Open Connection");
      Console.WriteLine("2. Close Connection");
      Console.WriteLine("3. Exit\n");
      return Convert.ToInt32(Console.ReadLine());
    }
  }  
}
