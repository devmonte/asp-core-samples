using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsPattern
{
    public class OptionsExample
    {
        public OptionsExample()
        {
            SomeInteger = 777;
            SomeString = "DefaultValue";
        }

        public int SomeInteger { get; set; }
        public string SomeString { get; set; }
    }
}
