using System;

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// metodo para almacenar y/o modificar cookie
        /// <see cref="Set(string, object)"/>
        /// </summary>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <param name="value"></param>
        /// <returns>return al valor propocionado</returns>
        /// <example>
        /// var micooki = Cookie.Set("nombrecooki", "valor") o
        /// Cookie.Set("nombrecooki", "valor")
        /// </example>
        public static object Set(string key, object value) {
            if (String.IsNullOrEmpty(key) || value is null)
                return null;

            ObjCookie cookie = new ObjCookie(key, value);
            int index = GetIndex(key);

            if (index >= 0)
                Edit(cookie, index);
            else
                Add(cookie);
            return value;
        }
    }
}
