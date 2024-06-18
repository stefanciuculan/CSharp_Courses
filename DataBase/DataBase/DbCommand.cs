using System;

namespace DataBase
{
    public class DbCommand
    {
        public DbConnection NewDb { get; set; }
        public string Instruction { get; set; }

        public DbCommand(DbConnection myDb)
        {
            if (myDb == null)
                throw new ArgumentNullException("Null cannot be passed as a parameter");
            else
                NewDb = myDb;
        }

        public DbCommand(DbConnection myDb, string instruct) 
            : this(myDb)
        {
            if (String.IsNullOrEmpty(instruct))
                throw new ArgumentNullException("Null cannot be passed as a parameter");
            else
                Instruction = instruct;
        }

        public void Execute()
        {
            NewDb.OpenDb();
            Console.WriteLine(Instruction);
            NewDb.CloseDb();
        }
    }
}
