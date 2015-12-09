namespace SmartHome.Core.Entities.Devices.API
{
    public class ApiCodeInformation : IApiCodeInformation
    {
        public string data { get; set; }
        public string name { get; set; }
        public string mac { get; set; }

        public override string ToString()
        {
            return string.Format("{0} [{1}]", name, mac);
        }
    }
}
