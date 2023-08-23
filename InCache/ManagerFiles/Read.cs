using System.IO;

namespace InCache.ManagerFiles {
    partial class Files {
        public static string Read() {
            using (StreamReader sr = new StreamReader(FullPath))
                return sr.ReadToEnd();
        }
    }
}
