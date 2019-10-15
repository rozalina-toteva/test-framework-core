using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TestFrameworkCore;
using TestFrameworkCore.ContentTypes.Meta;

namespace Tests
{
    [TestClass]
    public class DynamicItemsTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            AuthenticationHelper.Authenticate();
        }


        [TestMethod]
        public void GetDynItems()
        {
            Metadata meta = new Metadata();
            var response = new ContentOperations<Metadata>().Get(meta);

            var metaObj = JsonConvert.DeserializeObject<dynamic>(response.Content);
        }
    }
}
