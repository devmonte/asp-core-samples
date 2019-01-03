using DependencyInjection.Models;

namespace DependencyInjection.Services
{
    public class ExampleOneService : IExampleService, IExampleModel
    {
        public void DoSomething()
        {
            throw new System.NotImplementedException();
        }
    }
}