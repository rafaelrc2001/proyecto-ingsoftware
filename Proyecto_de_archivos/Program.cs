namespace Proyecto_de_archivos
{
    using Comands;
    using McMaster.Extensions.CommandLineUtils;
    using Microsoft.Extensions.DependencyInjection;

    [Command("Comando_de_archivos")]
    [VersionOptionFromMember("--version", MemberName= nameof(ProyectoVersion))]
    [Subcommand(typeof(BuildComand))]

    public class Program
    {
        public string ProyectoVersion { get; } = "0.0.2";

        public static int Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton<IConsole>(PhysicalConsole.Singleton)
                .BuildServiceProvider();

            var app = new CommandLineApplication<Program>();
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(services);

            return app.Execute(args);
        }

        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
            return 0;
        }
    }
}
