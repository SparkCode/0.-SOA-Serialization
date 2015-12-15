using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    internal static class Utils
    {
        public static decimal Sum(IEnumerable<decimal> array)
        {
            return array.Sum();
        }

        public static int Multiplication(IEnumerable<int> array)
        {
            return array.Aggregate(1, (x, y) => x * y);
        }

        public static IEnumerable<decimal> Concat(IEnumerable<decimal> first, int[] second)
        {
            var secondDecimal = Array.ConvertAll(second, x => (decimal) x);

            return first.Concat(secondDecimal).ToArray();
        }
    }
}
