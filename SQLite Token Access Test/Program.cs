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
            // Insert the integer we're searching for here in "FindTokenByInteger()".
            List<TokenModel> returnedToken = SqliteDataAccess.FindTokenByInteger(18); // 18 is the integer value corresponding to the string "round("

            // DEBUG: Get some feedback to see if it worked.
            foreach (var item in returnedToken)
            {
                Console.WriteLine("Search by Integer\n----------------");
                Console.WriteLine(item);
                Console.WriteLine("Integer: " + item.TokenInteger.ToString());
                Console.WriteLine("Alt String: " + item.TokenAltString);
                Console.WriteLine("String: " + item.TokenString);
                Console.WriteLine("ByteHigh: " + item.TokenByteHigh);
                Console.WriteLine("ByteLow: " + item.TokenByteLow);
            }


            // Insert the string we're searching for here in "FindTokenByString()".
            returnedToken = SqliteDataAccess.FindTokenByString("round("); // "round(" is the string value correspoding to the integer 18

            // DEBUG: Get some feedback to see if it worked.
            foreach (var item in returnedToken)
            {
                Console.WriteLine("\nSearch by String\n----------------");
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
