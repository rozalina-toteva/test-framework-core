using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Net;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Blogs;

namespace Tests
{
    /// <summary>
    /// CRUD operations for Blogs.
    /// </summary>
    [TestClass]
    public class BlogsTests
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
        /// Creates a blog and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateBlog()
        {
            var operations = new ContentOperations<Blogs>();

            var blogItem = new Blogs();
            blogsTitle = TestContentPrefix + Guid.NewGuid().ToString();
            blogItem.Title = blogsTitle;

            var response = operations.CreateDraft(blogItem);
            Assert.AreEqual(201, (int)response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(blogItem.Title, results.Title.ToString());

            blogId = results.Id;
            Assert.IsNotNull(blogId);
        }

        /// <summary>
        /// Modifies the Title of a blog and verifies if it is successfully modified.
        /// </summary>
        [TestMethod]
        public void ModifyBlog()
        {
            this.CreateBlog();
            var operations = new ContentOperations<Blogs>();

            Blogs blogItem = new Blogs();
            blogItem.ID = blogId;
            blogItem.Title += "Updated";

            var response = operations.Modify(blogItem);
            Assert.AreEqual(204, (int)response.StatusCode);

            response = operations.GetItem(blogItem);
            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(blogItem.Title, results.Title.ToString());
        }

        /// <summary>
        /// Deletes a created draft blog.
        /// </summary>
        [TestMethod]
        public void DeleteBlog()
        {
            this.CreateBlog();
            Blogs blogItem = new Blogs();
            blogItem.ID = blogId;

            var operations = new ContentOperations<Blogs>();

            var response = operations.Delete(blogItem);

            Assert.AreEqual(204, (int)response.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<Blogs>();
            Blogs blogItem = new Blogs();
            blogItem.ID = blogId;
            if (operations.GetItem(blogItem).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(blogItem);
            }
        }

        private const string TestContentPrefix = "sf_test";
        private static Guid blogId;
        private static string blogsTitle;
    }
}
