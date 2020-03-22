using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Editor
{
    static class PersistentStateManager
    {
        public static string Folder => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NotPrivateOperatorsEditor");

        public static string FileName => "State.json";

        public static string FullPath => Path.Combine(Folder, FileName);

        public static PersistentState Load()
        {
            PersistentState result = null;

            if(File.Exists(FullPath)) {
                try {
                    result = JsonConvert
                        .DeserializeObject<PersistentState>(
                            File.ReadAllText(FullPath)
                        );
                } catch {}
            }

            return result ?? new PersistentState();
        }

        public static void Save(PersistentState state)
        {
            if(!Directory.Exists(Folder)) {
                Directory.CreateDirectory(Folder);
            }

            File.WriteAllText(
                FullPath,
                JsonConvert.SerializeObject(state)
            );
        }

        public static void ChangeState(Action<PersistentState> changeState)
        {
            var state = Load();
            changeState(state);
            Save(state);
        }
    }
}
