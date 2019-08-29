using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class TransientService : ITransientService
    {
        private readonly string _generatedValue;

        public TransientService()
        {
            _generatedValue = Guid.NewGuid().ToString();
        }

        public string GenerateId() => _generatedValue;
    }
}
