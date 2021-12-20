namespace Primary;

using Autofac;
using DBLibrary;

public static class ContainerSetup
{
    public static IContainer Configure()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<Application>().As<IApplication>();
        builder.RegisterType<Database>().As<IDatabase>().As<Database>();
        builder.RegisterType<Logger>().As<ILogger>().As<Logger>();
        builder.RegisterType<DBLib>().As<IDBLib>().As<DBLib>();

        return builder.Build();
    }
}