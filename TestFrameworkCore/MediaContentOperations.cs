using System.IO;
using RestSharp;
using TestFrameworkCore.ContentTypes;
using TestFrameworkCore.ContentTypes.Documents;
using TestFrameworkCore.ContentTypes.Images;

namespace TestFrameworkCore
{
    public class MediaContentOperations<TMedia>: ContentOperations<TMedia> where TMedia : MediaContent, new()
    {
        public IRestResponse Upload(TMedia item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl;

            if (typeof(TMedia) == typeof(Images))
            {
                return this.ExecuteMediaRequest(Method.POST, requestUrl, item.ParentId, "image/jpeg", imageFile);
            }
            else if (typeof(TMedia) == typeof(Documents))
            {
                return this.ExecuteMediaRequest(Method.POST, requestUrl, item.ParentId, "application/pdf", docFile);
            }

            return null;
        }

        private IRestResponse ExecuteMediaRequest(Method method, string url, string libraryId, string contentType, string file)
        {
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("authorization", "Bearer " + SiteSettings.AccessToken);
            request.AddHeader("x-sf-service-request", "true");
            request.AddHeader("X-Sf-Properties", "{ParentId:\"" + libraryId + "\"}");
            request.AddParameter(contentType, File.ReadAllBytes(file), ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        private readonly string imageFile = Directory.GetCurrentDirectory() + @"\TestResources\Media\mobile-marketing.jpg";
        private readonly string docFile = Directory.GetCurrentDirectory() + @"\TestResources\Media\digital_marketing.pdf";
    }
}
