﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using CA3_D10120047.Models;

namespace CA3_D10120047
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "342557999194546",
                appSecret: "391a3fb89a31e0b9f2791ee9f567548b");

            OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
