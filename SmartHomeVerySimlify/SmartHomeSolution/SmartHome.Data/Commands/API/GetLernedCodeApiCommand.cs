using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class GetLernedCodeApiCommand : BaseApiCommand<GetCodeRequest, GetCodeResponse>
    {
        public GetLernedCodeApiCommand(GetCodeRequest request, string url)
            : base(request, url)
        {
        }
    }
}