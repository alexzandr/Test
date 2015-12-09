using System.Collections.Generic;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.ApiResponses
{
    public class GetRegDevicesResponse : BaseApiResponse
    {
        public IEnumerable<RmDeviceInfo> list { get; set; }
    }
}
