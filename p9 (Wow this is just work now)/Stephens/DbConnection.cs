namespace RealWork
{
  public abstract class DbConnection
  {
    private string _connectionString;
    public TimeSpan timeOut { get; set; }
    public DbConnection(string connectionString)
    {
      if (!string.IsNullOrWhiteSpace(connectionString))
        _connectionString = connectionString;
      else
        throw new InvalidOperationException("Connection string cannot be null");
    }
    public abstract void OpenConnection();
    public abstract void CloseConnection();
  }
}