using System.Collections.Generic;
using System.Text.Json;
using InCache.ManagerFiles;
using InCache.ManagerJson;

namespace InCache.Cookie {
    /// <summary>
    /// clase para gestionar cookies a travez de archivo json
    /// </summary>
    /// <remarks>
    /// debes agregar referencia a tu poryecto 
    /// </remarks>
    /// <code>
    /// using InCache.Cookie;
    /// </code>
    public static partial class Cookie {
        /// <summary>
        /// Indicador de auto guardao
        /// </summary>
        /// <remarks>
        /// true = se guarda en cada accion
        /// false = no se guardara
        /// si modificas a false favor de ejecutar el metodo <see cref="Save" /> para mas informacion
        /// </remarks>
        public static bool AutoSafe = true;
        /// <summary>
        /// Almacenamiento de datos en memoria 
        /// </summary>
        private static List<ObjCookie> Cookies = new List<ObjCookie>(); 

        /// <summary>
        /// constructor estatico de la clase cookie
        /// </summary>
        /// <remarks>
        /// no tocar este solito se ejecuta y es necesario para leer las cookis ya exsitentes por si hay
        /// para mas informacion de como funciona ver <see cref="Files.Read"/> y <see cref="Json.Deserialize{T}(string)"/>
        /// </remarks>
        static Cookie() {
            string txt = Files.Read();
            if (!string.IsNullOrEmpty(txt))
                Cookies = (List<ObjCookie>)Json.Deserialize<List<ObjCookie>>(txt);
        }
    }
}
