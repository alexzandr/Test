using System.Runtime.Serialization;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class SendCodeRequest : DeviceRequest
    {
        public SendCodeRequest(string cmd_name = null)
        {
            mac = null;
            name = cmd_name;
        }
        public SendCodeRequest(string mac_addr, string code_data)
        {
            mac = mac_addr;
            data = code_data;
            //name = string.Empty;
        }
        public override int api_id
        {
            get { return 1004; }
        }

        public override string command
        {
            get { return "send_code"; }
        }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string data { get; set; }
    }

}