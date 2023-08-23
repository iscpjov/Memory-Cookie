using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// obtencion de indice donde se encuentra la cookie
        /// </summary>
        /// <param name="key">identificador de la cookie (texto)</param>
        /// <returns>el indici donde se almacena la cookie</returns>
        private static int GetIndex(string key)
            => Cookies.FindIndex(cookie => cookie.Key == key);
        

    }
}
