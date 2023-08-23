using System;
using System.IO;

namespace InCache.ManagerFiles {
    internal static partial class Files {
        private static readonly string BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "darth");
        private static readonly string FullPath = Path.Combine(BasePath, System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".json");

        static Files() {
            if (!Directory.Exists(BasePath))
                Directory.CreateDirectory(BasePath);
            if (!File.Exists(FullPath)) {
                var t = File.Create(FullPath);
                t.Close();
            }
        }
    }
}
