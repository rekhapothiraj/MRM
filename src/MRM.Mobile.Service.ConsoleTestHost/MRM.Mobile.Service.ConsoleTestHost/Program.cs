using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Wcf;
using MRM.Mobile.Data;
using MRM.Mobile.DomainModel.Models;

namespace MRM.Mobile.Service.ConsoleTestHost
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                //var svcHost = new ServiceHost(typeof(MRM.Mobile.Service.DataService));

                //svcHost.Open();

                //Console.WriteLine("Simple Service is hosted");
                //Console.ReadKey();


                ContainerBuilder builder = new ContainerBuilder();
                builder.RegisterType<MRMContext>().As<IMRMContext>();
                builder.Register(x => new UnitOfWork((MRMContext)x.Resolve<IMRMContext>())).As<IUnitOfWork>();
                builder.Register(c => new SiteRepository((UnitOfWork)c.Resolve<IUnitOfWork>())).As<IRepository<Site>>();
                builder.Register(c => new DataService(c.Resolve<IRepository<Site>>())).As<IDataService>();

                using (IContainer container = builder.Build())
                {
                    ServiceHost host = new ServiceHost(typeof(DataService));

                    IComponentRegistration registration;
                    if (!container.ComponentRegistry.TryGetRegistration(new TypedService(typeof(IDataService)), out registration))
                    {
                        Console.WriteLine("The service contract has not been registered in the container.");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }

                    host.Description.Behaviors.Add(new AutofacDependencyInjectionServiceBehavior(container, typeof(DataService), registration));
                    host.Open();

                    Console.WriteLine("The host has been opened.");
                    Console.ReadLine();

                    host.Close();
                    Environment.Exit(0);
                }

            }
            catch (System.Exception oEx)
            {
                Console.WriteLine("Exception: " + oEx.Message);
            }
            
           
        }
    
    }
}
