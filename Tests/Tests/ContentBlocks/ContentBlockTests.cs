using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Content_Blocks;

namespace Tests
{
    [TestClass]
    public class ContentBlockTests
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
        /// Creates a content block item and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateContentBlock()
        {
            var operations = new ContentOperations<ContentBlocks>();

            var contentBlock = new ContentBlocks();
            ContentBlockTitle = TestContentPrefix + Guid.NewGuid().ToString();
            contentBlock.Title = ContentBlockTitle;
            contentBlock.Content = ContentBlockContent;

            var response = operations.CreateDraft(contentBlock);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(contentBlock.Title, results.Title.ToString());
            Assert.AreEqual(contentBlock.Content, results.Content.ToString());

            contentBlockId = results.Id;
            Assert.IsNotNull(contentBlockId);
        }

        /// <summary>
        /// Modifies the Title of a event item and verifies if it is successfully modified.
        /// </summary>
        [TestMethod]
        public void ModifyContentBlock()
        {
            this.CreateContentBlock();
            var operations = new ContentOperations<ContentBlocks>();

            ContentBlocks contentBlockItem = new ContentBlocks();
            contentBlockItem.ID = contentBlockId;
            contentBlockItem.Title += "Updated";

            var response = operations.Modify(contentBlockItem);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            response = operations.GetItem(contentBlockItem);
            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(contentBlockItem.Title, results.Title.ToString());
        }

        /// <summary>
        /// Deletes a created content block.
        /// </summary>
        [TestMethod]
        public void DeleteContentBlock()
        {
            this.CreateContentBlock();
            ContentBlocks contentBlock = new ContentBlocks();
            contentBlock.ID = contentBlockId;

            var operations = new ContentOperations<ContentBlocks>();

            var response = operations.Delete(contentBlock);

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<ContentBlocks>();
            ContentBlocks contentBlock = new ContentBlocks();
            contentBlock.ID = contentBlockId;
            if (operations.GetItem(contentBlock).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(contentBlock);
            }
           
        }

        private static Guid contentBlockId;
        private static string ContentBlockTitle;
        private static string ContentBlockContent = "The quick brown fox jumps over the lazy dog";
        private const string TestContentPrefix = "sf_test";
    }
}
