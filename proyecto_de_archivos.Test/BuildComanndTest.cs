using Comands;
using System;
using Xunit;
using TestConsole.utils;
using Shouldly;

namespace proyecto_de_archivos.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestWritteConsole()
        {
            // setup
            var testConsole = new Testconsole();
            var buildCommand = new BuildComand(testConsole);

            // Actbuild
            buildCommand.OnExecute();

            string writtenText = testConsole.GetWrittenContent();

            // Build comand asser
            writtenText.ShouldBe("This is a beta version \r \n");
           

        }
    }
}
