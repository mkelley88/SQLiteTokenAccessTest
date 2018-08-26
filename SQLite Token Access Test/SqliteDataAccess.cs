﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_Token_Access_Test
{
    public class SqliteDataAccess
    {
        /// <summary>
        /// This function takes a single argument of type int.
        /// The integer given corrisponds to the Token in the DB.
        /// </summary>
        /// <param name="tokenInteger"></param>
        /// <returns>A list element.</returns>
        public static List<TokenModel> LoadToken(int tokenInteger = 0)
        {
            string sqlFindTokenByInteger = "select * from Tokens where Integer is " + tokenInteger.ToString();

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<TokenModel>(sqlFindTokenByInteger, new DynamicParameters());
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}