namespace RealWork
{
  public static class SqlConnectionController{
    public static void Controller()
    {
      Console.WriteLine("Enter the connection string: ");
      string connectionString = Console.ReadLine() ?? "";
      if (string.IsNullOrWhiteSpace(connectionString))
      {
        throw new InvalidOperationException("Connection string cannot be null");
      }
      var connection = new SqlConnection(connectionString);
      var choice = 0;
      var open = false;
      while (choice != 3)
      {
        choice = getInput();
        switch (choice)
        {
          case 1:
            OpenConnection(connection);
            open = true;
            break;
          case 2:
           CloseConnection(connection);
           open = false;
            break;
          case 3:
          if(open == true)
              CloseConnection(connection);
            break;
          default:
            Console.WriteLine("Invalid choice");
            break;
        }
      }
      Console.WriteLine("Exiting...");
    }
    public static int getInput()
    {
      Console.WriteLine("\n1. Open Connection");
      Console.WriteLine("2. Close Connection");
      Console.WriteLine("3. Exit\n");
      return Convert.ToInt32(Console.ReadLine());
    }
    public static void OpenConnection(SqlConnection connection){
      connection.OpenConnection();
    }
    public static void CloseConnection(SqlConnection connection){
      connection.CloseConnection();
    }
  }
}