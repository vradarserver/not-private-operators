using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class TextFile
    {
        public static readonly TextFile HashCommentsNoBlanks = new TextFile("#", true, true);

        public string LineComment { get; }

        public bool StripBlankLines { get; }

        public bool TrimLines { get; }

        public TextFile() : this("#", true, true)
        {
        }

        public TextFile(string lineComment, bool stripBlankLines, bool trimLines)
        {
            LineComment = lineComment;
            StripBlankLines = stripBlankLines;
            TrimLines = trimLines;
        }

        public IEnumerable<string> ReadLines(string fullPath)
        {
            return File.ReadLines(fullPath)
                .Select(line => {
                    var result = line;

                    if(!String.IsNullOrEmpty(LineComment)) {
                        var startIdx = result.IndexOf(LineComment);
                        if(startIdx != -1) {
                            result = result.Substring(0, startIdx);
                        }
                    }

                    if(TrimLines) {
                        result = result.Trim();
                    }

                    return result;
                })
                .Where(line => !StripBlankLines || line != "");
        }

        public string[] ReadAllLines(string fullPath) => ReadLines(fullPath).ToArray();

        public static IEnumerable<string> ReadLinesPerConvention(string fullPath) => HashCommentsNoBlanks.ReadLines(fullPath);

        public static string[] ReadAllLinesPerConvention(string fullPath) => HashCommentsNoBlanks.ReadAllLines(fullPath);
    }
}
