using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EFLibrary.Network
{
    public class Utility
    {
        public static string GetClientIP()
        {
            return HttpContext.Current.Request.UserHostAddress;

        }  
    }
}
