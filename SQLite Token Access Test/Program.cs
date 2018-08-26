using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Token_Access_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert the integer we're searching for here in "LoadToken()".
            List<TokenModel> returnedToken = SqliteDataAccess.LoadToken(20);

            // DEBUG: Get some feedback to see if it worked.
            foreach (var item in returnedToken)
            {
                Console.WriteLine(item);
                Console.WriteLine("Integer: " + item.TokenInteger.ToString());
                Console.WriteLine("Alt String: " + item.TokenAltString);
                Console.WriteLine("String: " + item.TokenString);
                Console.WriteLine("ByteHigh: " + item.TokenByteHigh);
                Console.WriteLine("ByteLow: " + item.TokenByteLow);
            }

            // Prevent console window from closing. Press enter to exit.
            Console.Read();
        }
    }
}
