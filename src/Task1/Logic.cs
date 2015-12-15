using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization.Data;
using Serialization.Interfaces;

namespace Serialization
{
    public class Logic
    {
        private readonly ISerializer<Output, string> _serializer;
        private readonly IDeserializer<string, Input> _deserializer;

        public Logic(ISerializer<Output, string> serializer, IDeserializer<string, Input> deserializer)
        {
            _serializer = serializer;
            _deserializer = deserializer;
        }

        public string GetSerializedOutput(string json)
        {
            var input = _deserializer.Deserialize(json);
            var output = new Output
                {
                    SumResult = Utils.Sum(input.Sums)*input.K,
                    MulResult = Utils.Multiplication(input.Muls),
                    SortedInputs = Utils.Concat(input.Sums, input.Muls).OrderBy(x => x).ToArray()
                };
            return _serializer.Serialize(output);
        }
    }
}
