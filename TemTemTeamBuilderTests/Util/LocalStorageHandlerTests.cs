using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemTemTeamBuilder.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemTemTeamBuilder.Util.Tests
{
    [TestClass()]
    public class LocalStorageHandlerTests
    {
        [TestMethod()]
        public void JsonWriterTest()
        {
            LocalStorageHandler.JsonTemDataWriter(API_Interactions.GetAllTemsAsString());
        }

        [TestMethod()]
        public void JsonReaderTest()
        {
            var a = LocalStorageHandler.JsonTemDataReader();
        }

        [TestMethod()]
        public void PropertiesTest()
        {
            var a = LocalStorageHandler.Properties();
            a = null;
        }
    }
}