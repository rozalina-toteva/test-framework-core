using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Net;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Blogs;
using TestFrameworkCore.ContentTypes.Posts;

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
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

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
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);

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

            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [TestMethod]
        public void CreateBlogPost()
        {
            this.CreateBlog();

            Posts post = new Posts();
            postTitle = TestContentPrefix + Guid.NewGuid().ToString();
            post.Title = blogsTitle;
            post.ParentId = blogId.ToString();
            post.Content = PostContent;

            var operations = new ContentOperations<Posts>();
            operations.CreateDraft(post);

            var response = operations.CreateDraft(post);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(post.Title, results.Title.ToString());

            postId = results.Id;
            Assert.IsNotNull(blogId);

            response = operations.Publish(post);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public void ModifyBlogPost()
        {

        }

        [TestMethod]
        public void DeleteBlogPost()
        {

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
        private static Guid postId;
        private static string blogsTitle;
        private static string postTitle;
        private static string PostContent = "The quick brown fox jumps over the lazy dog";
    }
}
