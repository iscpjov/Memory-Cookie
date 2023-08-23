namespace InCache.Cookie {
    
    partial class Cookie {
        
        /// <summary>
        /// Agregamos la nueva cookie temporal y permanente
        /// </summary>
        /// <param name="cookie">el objeto donde se almacena el nuevo dado</param>
        /// <seealso cref="_Save"/>
        private static void Add(ObjCookie cookie) {
            Cookies.Add(cookie);
            _Save();
        }

    }
}
