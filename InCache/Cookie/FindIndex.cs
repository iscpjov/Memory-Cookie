using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InCache.Cookie
{
    partial class Cookie
    {
        internal static int GetIndex(string key)
        {
            return Cookies.FindIndex(cookie => cookie.Key == key);
        }

    }
}
