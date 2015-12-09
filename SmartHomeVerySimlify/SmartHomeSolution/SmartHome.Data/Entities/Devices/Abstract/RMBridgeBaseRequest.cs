using System.Runtime.Serialization;

namespace SmartHome.Core.Entities.Devices.Abstract
{
    [DataContract]
    public abstract class RMBridgeBaseRequest
    {
        [DataMember]
        public virtual int api_id {
            get { return 0; }
        }
        [DataMember]
        public virtual string command
        {
            get { return string.Empty; }
        }
    }
}
