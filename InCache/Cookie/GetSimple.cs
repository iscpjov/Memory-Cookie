using InCache.ManagerJson;
using System.Text.Json;
using System;

namespace InCache.Cookie {
    partial class Cookie {

        /// <summary>
        /// obtencion de la cookie almacenada atravez de su identificador
        /// si esta se encuentra en caso contrario es null o si existion un problema
        /// </summary>
        /// <param name="key"> identificador de la cookie </param>
        /// <returns> devuelve el valor de la cookie como objeto </returns>
        /// <example> <code> int number = Cookie.Get("number") </code> </example>
        public static object Get(string key) {
            int index = GetIndex(key);
            if (index >= 0) {
                try {
                    ObjCookie cookie = Cookies[index];
                    return Json.Deserialize(cookie.Value, GetterType(cookie.Type));
                } catch {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// obtencion de la cookie almacenada atravez de su identificador,
        /// si esta se encuentra en caso contrario es null o si existion un problema
        /// </summary>
        /// <param name="key">identificador de la cookie (texto)</param>
        /// <param name="value">nuevo valor por si no se encuentra</param>
        /// <returns> devuelve el valor de la cookie como objeto </returns>
        /// <example> <code> int number = Cookie.Get("number", 20) </code> </example>
        public static object Get(string key, object value) {
            var cookie = Get(key);
            if (cookie is null) {
                Add(new ObjCookie(key, value));
                return value;
            } else {
                return cookie;
            }
        }
    }
}
