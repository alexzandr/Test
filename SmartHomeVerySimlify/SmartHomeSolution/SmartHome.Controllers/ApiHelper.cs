using System.Collections.Generic;
using SmartHome.Core.Commands.API;
using SmartHome.Core.Entities.Devices;
using SmartHome.Core.Entities.Devices.API;
using SmartHome.Core.Entities.Devices.API.APIRequests;

namespace SmartHome.Controllers
{

    //Provided methods call 3d party Web API  
    public static class ApiHelper
    {
        //please ignore naming conventions here
        //we use 3d party api here
        //naming was based on it


        /// <summary>
        /// Get available devices in network
        /// </summary>
        /// <param name="url">Bridge API url</param>
        /// <param name="resultmessage">Store error Message in case of Error</param>
        /// <param name="resultcode">0 means OK, non zero - error</param>
        /// <returns>List of available devices in Smart Home network</returns>
        public static IEnumerable<RmDeviceInfo> GetDevicesList(string url, out string resultmessage, out int resultcode)
        {
            var cmd1 = new RefreshDevicesApiCommand(new RefreshDeviceListRequest(), url);
            cmd1.Execute();
            var cmd2 = new GetDevicesListApiCommand(new GetRegiteredDevices(), url);
            var cmdResult = cmd2.Execute();
            resultcode = cmdResult.code;
            resultmessage = cmdResult.msg;
            return cmdResult.list;
        }
        /// <summary>
        /// Get list of already created codes stored by Bridge API
        /// </summary>
        /// <param name="url">Bridge API url</param>
        /// <param name="resultmessage">Store error Message in case of Error</param>
        /// <param name="resultcode">0 means OK, non zero - error</param>
        /// <returns>List of available codes </returns>
        public static IEnumerable<ApiCodeInformation> GetCodesList(string url, out string resultmessage, out int resultcode)
        {
            var apiCommand = new GetCodesListApiCommand(new GetCodesListRequest(), url);
            var cmdResult = apiCommand.Execute();
            resultcode = cmdResult.code;
            resultmessage = cmdResult.msg;
            return cmdResult.list;
        }
    }
}
