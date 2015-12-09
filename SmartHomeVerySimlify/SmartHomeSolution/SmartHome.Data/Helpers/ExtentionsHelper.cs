using System.IO;
using System.Xml.Serialization;

namespace SmartHome.Core.Helpers
{
    public static class ExtentionsHelper
    {
        public static string SerializeObject<T>(this T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            var textWriter = new StringWriter();

            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }
    }
}
