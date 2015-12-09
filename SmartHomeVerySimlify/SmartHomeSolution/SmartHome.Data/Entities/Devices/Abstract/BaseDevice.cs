namespace SmartHome.Core.Entities.Devices.Abstract
{
    public abstract class BaseDevice
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
