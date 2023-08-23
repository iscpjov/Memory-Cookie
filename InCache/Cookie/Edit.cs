using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InCache.Cookie
{
    partial class Cookie
    {
        private static void Edit(ObjCookie cookie, int index)
        {
            bool equals = cookie.Equals(Cookies[index]);
            if (!equals)
            {
                Cookies[index] = cookie;
                _Save();
            }
        }

    }
}
