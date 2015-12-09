using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class SendCodeApiCommand : BaseApiCommand<SendCodeRequest, SendCodeResponse>
    {
        public SendCodeApiCommand(SendCodeRequest request, string url)
            : base(request, url)
        {
        }
    }
}