using Newtonsoft.Json;
using RestSharp;
using System;
using System.Configuration;

namespace TestFrameworkCore
{
    public static class AuthenticationHelper
    {
        public static void Authenticate()
        {
            var client = new RestClient(SiteSettings.BaseUrl + "/Sitefinity/Authenticate/OpenID/connect/token");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            string authHeaderContent = string.Format("username={0}&password={1}&grant_type={2}&scope={3}&client_id={4}&client_secret={5}",
                SiteSettings.Username, SiteSettings.Password, SiteSettings.GrantType, SiteSettings.Scope, SiteSettings.ClientID, SiteSettings.ClientSecret);

            // Make sure you have add this client to the authentication config.
            request.AddParameter("auth", authHeaderContent, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            if ((int)response.StatusCode == 200)
            {
                var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
                SiteSettings.AccessToken = results.access_token;
            }
            else
            {
                throw new Exception(response.Content);
            }
        }
    }
}
