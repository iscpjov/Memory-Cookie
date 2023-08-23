

namespace InCache.Cookie {
    partial class Cookie {
        public static bool ContainsKey(string key) {
            return GetIndex(key) < 0 ? false : true;
        }
    }
}
