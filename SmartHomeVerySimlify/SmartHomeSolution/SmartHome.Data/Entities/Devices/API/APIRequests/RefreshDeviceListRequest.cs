using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class RefreshDeviceListRequest : RMBridgeBaseRequest
    {
        public override int api_id
        {
            get { return 1001; }
        }

        public override string command
        {
            get { return "probe_devices"; }
        }
    }
}
