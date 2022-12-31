using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeWork
{
  public abstract class DbController
  {
    private string _connectionString;
    public TimeSpan timeOut { get; set; }
    public DbController(string connectionString)
    {
      if (!string.IsNullOrWhiteSpace(connectionString))
        _connectionString = connectionString;
      else
        throw new InvalidOperationException("Connection string cannot be null");
    }
    public abstract void CloseConnection();
    public abstract void OpenConnection();

  }
}