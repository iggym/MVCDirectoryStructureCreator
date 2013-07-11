using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDirectoryStructureCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();

                String projectName = path + "\\" + "ProjectName";
                String models = "Models";
                String views = "Views";
                String controllers = "Controllers";
                //
                // Create new folder 
                //
                Directory.CreateDirectory(projectName);
                //
                // Create more directory 
                //
                Directory.CreateDirectory(projectName + "\\" + models);
                Directory.CreateDirectory(projectName + "\\" + views);
                Directory.CreateDirectory(projectName + "\\" + controllers);

            }
            catch (Exception)
            {
                
                throw;
            }

            
        }
    }
}
