namespace Comands
{
    using McMaster.Extensions.CommandLineUtils;

    public class BuildComand
    {
        private readonly IConsole console;

        public BuildComand(IConsole console)
        {
            this.console = console;
        }

        public int OnExecute()
        {
            this.console.WriteLine("You execute the build comand");
            return 0;
        }
    }
}
