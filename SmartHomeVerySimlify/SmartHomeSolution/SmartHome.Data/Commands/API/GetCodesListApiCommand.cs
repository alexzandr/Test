using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class GetCodesListApiCommand : BaseApiCommand<GetCodesListRequest, GetCodesListResponse>
    {
        public GetCodesListApiCommand(GetCodesListRequest request, string url)
            : base(request, url)
        {
        }
    }
}