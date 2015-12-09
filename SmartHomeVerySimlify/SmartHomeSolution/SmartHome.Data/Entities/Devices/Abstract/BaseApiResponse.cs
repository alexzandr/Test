namespace SmartHome.Core.Entities.Devices.Abstract
{
    public abstract class BaseApiResponse
    {
        public int code { get; set; }
        public string msg { get; set; }
    }
}
