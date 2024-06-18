
namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new OracleConnection("Connection string"), "There is still something to do . . .");
            command.Execute();
        }
    }
}
