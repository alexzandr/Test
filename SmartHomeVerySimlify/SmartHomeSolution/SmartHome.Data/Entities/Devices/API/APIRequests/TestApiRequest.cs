using System.Runtime.Serialization;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class TestApiRequest : RMBridgeBaseRequest
    {
        private int _code;

        public TestApiRequest(string macCode, int code)
        {
            _code = code;
            mac = macCode;
        }
        public override int api_id { get { return _code; } }

        public override string command
        {
            get { return null; }
        }
        [DataMember]
        public string mac { get; set; }
    }
}