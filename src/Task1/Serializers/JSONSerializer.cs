using System.Web.Script.Serialization;
using Serialization.Interfaces;

namespace Serialization.Serializers
{
    internal class JsonSerializer<T> : ISerializer<T, string>
    {
        public string Serialize(T obj)
        {
            var serializer = new JavaScriptSerializer();
            var result = serializer.Serialize(obj);

            return result;
        }
    }
}
