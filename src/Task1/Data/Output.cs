using System;
using System.Xml.Serialization;

namespace Serialization.Data
{
    [Serializable]
    [XmlRoot]
    public class Output
    {
        public decimal SumResult { get; set; }
        public int MulResult { get; set; }
        public decimal[] SortedInputs { get; set; }
    }
}
