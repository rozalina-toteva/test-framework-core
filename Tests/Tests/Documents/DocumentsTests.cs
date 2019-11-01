using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.DocumentLibraries;
using TestFrameworkCore.ContentTypes.Documents;

namespace Tests
{
    /// <summary>
    /// Test class with tests related to document libraries and documents.
    /// </summary>
    [TestClass]
    public class DocumentsTests
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
        /// Creates a document library and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateDocumentLibrary()
        {
            var libraryTitle = TestContentPrefix + Guid.NewGuid().ToString();
            DocumentLibraries library = new DocumentLibraries();
            library.Title = libraryTitle.ToString();

            var operations = new ContentOperations<DocumentLibraries>();
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
        public void UploadDocument()
        {
            this.CreateDocumentLibrary();

            Documents document = new Documents();
            document.Title = "TestDocument";
            document.ParentId = libraryId.ToString();
            var operations = new MediaContentOperations<Documents>();
            var response = operations.Upload(document);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            document.ID = results.Id;

            var uploadedDocument = operations.GetItem(document);
            Assert.AreEqual(HttpStatusCode.OK, (int)uploadedDocument.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<DocumentLibraries>();
            DocumentLibraries library = new DocumentLibraries();
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
