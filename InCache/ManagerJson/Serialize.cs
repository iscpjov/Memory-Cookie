using System;
using System.Text.Json;

namespace InCache.ManagerJson {
    partial class Json {
        internal static string Serialize<T>(T value) 
            => JsonSerializer.Serialize(value);

        internal static string Serialize(object value, Type infoType)
            => JsonSerializer.Serialize(value, infoType);
        

    }
}
