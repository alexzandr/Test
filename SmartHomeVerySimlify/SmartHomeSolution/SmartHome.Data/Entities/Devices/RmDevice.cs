using SmartHome.Core.Entities.Devices.Abstract;

namespace SmartHome.Core.Entities.Devices
{
    public class RmDeviceInfo: BaseDevice
    {
        public string Key { get; set; }
        public string Mac { get; set; }
        public string Password { get; set; }
        public bool Lock { get; set; }
        public bool Subdevice { get; set; }
        public override string ToString()
        {
            return string.Format("{0} [Id: {1}; Type: {2}]", Name, Id, Type);
        }
    }
}
