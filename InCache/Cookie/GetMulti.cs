using InCache.ManagerJson;
using System.Text.Json;

namespace InCache.Cookie{
    partial class Cookie{
        /// <summary>
        /// metodo para su obtencion (convercion) para que se puedan utilizar
        /// <see cref="Getter(string)"/>
        /// <see cref="Add(string, dynamic)"/>
        /// </summary>
        /// <typeparam name="T">tipo de dato a convertir</typeparam>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <returns>
        /// devuelve el valor solicitado si este existe
        /// encaso contrarrio devuelve null
        /// </returns>
        /// <example>Cookie.Get<List<int>>("micookie")</example>

        public static object Get<T>(string key) {
            int index = GetIndex(key);
            if (index >= 0)
            {
                ObjCookie cookie = Cookies[index];
                return Json.Deserialize<T>(cookie.Value);
            }
            return null;
        }
        /// <summary>
        /// metodo para obtener el valor de la cookie almacena y si esta no existe lo añade
        /// <see cref="Getter(string)"/>
        /// <see cref="Add(string, dynamic)"/>
        /// </summary>
        /// <typeparam name="T">tipo de dato a convertir</typeparam>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <param name="value">valor de la cookie</param>
        /// <returns>devuelve el valor ya sea el almacenado o el nuevo valor si esta no existe</returns>
        /// <example>Cookie.Get<List<int>>("micookie", new list<int>{1,2,3,4,5,6,7,8})</example>
        public static object Get<T>(string key, dynamic value) {
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
