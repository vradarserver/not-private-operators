using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Editor
{
    static class BaseStationDatabase
    {
        public static IList<BaseStationAircraft> LoadMaybePrivateAircraft(string fileName)
        {
            if(!File.Exists(fileName)) {
                return new BaseStationAircraft[0];
            }

            using(var connection = new SQLiteConnection(BuildConnectionString(fileName))) {
                connection.Open();
                return connection.Query<BaseStationAircraft>(@"
SELECT * FROM Aircraft
WHERE  IFNULL(OperatorFlagCode, '') = ''
AND    IFNULL(RegisteredOwners, '') <> ''
AND    RegisteredOwners <> 'Private'
                ").ToArray();
            }
        }

        private static string BuildConnectionString(string fileName)
        {
            return new SQLiteConnectionStringBuilder() {
                DataSource =        fileName,
                ReadOnly =          true,
                FailIfMissing =     true,
                DateTimeFormat =    SQLiteDateFormats.ISO8601,
                JournalMode =       SQLiteJournalModeEnum.Default,
            }.ConnectionString;
        }
    }
}
