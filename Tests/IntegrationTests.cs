using System;
using System.Configuration;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace IntegrationTestsSpike
{
    [TestClass]
    [TestCategory("Integration Tests")]
    public class IntegrationTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            var client = new RestClient(this.BaseUrl + "/Sitefinity/Authenticate/OpenID/connect/token");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            // Make sure you have add this client to the authentication config.
            request.AddParameter("auth", "username=admin%40test.test&password=admin%402&grant_type=password&scope=openid&client_id=testApp&client_secret=secret", ParameterType.RequestBody);
            // request.AddParameter("auth", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if ((int)response.StatusCode == 200)
            {
                var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
                accessToken = results.access_token;
            }
            else
                throw new Exception(response.Content);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (this.GetNewsItem(newsId) == HttpStatusCode.OK)
            {
                this.DeleteNews(newsId);
            }
        }

        [TestMethod]
        public void CreateNews()
        {
            newsId = this.CreateNewsItem(Guid.NewGuid().ToString());
        }

        [TestMethod]
        public void PublishNews()
        {
            newsId = this.CreateNewsItem(Guid.NewGuid().ToString());
            this.PublishNews(newsId);
        }

        [TestMethod]
        public void ModifyNews()
        {
            newsId = this.CreateNewsItem(Guid.NewGuid().ToString());
            this.ModifyNews(newsId);
        }

        [TestMethod]
        public void DeleteNews()
        {
            newsId = this.CreateNewsItem(Guid.NewGuid().ToString());
            this.DeleteNews(newsId);
        }

        private Guid CreateNewsItem(string title)
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            var body = new JObject
            {
                { "Title", Guid.NewGuid() },
                { "Content", Guid.NewGuid() }
            };

            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(201, (int)response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            var newsId = results.Id;

            return newsId;
        }

        private void PublishNews(Guid newsId)
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems" + "(" + newsId + ")" + "/operation");
            var publishRequest = new RestRequest(Method.POST);
            publishRequest.AddHeader("authorization", "Bearer " + accessToken);
            publishRequest.AddHeader("x-sf-service-request", "true");
            publishRequest.AddHeader("content-type", "application/json");

            publishRequest.AddParameter("application/json", "{\n    action: \"Publish\",\n    actionParameters: {\n    }\n}", ParameterType.RequestBody);
            IRestResponse publishResponse = client.Execute(publishRequest);

            Assert.AreEqual(200, (int)publishResponse.StatusCode);
        }

        private void ModifyNews(Guid newsId)
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems" + "(" + newsId + ")");
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("authorization", "Bearer " + accessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            var body = new JObject
            {
                { "Summary", "Test Summary" }
            };

            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Assert.AreEqual(204, (int)response.StatusCode);
        }

        private void DeleteNews(Guid newsId)
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems" + "(" + newsId + ")");

            var request = new RestRequest(Method.DELETE);

            request.AddHeader("authorization", "Bearer " + accessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            IRestResponse response = client.Execute(request);
            Assert.AreEqual(204, (int)response.StatusCode);
        }

        private HttpStatusCode GetNewsItem(Guid newsId)
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems" + "(" + newsId + ")");

            var request = new RestRequest(Method.GET);

            request.AddHeader("authorization", "Bearer " + accessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            IRestResponse response = client.Execute(request);

            return response.StatusCode;
        }
        
        private JArray GetAllNewsItems()
        {
            var client = new RestClient(this.BaseUrl + "/sf/system/newsitems");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "Bearer " + accessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            IRestResponse response = client.Execute(request);

            Assert.AreEqual(200, (int)response.StatusCode);
            
            var news = JArray.Parse(response.Content);
            return news;
        }


        private static string accessToken;
        private static Guid newsId;

        private string BaseUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["baseUrl"];
            }
        }

        private string Username
        {
            get
            {
                return ConfigurationManager.AppSettings["username"];
            }
        }

        private string Password
        {
            get
            {
                return ConfigurationManager.AppSettings["password"];
            }
        }
    }
}
