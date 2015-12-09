using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.APIRequests
{
    public class LearnCodeRequest: DeviceRequest
    {
        public LearnCodeRequest(string mac_addr)
        {
            mac = mac_addr;
        }
        public override int api_id
        {
            get { return 1002; }
        }

        public override string command
        {
            get { return "learn_code"; }
        }

    }
}
