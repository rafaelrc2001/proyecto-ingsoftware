using Comands;
using System;
using Xunit;
using TestConsole.utils;

namespace proyecto_de_archivos.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestWritteConsole()
        {
            var testConsole = new Testconsole();
            var buildCommand = new BuildComand(testConsole);

            buildCommand.OnExecute();

            string writtenText = testConsole.GetWrittenContent();

            Assert.Equal("You execute the build comand\r\n",writtenText);
        }
    }
}
