using SmartHome.Core.Entities.Devices.API.APIRequests;

namespace SmartHome.Core.Commands.API
{
    public class TestApiCommand : BaseApiCommand<TestApiRequest, dynamic>
    {
        public TestApiCommand(TestApiRequest request, string url)
            : base(request, url)
        {
        }
    }
}