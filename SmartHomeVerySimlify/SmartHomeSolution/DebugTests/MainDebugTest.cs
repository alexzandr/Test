using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHome.Core.Commands.API;
using SmartHome.Core.Entities.Devices.API.APIRequests;

namespace DebugTests
{
    [TestClass]
    public class MainDebugTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //please pay attention it's not unit test - it's for Debug testing only
            var url = "http://10.0.1.5:7474/";
            var cmd1 = new RefreshDevicesApiCommand(new RefreshDeviceListRequest(), url);
            var result_cmd1 = cmd1.Execute();
            Assert.AreEqual(result_cmd1.code,0);
        }
    }
}
