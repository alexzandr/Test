namespace SmartHome.Core.Entities.Devices.API
{
    public interface IApiCodeInformation
    {
        string data { get; set; }
        string name { get; set; }
        string mac { get; set; }
    }
}