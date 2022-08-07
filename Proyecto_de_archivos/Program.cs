namespace Proyecto_de_archivos
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            var argumentos = string.Join("; ", args);
            var directorioactual = Directory.GetCurrentDirectory();
            Console.WriteLine(argumentos);
            Console.WriteLine($"Me estoy ejecutando en: {directorioactual}");
        }
    }
}
