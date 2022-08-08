namespace FakeWork
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectioner) : base(connectioner)
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