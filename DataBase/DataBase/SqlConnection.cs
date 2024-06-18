using System;

namespace DataBase
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenDb()
        {
            Console.WriteLine("SQL database opened.");
        }

        public override void CloseDb()
        {
            Console.WriteLine("SQL database closed.");
        }

    }
}
