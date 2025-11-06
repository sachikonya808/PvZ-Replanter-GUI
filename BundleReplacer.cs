using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class BundleReplacer
    {
        public static void ReplacerHandler(string gameFilePath, MainWindow mainWindow)
        {
            if (gameFilePath == null)
            {
                MessageBox.Show($"{gameFilePath} does not exist!");
                return;
            }

            string fileName = Path.GetFileName(gameFilePath);
            string fileFolder = Path.GetDirectoryName(gameFilePath);
            string newGameFile = Path.GetFullPath($"./unpacked/{fileName}/{fileName}");
            string newPathDestination = Path.Combine(fileFolder, fileName);

            if (File.Exists(newGameFile) && File.Exists(gameFilePath))
            {
                mainWindow.LogMessage("Starting the file replacement process!");

                File.Delete(gameFilePath);
                File.Move(newGameFile, newPathDestination);

                var files = Directory.GetFiles(@"./unpacked/"+fileName).Where(name => (!name.EndsWith(".decomp")&&!name.EndsWith(".bundle")));
                foreach (var file in files)
                {
                    File.Delete(file);
                }

                mainWindow.LogMessage("Files Replaced Successfully!\nA copy of the original files is located in the \"backup\" folder of this program");

            } else
            {
                MessageBox.Show("No Repacked File Found! or Original Game File Found (Must Replace Manually)");
            }
        }
    }
}
