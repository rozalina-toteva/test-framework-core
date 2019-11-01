using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Net;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Pages;

namespace Tests
{
    /// <summary>
    /// CRUD operations for Pages.
    /// </summary>
    [TestClass]
    public class PagesTests
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
        /// Creates a draft page and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreatePage()
        {
            pageTitle = TestContentPrefix + Guid.NewGuid().ToString();
            Pages page = new Pages();
            page.Title = pageTitle.ToString();

            var operations = new ContentOperations<Pages>();
            var response = operations.CreateDraft(page);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            pageId = results.Id;
            Assert.IsNotNull(pageId);
        }

        /// <summary>
        /// Creates a draft page and then publishes it.
        /// </summary>
        [TestMethod]
        public void PublishPage()
        {
            this.CreatePage();
            var operations = new ContentOperations<Pages>();

            Pages page = new Pages();
            page.ID = pageId;

            var response = operations.GetItem(page);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var result = operations.Publish(page);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Creates a group page.
        /// </summary>
        [TestMethod]
        public void CreateGroupPage()
        {
            Pages page = new Pages();
            page.Title = pageTitle + "Group";
            page.PageType = "1";

            var operations = new ContentOperations<Pages>();
            var response = operations.CreateDraft(page);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            pageId = results.Id;
            Assert.IsNotNull(pageId);
        }

        /// <summary>
        /// Modifies the Title of a page and verifies if it is successfully modified.
        /// </summary>
        [TestMethod]
        public void ModifyPage()
        {
            this.CreatePage();
            var operations = new ContentOperations<Pages>();

            Pages page = new Pages();
            page.Title = pageTitle + "TestPage";
            page.ID = pageId;

            var response = operations.Modify(page);
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

            response = operations.GetItem(page);
            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(page.Title, results.Title.ToString());
        }

        /// <summary>
        /// Deletes a created draft page.
        /// </summary>
        [TestMethod]
        public void DeletePage()
        {
            this.CreatePage();
            Pages page = new Pages();
            page.ID = pageId;

            var operations = new ContentOperations<Pages>();

            var response = operations.Delete(page);

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<Pages>();
            Pages page = new Pages();
            page.ID = pageId;
            if (operations.GetItem(page).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(page);
            }
        }

        private static Guid pageId;
        private static string pageTitle;
        private const string TestContentPrefix = "sf_test";
    }
}
