using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    static class MilitaryIcaoRanges
    {
        private static List<Tuple<int, int>> _Ranges = new List<Tuple<int, int>>();

        private static Regex _ParseRegex = new Regex("^(?<from>[0-9a-fA-F]{6})-(?<to>[0-9a-fA-F]{6})$");

        public static string FullPath => Path.Combine(Application.StartupPath, "MilitaryIcaoRanges.txt");

        static MilitaryIcaoRanges()
        {
            LoadRanges();
        }

        public static void LoadRanges()
        {
            if(File.Exists(FullPath)) {
                _Ranges.Clear();
                foreach(var line in TextFile.ReadLinesPerConvention(FullPath)) {
                    var match = _ParseRegex.Match(line);
                    if(match.Success) {
                        var from = CustomConvert.Icao24(match.Groups["from"].Value);
                        var to   = CustomConvert.Icao24(match.Groups["to"].Value);
                        if(from != 0 && from <= to) {
                            _Ranges.Add(new Tuple<int, int>(from, to));
                        }
                    }
                }
            }
        }

        public static bool IsMilitary(int icao24) => _Ranges.Any(r => r.Item1 <= icao24 && r.Item2 >= icao24);

        public static bool IsMilitary(string icao24) => IsMilitary(CustomConvert.Icao24(icao24));
    }
}
