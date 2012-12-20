using Autofac;

namespace MRM.Mobile.InfraStructure
{
    public class DependencyResolver
    {
        private static IContainer _container;
        private static DependencyMapper dependencyMapper = new DependencyMapper();

        static DependencyResolver()
        {
            var containerBuilder = new ContainerBuilder();
             containerBuilder = RegisterDependencies(containerBuilder);
            _container = containerBuilder.Build();
        }
        public static ContainerBuilder RegisterDependencies(ContainerBuilder containerBuilder)
        {
            containerBuilder = dependencyMapper.Register(containerBuilder);
            return containerBuilder;
        }

        public static T Resolve<T>()
        {
            var resolve = _container.Resolve<T>();
            return resolve;
        }
    }
}