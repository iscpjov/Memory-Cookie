using InCache.ManagerJson;
using System.Text.Json;
using System;

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// metodo para obtener el valor de la cookie almacenada
        /// <see cref="Getter(string)"/>
        /// <see cref="Add(string, dynamic)"/>
        /// </summary>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <returns>
        /// si la cooki existe esta returna el valor si no returna null
        /// </returns>
        /// <example> Cookie.Get("micookie") </example>
        public static object Get(string key) {
            int index = GetIndex(key);
            if (index >= 0)
            {
                ObjCookie cookie = Cookies[index];
                return Json.Deserialize(cookie.Value, GetterType(cookie.Type));
            }
            return null;
        }

        /// <summary>
        /// metodo para obtener el valor de la cookie almacena y si esta no existe lo añade
        /// <see cref="Add(string, dynamic)"/>
        /// </summary>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <param name="value">valor de la cookie</param>
        /// <returns>return ya sea el valor encontrado o el nuevo valor agregado</returns>
        /// /// <example> Cookie.Get("micookie", "mivalor") </example>
        public static object Get(string key, object value) {
            var cookie = Get(key);
            if (cookie is null)
            {
                Add(new ObjCookie(key, value));
                return value;
                
            }
            else
            {
                return cookie;
            }

            
        }
    }
}
