using System;
using System.Reflection;

namespace InCache.Cookie {
    partial class Cookie {

        /// <summary>
        /// obtencion de la cookie almacenada
        /// </summary>
        /// <param name="key">identificador de la cookie (texto)</param>
        /// <returns> nos devuelve el tipo de cookie almacenado en texto  </returns>
        /// <example> <code> String type = Cookie.GetStringType("micookie") </code> </example>
        public static string GetStringType(string key) {
            int index = GetIndex(key);
            if (index >= 0)
                return Cookies[index].Type;
            return default;
        }

        /// <summary>
        /// obtencion de la cookie almacenada
        /// </summary>
        /// <param name="key"> identificador de la cookie (texto) </param>
        /// <returns> nos devuelve el tipo de cookie almacenado en Type </returns>
        /// <example> <code> Type type = Cookie.GetType("micookie")</code> </example>
        public static Type GetType(string key) { 
            int index = GetIndex(key);
            if (index >= 0)
                return GetterType(Cookies[index].Type);
            return default;
        }

        /// <summary>
        /// conversion del String a Type
        /// </summary>
        /// <param name="type">el tipo de dato en String</param>
        /// <returns>devulve un Type</returns>
        private static Type GetterType(string type) {
            Type result = Type.GetType(type);
            if (result == null)
                result = AssemblyType(type);
            return result;
        }

        private static Type AssemblyType(string FullName) {
            var types = FullName.Split('.');
            Assembly ensamblado = Assembly.Load(types[0]); 
            return ensamblado.GetType(FullName);
        }

    }
}
