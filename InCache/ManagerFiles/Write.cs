using System.IO;

namespace InCache.ManagerFiles {
    partial class Files {
        public static void Write(string txt) {
            using (StreamWriter sw = new StreamWriter(FullPath, false))
                sw.Write(txt);
        }
    }
}
