using System.Web.Script.Serialization;
using Serialization.Interfaces;

namespace Serialization.Serializers
{
    class JsonDeserializer<TR> : IDeserializer<string, TR>
    {
        public TR Deserialize(string json)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<TR>(json);
        }
    }
}
