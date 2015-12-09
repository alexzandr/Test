using System.Runtime.Serialization;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class DeleteCodeRequest : RMBridgeBaseRequest
    {
        public DeleteCodeRequest(string cmd_name = null)
        {

            name = cmd_name;
        }
   
        public override int api_id
        {
            get { return 1005; }
        }

        public override string command
        {
            get { return "delete_code"; }
        }
        [DataMember]
        public string name { get; set; }
    }
}