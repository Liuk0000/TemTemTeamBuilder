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
    public class ConversionsTests
    {
        [TestMethod()]
        public void GetTemsListTest()
        {
            var a  = Conversions.GetTemsList(LocalStorageHandler.JsonTemDataReader());
            a = null;
        }
    }
}