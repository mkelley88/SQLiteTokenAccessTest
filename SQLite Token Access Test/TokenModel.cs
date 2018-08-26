using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Token_Access_Test
{
    public class TokenModel
    {
        public int      TokenInteger { get; set; }
        public string   TokenByteHigh { get; set; }
        public string   TokenByteLow { get; set; }
        public string   TokenString { get; set; }
        public string   TokenAltString { get; set; }
    }
}
