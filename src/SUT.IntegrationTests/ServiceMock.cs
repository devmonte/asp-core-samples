using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SUT.Services;

namespace SUT.IntegrationTests
{
    public class ServiceMock : IExampleService
    {
        public int GetValue()
        {
            return 10_000;
        }
    }
}
