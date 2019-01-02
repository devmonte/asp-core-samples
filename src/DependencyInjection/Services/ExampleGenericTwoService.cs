using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public class ExampleGenericTwoService : IExampleGenericService<ExampleTwoModel>
    {
        public void DoSomething(ExampleTwoModel example)
        {
            throw new NotImplementedException();
        }
    }
}
