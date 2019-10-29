using System.IO;
using RestSharp;
using TestFrameworkCore.ContentTypes;
using TestFrameworkCore.ContentTypes.Documents;
using TestFrameworkCore.ContentTypes.Images;

namespace TestFrameworkCore
{
    public class MediaContentOperations<TMedia>: ContentOperations<TMedia> where TMedia : MediaContent, new()
    {
        /// <summary>
        /// Uploads media item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The resonse.</returns>
        public IRestResponse Upload(TMedia item)
        {
            var requestUrl = SiteSettings.BaseUrl + item.EndpointUrl;

            if (typeof(TMedia) == typeof(Images))
            {
                return this.UploadImage(Method.POST, requestUrl, item.ParentId);
            }
            if (typeof(TMedia) == typeof(Documents))
            {
                return this.UploadDocument(Method.POST, requestUrl, item.ParentId);
            }

            return null;
        }

        private IRestResponse UploadImage(Method method, string url, string libraryId)
        {
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("authorization", "Bearer " + SiteSettings.AccessToken);
            request.AddHeader("X-Sf-Properties", "{ParentId:\"" + libraryId + "\", \"DirectUpload\":true, \"Title\":\"" + ImageTitle + "\"}");
            request.AddParameter("image/jpeg", File.ReadAllBytes(imageFilePath), ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response;
        }

        private IRestResponse UploadDocument(Method method, string url, string libraryId)
        {
            var client = new RestClient(url);
            var request = new RestRequest(method);
            request.AddHeader("authorization", "Bearer " + SiteSettings.AccessToken);
            request.AddHeader("Content-Type", "application/pdf");
            request.AddHeader("X-File-Name", docFullName);
            request.AddHeader("X-Sf-Properties", "{ParentId:\"" + libraryId + "\", \"DirectUpload\":true, \"Title\":\"" + DocumentTitle + "\"}");
            request.AddFile("test", docFilePath);

            IRestResponse response = client.Execute(request);

            return response;
        }

        private const string DocumentTitle = "digital_marketing";
        private const string DocumentExtension = ".pdf";
        private const string ImageTitle = "mobile-marketing";

        private readonly string docFullName = string.Concat(DocumentTitle, DocumentExtension);
        private readonly string imageFilePath = Directory.GetCurrentDirectory() + @"\TestResources\Media\mobile-marketing.jpg";
        private readonly string docFilePath = string.Concat(Directory.GetCurrentDirectory(), @"\TestResources\Media\", DocumentTitle, DocumentExtension);
    }
}
