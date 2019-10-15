using Newtonsoft.Json;
using RestSharp;
using TestFrameworkCore.ContentTypes;

namespace TestFrameworkCore
{
    public class ContentOperations<TContent> where TContent : Content, new()
    {
        /// <summary>
        /// Create a draft content item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns the response of the request.<see cref="IRestResponse"/></returns>
        public IRestResponse CreateDraft(TContent item)
        {
            var body = JsonConvert.SerializeObject(item.properties);
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl;

            return this.ExecuteSitefinityRequest(Method.POST, requestUrl, body);
        }

        /// <summary>
        /// Publish an existing content item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns the response of the request.</returns>
        public IRestResponse Publish(TContent item)
        {
            item.properties.Add("application/json", "{\n    action: \"Publish\",\n    actionParameters: {\n    }\n}");
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl + "(" + item.ID + ")" + "/operation";

            return this.ExecuteSitefinityRequest(Method.POST, requestUrl, item.properties);
        }

        /// <summary>
        /// Modify existing item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The response of the request.</returns>
        public IRestResponse Modify(TContent item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl + "(" + item.ID + ")";
            var body = JsonConvert.SerializeObject(item.properties);
            return this.ExecuteSitefinityRequest(Method.PATCH, requestUrl, body);
        }

        /// <summary>
        /// Delete existing item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns the response of the request.</returns>
        public IRestResponse Delete(TContent item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl + "(" + item.ID + ")";

            return this.ExecuteSitefinityRequest(Method.DELETE, requestUrl, null);
        }

        /// <summary>
        /// Gets an existing item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>Returns the response of the request.</returns>
        public IRestResponse GetItem(TContent item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl + "(" + item.ID + ")";

            return this.ExecuteSitefinityRequest(Method.GET, requestUrl, null);
        }

        /// <summary>
        /// Performs a get request against the root endpoint of an item.
        /// </summary>
        /// <example>
        /// Get Metadata
        /// </example>
        /// <param name="item">The item.</param>
        /// <returns>The response of the request.</returns>
        public IRestResponse Get(TContent item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl;

            return this.ExecuteSitefinityRequest(Method.GET, requestUrl, null);
        }

        /// <summary>
        /// Executes rest request with the default headers required for Sitefinity.
        /// </summary>
        /// <param name="method">The Method of the request.</param>
        /// <param name="url">The url.</param>
        /// <param name="body">The body.</param>
        /// <returns>The response of the executed request.</returns>
        private IRestResponse ExecuteSitefinityRequest(Method method, string url, object body)
        {
            var client = new RestClient(url);

            var request = new RestRequest(method);

            request.AddHeader("authorization", "Bearer " + SiteSettings.AccessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("content-type", "application/json");

            if(body != null)
            {
                request.AddParameter("application/json", body.ToString(), ParameterType.RequestBody);
            }

            IRestResponse response = client.Execute(request);

            return response;
        }
    }
}
