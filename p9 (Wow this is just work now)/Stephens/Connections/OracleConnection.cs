namespace RealWork
{
  public class OracleConnection : DbConnection
  {
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }
    public override void OpenConnection()
    {
      Console.WriteLine("Opening OracleConnection");
    }
    public override void CloseConnection()
    {
      Console.WriteLine("Closing OracleConnection");
    }
  }
}