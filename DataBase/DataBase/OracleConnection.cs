using System;

namespace DataBase
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenDb()
        {
            Console.WriteLine("Oracle database opened.");
        }

        public override void CloseDb()
        {
            Console.WriteLine("Oracle database closed.");
        }

    }
}
