using InCache.ManagerJson;
using InCache.ManagerFiles;


namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// metodo para guardar en el archivo las cookies y hacerlas prexistente
        /// </summary>
        public static void Save() =>
            Files.Write(Json.Serialize(Cookies));

        private static void _Save(){
            if(AutoSafe)
                Save();

        }
    }
}
