﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class StringsFile
    {
        public string Folder { get; set; }

        public string FileName { get; }

        public string FullPath => Path.Combine(Folder, FileName);

        public HashSet<string> Contents { get; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public IList<string> FileHeader { get; set; }

        public StringsFile(string fileName)
        {
            FileName = fileName;
        }

        public void Load()
        {
            Contents.Clear();
            FileHeader = new string[0];

            if(File.Exists(FullPath)) {
                var header = new List<string>();
                foreach(var line in File.ReadLines(FullPath)) {
                    var trimmed = line.Trim();
                    if(trimmed == "" || trimmed.StartsWith("#")) {
                        header.Add(line);
                    } else {
                        break;
                    }
                }
                FileHeader = header;

                foreach(var line in TextFile.ReadAllLinesPerConvention(FullPath)) {
                    if(!Contents.Contains(line)) {
                        Contents.Add(line);
                    }
                }
            }
        }

        public void Save()
        {
            if(File.Exists(FullPath)) {
                using(var fileStream = new FileStream(FullPath, FileMode.Truncate, FileAccess.Write, FileShare.Read)) {
                    using(var streamWriter = new StreamWriter(fileStream)) {
                        foreach(var headerLine in (FileHeader ?? new string[0])) {
                            streamWriter.WriteLine(headerLine);
                        }

                        var lines = Contents
                            .Select(r => (r ?? "").Trim())
                            .Where(r => r != "")
                            .OrderBy(r => r.ToLower());

                        foreach(var line in lines) {
                            streamWriter.WriteLine(line);
                        }
                    }
                }
            }
        }

        public void AddIfNotExists(string entry)
        {
            var trimmed = (entry ?? "").Trim();
            if(trimmed != "" && !Contents.Contains(trimmed)) {
                Contents.Add(trimmed);
            }
        }

        public void AddAllIfNotExists(IEnumerable<string> entries)
        {
            foreach(var entry in (entries ?? new string[0])) {
                AddIfNotExists(entry);
            }
        }

        public void RemoveIfExists(string entry)
        {
            var trimmed = (entry ?? "").Trim();
            if(Contents.Contains(trimmed)) {
                Contents.Remove(trimmed);
            }
        }

        public void RemoveAllIfExists(IEnumerable<string> entries)
        {
            foreach(var entry in (entries ?? new string[0])) {
                RemoveIfExists(entry);
            }
        }
    }
}