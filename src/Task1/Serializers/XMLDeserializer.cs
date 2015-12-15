using System.Xml;
using System.Xml.Serialization;
using Serialization.Interfaces;

namespace Serialization.Serializers
{
    internal class XmlDeserializer<TR> : IDeserializer<string, TR>
    {
        public TR Deserialize(string xml)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            using (var xmlReader = new XmlNodeReader(xmlDocument))
            {
                var serializer = new XmlSerializer(typeof(TR));
                return (TR) serializer.Deserialize(xmlReader);
            }
        }
    }
}
