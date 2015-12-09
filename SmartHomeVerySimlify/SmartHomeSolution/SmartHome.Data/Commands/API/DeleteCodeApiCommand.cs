using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class DeleteCodeApiCommand : BaseApiCommand<DeleteCodeRequest, DeleteCodeResponse>
    {
        public DeleteCodeApiCommand(DeleteCodeRequest request, string url)
            : base(request, url)
        {
        }
    }
}