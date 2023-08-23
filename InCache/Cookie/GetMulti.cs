using InCache.ManagerJson;

namespace InCache.Cookie {
    partial class Cookie {

        /// <summary>
        /// obtencion de la cookie atravez de su identificador
        /// </summary>
        /// <see cref="GetType(string)"/>
        /// <see cref="GetStringType(string)"/>
        /// <typeparam name="T">Tipo de dato que solicitemos</typeparam>
        /// <param name="key">identificador de la cookie (String)</param>
        /// <returns>returno el parametro que se solicita si existe y null si no se encuentra o esta equibocado el T</returns>
        public static object Get<T>(string key) {
            int index = GetIndex(key);
            if (index >= 0) {
                try {
                    ObjCookie cookie = Cookies[index];
                    return Json.Deserialize<T>(cookie.Value);
                } catch {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// obtencion de la cookie atravez de su identificador y si esta no se encuentra la agrega
        /// </summary>
        /// <typeparam name="T">Tipo de dato que solicitemos</typeparam>
        /// <param name="key">identificador de la cookie (String)</param>
        /// <returns>returno el parametro ya sea que se encuentre o se agrege</returns>
        public static object Get<T>(string key, object value) {
            var cookie = Get<T>(key);
            if (cookie is null)
            {
                Add(new ObjCookie(key, value));
                return value;
            }
            else
                return cookie;
        }
    }
}
