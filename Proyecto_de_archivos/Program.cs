namespace Proyecto_de_archivos
{    
    using comands;
    using McMaster.Extensions.CommandLineUtils;
    

    [Command("Comando_de_archivos")]
    [VersionOptionFromMember("--version", MemberName= nameof(ProyectoVersion))]
    [Subcommand(typeof(BuildComand))]

    public class Program
    {
        public string ProyectoVersion { get; } = "0.0.0";

        public static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }

        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
            return 0;
        }
    }
}
