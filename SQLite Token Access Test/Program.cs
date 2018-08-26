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
            foreach (var token in returnedToken)
            {
                Console.WriteLine
                    (
                    "Search by Integer\n----------------\n"
                    + token
                    + "\nInteger: " + token.Integer.ToString()
                    + "\nByteHigh: " + token.HighByte
                    + "\nByteLow: " + token.LowByte
                    + "\nString: " + token.String
                    );
            }

            // Insert the string we're searching for here in "FindTokenByString()".
            returnedToken = SqliteDataAccess.FindTokenByString("round("); // "round(" is the string value correspoding to the integer 18

            // DEBUG: Get some feedback to see if it worked.
            foreach (var token in returnedToken)
            {
                Console.WriteLine
                    (
                    "\n\nSearch by String\n----------------\n"
                    + token
                    + "\nInteger: " + token.Integer.ToString()
                    + "\nByteHigh: " + token.HighByte
                    + "\nByteLow: " + token.LowByte
                    + "\nString: " + token.String
                    );
            }

            // Prevent console window from closing. Press enter to exit.
            Console.Read();
        }
    }
}
