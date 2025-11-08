using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class BundleRestorer
    {
        public static void RestorerHandler(string gameFilePath, MainWindow mainWindow)
        {
            if (gameFilePath == null)
            {
                MessageBox.Show($"{gameFilePath} does not exist!");
                return;
            }

            string fileName = Path.GetFileName(gameFilePath);
            string fileFolder = Path.GetDirectoryName(gameFilePath);
            string oldGameFile = Path.GetFullPath($"./backup/{fileName}");
            string newPathDestination = Path.Combine(fileFolder, fileName);

            if (File.Exists(oldGameFile))
            {
                mainWindow.LogMessage("Restorin the selected file!");

                File.Delete(gameFilePath);
                //MessageBox.Show($"Will first delete the file at {gameFilePath}!");
                File.Copy(oldGameFile, newPathDestination);
                //MessageBox.Show($"Then copy over the file at {oldGameFile}!");

                mainWindow.LogMessage("Files Restored to their original state successfully!");

            }
            else
            {
                MessageBox.Show("No original file found!");
            }
        }
    }
}
