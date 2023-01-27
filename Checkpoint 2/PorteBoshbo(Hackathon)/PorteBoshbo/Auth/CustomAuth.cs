using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace PorteBoshbo.Auth
{

    public class CustomAuth
    {
        public static bool Authentication(string roles)
        {
            bool authorized = false;
            foreach (string s in roles.Split(',', ' '))
            {
                string email = (string)(HttpContext.Current.Session["email"]);
                string role = (string)(HttpContext.Current.Session["roles"]);
                if (s!="" && role!=null && email!=null && s.ToLower() == role.ToLower())
                    authorized = true;
            }
            return authorized;
        }
    }

}