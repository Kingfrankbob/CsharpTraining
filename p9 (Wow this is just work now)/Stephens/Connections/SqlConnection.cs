namespace RealWork
{
  public class SqlConnection : DbConnection
  {
    private DateTime _OpenedTime;
    private DateTime _ClosedTime;
    private string _ConnectionString;

    public SqlConnection(string connectionString) : base(connectionString)
    {
      _OpenedTime = DateTime.Now;
      _ClosedTime = _OpenedTime;
      _ConnectionString = connectionString;
    }
    public override void OpenConnection()
    {
      if (_OpenedTime == _ClosedTime)
      {
        Console.WriteLine("Opening SqlConnection with the ConnectionString: " + _ConnectionString);
        _OpenedTime = DateTime.Now;
        Thread.Sleep(new Random().Next(100, 1000));
      }
      else
      {
        throw new InvalidOperationException("Connection is already open");
      }
    }
    public override void CloseConnection()
    {
      timeOut = DateTime.Now - _OpenedTime;
      if (_OpenedTime != _ClosedTime)
      {
        Console.WriteLine("Closing SqlConnection with the ConnectionString: " + _ConnectionString);
        Console.WriteLine("Connection was open for {0} seconds", timeOut.TotalSeconds);
        _OpenedTime = DateTime.Now;
        _ClosedTime = _OpenedTime;
      }
      else
      {
        throw new InvalidOperationException("Connection is already closed");
      }
    }
  }
}