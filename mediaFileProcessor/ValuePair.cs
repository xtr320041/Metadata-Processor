using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaFileProcessor
{
    public class ValuePair
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public ValuePair(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
