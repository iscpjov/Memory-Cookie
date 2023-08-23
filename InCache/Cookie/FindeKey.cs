

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// verifica si la cookie existe a travez de su identificador 
        /// </summary>
        /// <param name="key">identificador de cookie (texto)</param>
        /// <returns>true si esta existe caso contrario false</returns>
        /// <example> <code>
        /// bool exist = ContainsKey(micookie);
        /// </code> </example>
        public static bool ContainsKey(string key) 
            => GetIndex(key) < 0 ? false : true;
        
    }
}
