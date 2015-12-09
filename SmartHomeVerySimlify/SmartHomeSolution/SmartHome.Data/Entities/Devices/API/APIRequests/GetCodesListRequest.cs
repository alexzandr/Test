using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class GetCodesListRequest : RMBridgeBaseRequest
    {
        public override int api_id
        {
            get { return 1006; }
        }

        public override string command
        {
            get { return "get_codes"; }
        }
    }
}