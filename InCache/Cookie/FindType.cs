using System;
using System.Reflection;


namespace InCache.Cookie
{
    partial class Cookie
    {

        public static string GetType(string key)
        {
            int index = GetIndex(key);
            if (index >= 0)
            {
                //return Cookies[index].Type;
            }

            return default;
        }

        internal static Type GetterType(string type)
        {
            Type result = Type.GetType(type);
            if (result == null)
            {
                result = AssemblyType(type);
            }

            return result;
        }

        internal static Type AssemblyType(string FullName)
        {
            var types = FullName.Split('.');
            Assembly ensamblado = Assembly.Load(types[0]); 
            return ensamblado.GetType(FullName);
        }

    }
}
