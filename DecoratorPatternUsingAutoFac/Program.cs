using Autofac;

using DecoratorPatternUsingAutoFac;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<ConsoleLoggerService>().As<ILoggerService>().InstancePerDependency();

        // Register the decorator
        builder.RegisterDecorator<TimestampLoggerDecorator, ILoggerService>();

        var container = builder.Build();

        var logger = container.Resolve<ILoggerService>();

        logger.Log("Hello, Autofac!");

        Console.ReadLine();
    }
}