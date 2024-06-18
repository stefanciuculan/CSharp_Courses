using System;

namespace DataBase
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new ArgumentException("The connection string cannot be empty or null.");
            else
                ConnectionString = connectionString;
        }

        public abstract void OpenDb();
        public abstract void CloseDb();
    }
}
