using System;
using System.Linq;
using Serialization.Data;
using Serialization.Serializers;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.In.ReadLine();

            var logic = type == "Xml"
                ? new Logic(new XmlSerializer<Output>(), new XmlDeserializer<Input>())
                : type == "Json" ? new Logic(new JsonSerializer<Output>(), new JsonDeserializer<Input>()) : null;

            var input = Console.ReadLine();
            var output = logic?.GetSerializedOutput(input);
            Console.WriteLine(output);
        }
    }
}
