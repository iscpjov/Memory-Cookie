

namespace InCache.Cookie
{
    partial class Cookie{
        /// <summary>
        /// revisamos que la cookie que se quiere modificar sea diferente si lo son esta lo modifica 
        /// </summary>
        /// <param name="cookie">cookie para revisar si estas no son iguales</param>
        /// <param name="index">pocion de la vieja cookie</param>
        /// <seealso cref="ObjCookie.Equals(object)"/>
        private static void Edit(ObjCookie cookie, int index) {
            bool equals = cookie.Equals(Cookies[index]);
            if (!equals){
                Cookies[index] = cookie;
                _Save();
            }
        }

    }
}
