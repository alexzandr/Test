using SmartHome.Core.Entities.Devices.API.APIRequests;
using SmartHome.Core.Entities.Devices.API.ApiResponses;

namespace SmartHome.Core.Commands.API
{
    public class AddCodesApiCommand : BaseApiCommand<AddCodesListRequest, AddCodesResponse>
    {
        public AddCodesApiCommand(AddCodesListRequest request, string url)
            : base(request, url)
        {
        }
    }
}