namespace HexArch.Infrastructure.Modules
{
    using Autofac;
    using HexArch.Application;

    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in HexArch.Application
            //
            builder.RegisterAssemblyTypes(typeof(ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
