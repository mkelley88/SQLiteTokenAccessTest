using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Token_Access_Test
{
    public class TokenModel
    {
        public int      Integer { get; set; }
        public string     HighByte { get; set; }
        public string     LowByte { get; set; }
        public string   String { get; set; }
        public string   AltString { get; set; }
        public int      StringStarter { get; set; }
        public int      StringTerminator { get; set; }
        public string   Group { get; set; }
        public string   Style { get; set; }
    }
}