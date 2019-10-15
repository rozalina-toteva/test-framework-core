using System.Configuration;

namespace TestFrameworkCore
{
    public static class SiteSettings
    {
        public static string AccessToken { get; set; }

        public static string BaseUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["baseUrl"];
            }
        }

        public static string Username
        {
            get
            {
                return ConfigurationManager.AppSettings["username"];
            }
        }

        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["password"];
            }
        }

        public static string GrantType
        {
            get
            {
                return ConfigurationManager.AppSettings["grant_type"];
            }
        }

        public static string Scope
        {
            get
            {
                return ConfigurationManager.AppSettings["scope"];
            }
        }

        public static string ClientID
        {
            get
            {
                return ConfigurationManager.AppSettings["client_id"];
            }
        }

        public static string ClientSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["client_secret"];
            }
        }
    }
}
