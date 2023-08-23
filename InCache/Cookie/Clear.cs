using InCache.ManagerFiles;

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// metodo para remover tanto las varibles en memoria como ya almacenadas
        /// </summary>
        /// <example>
        /// Cookie.Clear();
        /// </example>
        /// <see cref="Files.Write(string)"/> para mas informacion
        public static void Clear() {
            Cookies.Clear();
            Files.Write("");
        }
    }
}
