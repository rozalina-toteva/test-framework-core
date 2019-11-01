using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.ImageLibraries;
using TestFrameworkCore.ContentTypes.Images;

namespace Tests
{
    /// <summary>
    /// Contains tests related to image albums and images.
    /// </summary>
    [TestClass]
    public class ImagesTests
    {
        /// <summary>
        /// Authenticates the rest requests.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            AuthenticationHelper.Authenticate();
        }

        /// <summary>
        /// Creates an image library and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateImageLibrary()
        {
            var libraryTitle = TestContentPrefix + Guid.NewGuid().ToString();
            ImageLibraries library = new ImageLibraries();
            library.Title = libraryTitle.ToString();

            var operations = new ContentOperations<ImageLibraries>();
            var response = operations.CreateDraft(library);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            libraryId = results.Id;
            Assert.IsNotNull(libraryId);
        }

        /// <summary>
        /// Uploads an image.
        /// </summary>
        [TestMethod]
        public void UploadImage()
        {
            this.CreateImageLibrary();

            Images image = new Images();
            image.Title = "TestImage";
            image.ParentId = libraryId.ToString();
            var operations = new MediaContentOperations<Images>();
            var response = operations.Upload(image);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            image.ID = results.Id;

            var uploadedImage = operations.GetItem(image);
            Assert.AreEqual(HttpStatusCode.OK, (int)uploadedImage.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<ImageLibraries>();
            ImageLibraries library = new ImageLibraries();
            library.ID = libraryId;
            if (operations.GetItem(library).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(library);
            }
        }

        private static Guid libraryId;
        private readonly string TestContentPrefix = "sf_test";
    }
}
