namespace Isite
{
    using System.IO.Abstraction;
    

    public class SiteBuilder : ISiteBuilder
    {
        public SiteBuilder(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;

        }

        public void CleanForder(string Folder)
        {

        }
        public void Build(string inputPath, string outputPath)
        {
            
        
        }
    }


}