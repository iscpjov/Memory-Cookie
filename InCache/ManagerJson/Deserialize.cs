using System;
using System.Text.Json;

namespace InCache.ManagerJson {
    partial class Json {
        internal static object Deserialize<T>(string txt) {
            return JsonSerializer.Deserialize<T>(txt);
        }

        internal static object Deserialize(string txt, Type type) { 
            return JsonSerializer.Deserialize(txt, type);
        }

        internal static object Deserialize(JsonElement je, Type type)
        {
            return je.Deserialize(type);    
        }

        internal static object Deserialize<T>(JsonElement je)
        {
            return je.Deserialize<T>();
        }
    }
}
