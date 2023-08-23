
namespace InCache.Cookie {
    partial class Cookie {
        /// <summary>
        /// metodo para remover una cookie almacenada
        /// </summary>
        /// <param name="key">nombre de la coookie almacenada</param>
        /// <remarks>
        /// resiva si el nombre de la cookie existe si esto es verdadero procede eliminarla <see cref="ContainsKey(string)"/> 
        /// si AutoSefe = true gurada los cambios realizados <see cref="Save"/>
        /// </remarks>
        /// <returns>reurna verdadero si esta sepudo eliminar falseo si no </returns>
        public static bool Remove(string key) {
            if (string.IsNullOrEmpty(key))
                return false;

            int index = GetIndex(key);
            if (index >= 0)
            {
                Cookies.RemoveAt(index);
                _Save();
                return true;
            }

            
            return false;
            
            
        }

    }
}
