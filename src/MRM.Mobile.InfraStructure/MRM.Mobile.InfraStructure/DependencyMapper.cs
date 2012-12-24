using System.ServiceModel;
using Autofac;

namespace MRM.Mobile.InfraStructure
{
    public class DependencyMapper
    {
        public ContainerBuilder Register(ContainerBuilder builder)
        {
          
            builder.Register(c => new ChannelFactory<MRM.Mobile.Service.IDataService>("DataServiceTcpEndpoint").CreateChannel()).As<MRM.Mobile.Service.IDataService>().InstancePerDependency();
            return builder;

        }
    }
}
