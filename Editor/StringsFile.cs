using System;
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

        public event EventHandler ContentsChanged;

        protected virtual void OnContentsChanged(EventArgs args) => ContentsChanged?.Invoke(this, args);

        public StringsFile(string fileName)
        {
            FileName = fileName;
        }

        public IList<string> GetSortedContent()
        {
            return Contents
                .Select(r => (r ?? "").Trim())
                .Where(r => r != "")
                .OrderBy(r => r.ToLower())
                .ToArray();
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

                OnContentsChanged(EventArgs.Empty);
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

                        foreach(var line in GetSortedContent()) {
                            streamWriter.WriteLine(line);
                        }
                    }
                }
            }
        }

        public bool AddIfNotExists(string entry, bool raiseContentsChanged = true)
        {
            var contentsChanged = false;

            var trimmed = (entry ?? "").Trim();
            if(trimmed != "" && !Contents.Contains(trimmed)) {
                Contents.Add(trimmed);
                contentsChanged = true;
            }

            if(contentsChanged && raiseContentsChanged) {
                OnContentsChanged(EventArgs.Empty);
            }

            return contentsChanged;
        }

        public bool AddAllIfNotExists(IEnumerable<string> entries, bool raiseContentsChanged = true)
        {
            var contentsChanged = false;

            foreach(var entry in (entries ?? new string[0])) {
                if(AddIfNotExists(entry, raiseContentsChanged: false)) {
                    contentsChanged = true;
                }
            }

            if(contentsChanged && raiseContentsChanged) {
                OnContentsChanged(EventArgs.Empty);
            }

            return contentsChanged;
        }

        public bool RemoveIfExists(string entry, bool raiseContentsChanged = true)
        {
            var contentsChanged = false;

            var trimmed = (entry ?? "").Trim();
            if(Contents.Contains(trimmed)) {
                Contents.Remove(trimmed);
                contentsChanged = true;
            }

            if(contentsChanged && raiseContentsChanged) {
                OnContentsChanged(EventArgs.Empty);
            }

            return contentsChanged;
        }

        public bool RemoveAllIfExists(IEnumerable<string> entries, bool raiseContentsChanged = true)
        {
            var contentsChanged = false;

            foreach(var entry in (entries ?? new string[0])) {
                if(RemoveIfExists(entry, raiseContentsChanged: false)) {
                    contentsChanged = true;
                }
            }

            if(contentsChanged && raiseContentsChanged) {
                OnContentsChanged(EventArgs.Empty);
            }

            return contentsChanged;
        }

        public bool Replace(string oldValue, string newValue, bool raiseContentsChanged = true)
        {
            var contentsChanged = RemoveIfExists(oldValue, raiseContentsChanged: false);
            if(AddIfNotExists(newValue, raiseContentsChanged: false)) {
                contentsChanged = true;
            }

            if(contentsChanged && raiseContentsChanged) {
                OnContentsChanged(EventArgs.Empty);
            }

            return contentsChanged;
        }
    }
}
