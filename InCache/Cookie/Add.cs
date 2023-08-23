namespace InCache.Cookie {
    /// <summary>
    /// metodo para agregar una nueva cookie tanto para el json como en memory
    /// </summary>
    /// <param name="key">identificardor de la cookie almacenada</param>
    /// <param name="value">dato a guardar para retulizar cuando este se requiera</param>
    /// <remarks>
    /// la variblae value a persar de ser dynamic en si es una variable jsonelement 
    /// favor de no tratar de acceder fuera de la clase cookie
    /// si auto guardado es true, gardara los cambios en el json
    /// para mas informacion <see cref="Save"/>
    /// </remarks>
    /// <example>
    /// Cookie.Add(key, value);
    /// </example>
    partial class Cookie {
        private static void Add(ObjCookie cookie) {
            Cookies.Add(cookie);
            _Save();
        }

    }
}
