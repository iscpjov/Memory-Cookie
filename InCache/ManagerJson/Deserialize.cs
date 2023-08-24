using System;
using System.Text.Json;

namespace InCache.ManagerJson {
    partial class Json {
        internal static object Deserialize<T>(string txt) 
            => JsonSerializer.Deserialize<T>(txt);
        
        internal static object Deserialize(string txt, Type type) 
            => JsonSerializer.Deserialize(txt, type);
        
        internal static object Deserialize(JsonElement je, Type type)
            => je.Deserialize(type);    
        
        internal static object Deserialize<T>(JsonElement je)
            => je.Deserialize<T>();
        
    }
}
