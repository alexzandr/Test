using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices.API.ApiResponses
{
    public class SendCodeResponse : BaseApiResponse
    {
        public string data { get; set; }
    }
}