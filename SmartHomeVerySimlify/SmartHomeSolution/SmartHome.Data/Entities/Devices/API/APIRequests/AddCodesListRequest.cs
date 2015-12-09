using System.Collections.Generic;
using System.Runtime.Serialization;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    [DataContract]
    public class AddCodesListRequest : RMBridgeBaseRequest
    {
        public AddCodesListRequest(IEnumerable<ApiCodeInformation> codes_list)
        {
            list = codes_list;
        }
        [DataMember]
        IEnumerable<ApiCodeInformation> list { get; set; }
        public override int api_id
        {
            get { return 1007; }
        }
        [DataMember]
        public override string command
        {
            get { return "add_codes"; }
        }
    }
}