using System.Runtime.Serialization;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class GetCodeRequest : DeviceRequest
    {
        public GetCodeRequest(string mac_addr, string cmd_name = null)
        {
            mac = mac_addr;
            name = cmd_name;
        }
        public override int api_id
        {
            get { return 1003; }
        }

        public override string command
        {
            get { return "get_code"; }
        }
        [DataMember]
        public string name { get; set; }
    }
}