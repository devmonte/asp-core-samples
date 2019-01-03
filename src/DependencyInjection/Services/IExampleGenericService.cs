using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public interface IExampleGenericService<T> where T : IExampleModel
    {
        void DoSomething(T example);
    }
}
