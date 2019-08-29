using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class SuperService : ISuperService
    {
        private readonly ITransientService _transientService;
        private readonly IScopedService _scopedService;
        private readonly ISingletonService _singletonService;

        public SuperService(ITransientService transientService, IScopedService scopedService, ISingletonService singletonService)
        {
            _transientService = transientService;
            _scopedService = scopedService;
            _singletonService = singletonService;
        }


        public string GenerateValue()
        {
            var singleton = _singletonService.GenerateId();
            var scoped = _scopedService.GenerateId();
            var transient = _transientService.GenerateId();
            return $"\n singleton: {singleton} \n scoped {scoped} \n transient {transient}";
        }
    }
}
