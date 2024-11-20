using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TaqueriaWEB.Utilidades
{
    public class Util
    {
        public static void SweetBox(string ex, string sub, string type, Page pg, Object obj)
        {
            string s = "<SCRIPT languaje='javascript'>swal('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "','" + sub.Replace("\r\n", "\\n").Replace("'", "") + "','" + type + "');</SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}