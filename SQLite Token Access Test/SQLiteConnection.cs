using System.Data;

namespace SQLite_Token_Access_Test
{
    internal class SQLiteConnection : IDbConnection
    {
        private object p;

        public SQLiteConnection(object p)
        {
            this.p = p;
        }
    }
}