using SmartHome.Core.Entities.Devices.API;

namespace SmartHome.Core.Entities.Data
{
    public class RMDeviceCodeEntity
    {
        public RMDeviceCodeEntity()
        {
            
        }
        public RMDeviceCodeEntity(ApiCodeInformation codeInfo)
        { }
        public string CodeData { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
    }
}
