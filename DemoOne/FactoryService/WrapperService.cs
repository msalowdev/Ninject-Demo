using System;
using System.Collections.Generic;
using FactoryService.Factory;
using FactoryService.Services;

namespace FactoryService
{
    public class WrapperService
    {
        private readonly IServiceFactory _serviceFactory;

        public WrapperService(IServiceFactory serviceFactory)
        {
            if (serviceFactory == null) throw new ArgumentNullException(nameof(serviceFactory));
            _serviceFactory = serviceFactory;
        }

        public int HowMany()
        {
            var counterService = _serviceFactory.Create<ICounterService>();
            return counterService.HowMany();
        }
        public List<Guid> GetAll()
        {
            var actionService = _serviceFactory.Create<IActionService>();

            return actionService.GetIds();
        }

        public void SaveItem(Guid id, string name)
        {
            var actionService = _serviceFactory.Create<IActionService>();

            actionService.SaveItem(id, name);
        }


    }
}
