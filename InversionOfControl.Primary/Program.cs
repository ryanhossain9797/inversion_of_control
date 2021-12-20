namespace Primary;

#region imports
using System;
using Autofac;
using DBLibrary;
#endregion

class Program
{
    public static void Main(string[] args)
    {
        var container = ContainerSetup.Configure();

        using (var scope = container.BeginLifetimeScope())
        {
            var app = scope.Resolve<IApplication>();
            app.Run();
        }

    }
}