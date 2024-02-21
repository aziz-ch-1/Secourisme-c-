using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSecourisme
{
    
        public class Constants
        {
            public const string DatabaseFilename = "database.db3";

            public static string DatabasePath = Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

            public const SQLiteOpenFlags Flags = SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache;
        }
    
}
