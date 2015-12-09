using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class GetRegiteredDevices : RMBridgeBaseRequest
    {
        public override int api_id
        {
            get { return 1000; }
        }

        public override string command
        {
            get { return "registered_devices"; }
        }
    }
}
