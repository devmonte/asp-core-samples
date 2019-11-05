using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT.Services
{
    public class ExampleService : IExampleService
    {
        public int GetValue()
        {
            return 777;
        }
    }
}
