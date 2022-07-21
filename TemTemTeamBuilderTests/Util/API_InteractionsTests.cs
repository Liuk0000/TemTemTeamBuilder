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
    public class API_InteractionsTests
    {
        [TestMethod()]
        public void GetAllTemsTest()
        {
            var a = API_Interactions.GetAllTemsAsString();

            

            Console.WriteLine(a);
        }
    }
}