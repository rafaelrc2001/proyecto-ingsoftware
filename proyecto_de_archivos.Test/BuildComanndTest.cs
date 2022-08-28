using Comands;
using System;
using Xunit;
using TestConsole.utils;
using Shouldly;
using Moq;
using Isite;

namespace proyecto_de_archivos.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestWritteConsole()
        {
            // setup
            var testConsole = new Testconsole();
            var mockSiteBuilder = new Mock<ISiteBuilder>();
            var inputPath ="./Luis_Rosales";
            var outputPath= "./Ariel/";
        
            var buildCommand = new BuildCommand(testConsole, siteBuilder: mockSiteBuilder.Object);
            buildCommand.InputPath = inputPath;
            buildCommand.OutputPath = outputPath;
            

            // Actbuild
            buildCommand.OnExecute();
            mockSiteBuilder.Verify(sb => sb.Build(inputPath,outputPath), Times.Once);

        }
    }
}
