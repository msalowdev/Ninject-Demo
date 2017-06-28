using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.IoC;
using BasicNinjectUse;
using FactoryService;
using FactoryService.Factory;
using FactoryService.Services;
using Ninject;
using NinjectWithDI;
using NinjectWithInterfaces;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicService();
            //BasicNinject();
            //NinjectWithInterface();
            //DependencyInjection();
            //DIWithExtensionModule();
            Factory();
            Console.WriteLine("Done!!!!");
            Console.ReadLine();
        }

        static void BasicService()
        {
            var service = new BasicService.BasicService();

            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "Basic Service Save");
        }

        static void BasicNinject()
        {
            var kernal = new StandardKernel();

            var service = new BasicNinjectService(kernal);


            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "Basic Ninject Save");

        }

        static void NinjectWithInterface()
        {
            //won't work with the ninject.extensions.* config active
            var kernal = new StandardKernel(new AppModule());
            var service = new NinjectWithInterfaceService(kernal);

            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "Ninject With Interfaces");

        }

        static void DependencyInjection()
        {
            var kernal = new StandardKernel(new AppModule());

            var service = kernal.Get<NinjectWithDISevice>();

            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "Dependency Injection Save");
        }

        static void DIWithExtensionModule()
        {
            //won't work if missing the reference to the ninject.extensions.* 
            var kernal = new StandardKernel();

            var service = kernal.Get<NinjectWithDISevice>();

            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "DI With Extension Module Save");
        }

        static void Factory()
        {
            var kernel = new StandardKernel();

            var service = kernel.Get<WrapperService>();

            Console.WriteLine($"Count {service.HowMany()}");
            Console.WriteLine("Ids:");
            Console.WriteLine("-----------------------------");
            foreach (var guid in service.GetAll())
            {
                Console.WriteLine(guid);
            }

            Console.WriteLine("-----------------------------\r\n");

            service.SaveItem(Guid.NewGuid(), "Factory Save");
        }
    }
}
