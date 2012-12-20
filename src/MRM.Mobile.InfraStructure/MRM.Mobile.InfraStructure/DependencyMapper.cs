using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Autofac;
using MRM.Mobile.Service;

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
