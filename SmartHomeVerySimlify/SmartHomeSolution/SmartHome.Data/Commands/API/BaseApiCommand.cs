using SmartHome.Core.Entities.Devices.Abstract;
using SmartHome.Services.ServiceConsumer;

namespace SmartHome.Core.Commands.API
{
    public class BaseApiCommand<T, K> : BaseCommand<K> where T : RMBridgeBaseRequest 
    {
        private T Request { get; set; }

        private string Url { get; set; }

        public BaseApiCommand(T request,  string  url)
        {
            Request = request;
            Url = url;
        }
        public override K Execute()
        {
            var serviceRequest = new ServiceConsumer<T, K>(Url,string.Empty);
            return serviceRequest.PostAsync(Request).Result;
        }
    }
}
