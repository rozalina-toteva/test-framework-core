using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Net;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Calendars;
using TestFrameworkCore.ContentTypes.Events;
using TestFrameworkCore.ContentTypes.News;

namespace Tests
{
    /// <summary>
    /// CRUD operations for News.
    /// </summary>
    [TestClass]
    public class EventsTests
    {
        /// <summary>
        /// Authenticates the rest requests.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            AuthenticationHelper.Authenticate();
        }

        [TestMethod]
        public void CreateCalendar()
        {
            var operations = new ContentOperations<Calendars>();

            var calendar = new Calendars();
            calendarTitle = TestContentPrefix + Guid.NewGuid().ToString();
            calendar.Title = calendarTitle;
            calendar.Color = "Blue";

            var response = operations.CreateDraft(calendar);
            Assert.AreEqual(201, (int)response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(calendar.Title, results.Title.ToString());
            Assert.AreEqual(calendar.Color, results.Color.ToString());

            calendarId = results.Id;
            Assert.IsNotNull(eventId);
        }

        /// <summary>
        /// Creates a draft event item and validates the successful creation.
        /// </summary>
        [TestMethod]
        public void CreateDraftEvent()
        {
            this.CreateCalendar();

            var operations = new ContentOperations<Events>();

            var eventItem = new Events();
            eventTitle = TestContentPrefix + Guid.NewGuid().ToString();
            eventItem.Title = eventTitle;
            eventItem.Content = EventContent;
            eventItem.EventStart = DateTime.UtcNow.ToString("o");
            eventItem.EventEnd = DateTime.UtcNow.AddHours(2).ToString("o");
            eventItem.ParentId = calendarId.ToString();

            var response = operations.CreateDraft(eventItem);
            Assert.AreEqual(201, (int)response.StatusCode);

            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(eventItem.Title, results.Title.ToString());
            Assert.AreEqual(eventItem.Content, results.Content.ToString());

            eventId = results.Id;
            Assert.IsNotNull(eventId);
        }

        /// <summary>
        /// Creates a draft event item and then publishes it.
        /// </summary>
        [TestMethod]
        public void PublishEvent()
        {
            this.CreateDraftEvent();
            var operations = new ContentOperations<Events>();

            Events eventItem = new Events();
            eventItem.ID = eventId;

            var response = operations.GetItem(eventItem);
            Assert.AreEqual(200, (int)response.StatusCode);

            var result = operations.Publish(eventItem);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        /// <summary>
        /// Modifies the Title of a event item and verifies if it is successfully modified.
        /// </summary>
        [TestMethod]
        public void ModifyEvent()
        {
            this.CreateDraftEvent();
            var operations = new ContentOperations<Events>();

            Events eventItem = new Events();
            eventItem.ID = eventId;
            eventItem.Title += "Updated";

            var response = operations.Modify(eventItem);
            Assert.AreEqual(204, (int)response.StatusCode);

            response = operations.GetItem(eventItem);
            var results = JsonConvert.DeserializeObject<dynamic>(response.Content);
            Assert.AreEqual(eventItem.Title, results.Title.ToString());
        }

        /// <summary>
        /// Deletes a created draft event item.
        /// </summary>
        [TestMethod]
        public void DeleteEvent()
        {
            this.CreateDraftEvent();
            Events eventItem = new Events();
            eventItem.ID = eventId;

            var operations = new ContentOperations<Events>();

            var response = operations.Delete(eventItem);

            Assert.AreEqual(204, (int)response.StatusCode);
        }

        /// <summary>
        /// Cleans up any leftover data.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            var operations = new ContentOperations<Events>();
            Events eventItem = new Events();
            eventItem.ID = eventId;
            if (operations.GetItem(eventItem).StatusCode == HttpStatusCode.OK)
            {
                operations.Delete(eventItem);
            }

            var calOperations = new ContentOperations<Calendars>();
            Calendars calendarItem = new Calendars();
            eventItem.ID = eventId;
            if (calOperations.GetItem(calendarItem).StatusCode == HttpStatusCode.OK)
            {
                calOperations.Delete(calendarItem);
            }
        }

        private const string TestContentPrefix = "sf_test";
        private static Guid eventId;
        private static Guid calendarId;
        private static string eventTitle;
        private static string calendarTitle;
        private static string EventContent = "The quick brown fox jumps over the lazy dog";
    }
}
