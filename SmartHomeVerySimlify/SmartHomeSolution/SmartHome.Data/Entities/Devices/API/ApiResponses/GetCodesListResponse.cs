using System.Collections.Generic;
using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.ApiResponses
{
    public class GetCodesListResponse : BaseApiResponse
    {
        public IEnumerable<ApiCodeInformation> list { get; set; }
    }
}