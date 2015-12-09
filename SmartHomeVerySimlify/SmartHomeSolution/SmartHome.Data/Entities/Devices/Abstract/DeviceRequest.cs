using System.Runtime.Serialization;

namespace SmartHome.Core.Entities.Devices.Abstract
{
    public abstract class DeviceRequest:RMBridgeBaseRequest
    {
        [DataMember]
        public string mac { get; set; }
    }
}
