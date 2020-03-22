using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Editor
{
    static class NameAndExpressionFiles
    {
        private static string _Folder;

        public static string Folder
        {
            get => _Folder;
            set {
                _Folder = value;
                NotPrivateNames.Folder = value;
                NotPrivateRegularExpressions.Folder = value;
                PrivateNames.Folder = value;
            }
        }

        public static StringsFile NotPrivateNames { get; } = new StringsFile("not-private-names.txt");

        public static StringsFile NotPrivateRegularExpressions { get; } = new StringsFile("not-private-regular-expressions.txt");

        public static StringsFile PrivateNames { get; } = new StringsFile("private-names.txt");

        static NameAndExpressionFiles()
        {
            Folder = PersistentStateManager
                .Load()
                .FilesFolder;
        }

        public static void Load()
        {
            NotPrivateNames.Load();
            NotPrivateRegularExpressions.Load();
            PrivateNames.Load();
        }

        public static void Save()
        {
            NotPrivateNames.Save();
            NotPrivateRegularExpressions.Save();
            PrivateNames.Save();
        }

        public static bool? IsNotPrivateOperator(string operatorName)
        {
            bool? result = null;
            var normalisedName = (operatorName ?? "").Trim();

            if(PrivateNames.Contents.Contains(normalisedName)) {
                result = false;
            } else if(NotPrivateNames.Contents.Contains(normalisedName)) {
                result = true;
            } else {
                foreach(var regexText in NotPrivateRegularExpressions.Contents) {
                    if(Regex.Match(normalisedName, regexText, RegexOptions.IgnoreCase).Success) {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public static void AddToNotPrivateNames(IEnumerable<string> names)
        {
            PrivateNames.RemoveAllIfExists(names);
            NotPrivateNames.AddAllIfNotExists(names);
        }

        public static void RemoveFromNotPrivateNames(IEnumerable<string> names)
        {
            NotPrivateNames.RemoveAllIfExists(names);
        }

        public static void AddToPrivateNames(IEnumerable<string> names)
        {
            NotPrivateNames.RemoveAllIfExists(names);
            PrivateNames.AddAllIfNotExists(names);
        }

        public static void RemoveFromPrivateNames(IEnumerable<string> names)
        {
            PrivateNames.RemoveAllIfExists(names);
        }
    }
}
