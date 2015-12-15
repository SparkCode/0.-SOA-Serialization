using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Serialization.Interfaces;

namespace Serialization.Serializers
{
    internal class XmlSerializer<T> : ISerializer<T, string>
    {
        public string Serialize(T obj)
        {
            using (var stringWriter = new StringWriter())
            {
                var xmlWriterSettings = new XmlWriterSettings {OmitXmlDeclaration = true};
                var xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);
                var serializer = new XmlSerializer(typeof(T));
                var ns = new XmlSerializerNamespaces();
                ns.Add("", ""); // remove xml namespace
                serializer.Serialize(xmlWriter, obj, ns);
                return stringWriter.ToString();
            }
        }
    }
}
