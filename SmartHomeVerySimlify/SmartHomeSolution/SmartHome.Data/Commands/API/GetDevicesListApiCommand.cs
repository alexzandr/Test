using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class GetDevicesListApiCommand : BaseApiCommand<GetRegiteredDevices, GetRegDevicesResponse>
    {
        public GetDevicesListApiCommand(GetRegiteredDevices request,  string url)
            : base(request, url)
        {
        }
    }
}