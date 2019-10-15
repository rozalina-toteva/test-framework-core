using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Net;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.News;

namespace Tests
{
    /// <summary>
    /// Contains tests which aim to ensure the bare minimum for the Sitefinity News module.
    /// </summary>
    [TestClass]
    public class NewsTests
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
        /// Creates a draft news item and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateNews()
        {
            var operations = new ContentOperations<News>();

            var newsItem = new News();
            newsTitle = TestContentPrefix + Guid.NewGuid().ToString();
            newsItem.Title = newsTitle;
            newsItem.Content = NewsContent;

            var response = operations.CreateDraft(newsItem);
            Assert.AreEqual(201, (int)response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(newsItem.Title, results.Title.ToString());

            newsId = results.Id;
            Assert.IsNotNull(newsId);
        }

        /// <summary>
        /// Creates a draft news item and then publishes it.
        /// </summary>
        [TestMethod]
        public void PublishNews()
        {
            this.CreateNews();
            var operations = new ContentOperations<News>();

            News newsItem = new News();
            newsItem.ID = newsId;

            var response = operations.GetItem(newsItem);
            Assert.AreEqual(200, (int)response.StatusCode);

            var result = operations.Publish(newsItem);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        /// <summary>
        /// Modifies the Title of a news item and verifies if it is successfully modified.
        /// </summary>
        [TestMethod]
        public void ModifyNews()
        {
            this.CreateNews();
            var operations = new ContentOperations<News>();

            News newsItem = new News();
            newsItem.ID = newsId;
            newsItem.Title += "Updated";

            var response = operations.Modify(newsItem);
            Assert.AreEqual(204, (int)response.StatusCode);

            response = operations.GetItem(newsItem);
            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(newsItem.Title, results.Title.ToString());
        }

        /// <summary>
        /// Deletes a created draft news item.
        /// </summary>
        [TestMethod]
        public void DeleteNews()
        {
            this.CreateNews();
            News newsItem = new News();
            newsItem.ID = newsId;

            var operations = new ContentOperations<News>();

            var response = operations.Delete(newsItem);

            Assert.AreEqual(204, (int)response.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<News>();
            News newsItem = new News();
            newsItem.ID = newsId;
            if (operations.GetItem(newsItem).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(newsItem);
            }
        }

        private const string TestContentPrefix = "sf_test";
        private static Guid newsId;
        private static string newsTitle;
        private static string NewsContent = "The quick brown fox jumps over the lazy dog";
    }
}
