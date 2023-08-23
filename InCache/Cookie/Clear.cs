using InCache.ManagerFiles;

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// Limpiamos las cookies temporales y permanentes
        /// </summary>
        public static void Clear() {
            Cookies.Clear();
            Files.Write("");
        }
    }
}
