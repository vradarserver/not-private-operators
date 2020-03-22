using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    class PersistentState
    {
        public string DefaultFilesFolder => Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", ".."));

        public string OverrideFilesFolder { get; set; }

        public string FilesFolder
        {
            get => OverrideFilesFolder ?? DefaultFilesFolder;
            set => OverrideFilesFolder = String.Equals(value, DefaultFilesFolder, StringComparison.OrdinalIgnoreCase) ? null : value;
        }

        public string BaseStationSqbFullPath { get; set; }
    }
}
