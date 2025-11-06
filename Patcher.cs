using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class Patcher
    {
        public static void PatcherHandler(string checkedItem, MainWindow mainWindow)
        {
            string flag = FlagManager.FlagBuilder(checkedItem);

            if (flag == "0")
            {
                MessageBox.Show($"{checkedItem} support has not been implemented!");
                return;
            }

            string exePath = "./PvZ-Replanter.exe";
            string modPath = "./mods";
            string savedList = "./config/checked_items.txt";
            var savedStates = new Dictionary<string, bool>();

            if (File.Exists(savedList))
            {
                foreach (var line in File.ReadAllLines(savedList))
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2 && bool.TryParse(parts[1], out bool state))
                        savedStates[parts[0]] = state;
                }
            }

            if (Directory.Exists(modPath))
            {
                var files = Directory.GetFiles(modPath, "*.emip");
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    bool isChecked = savedStates.ContainsKey(fileName) && savedStates[fileName];
                    
                    if (isChecked == true)
                    {
                        string modFilePath = Path.GetFullPath(modPath);
                        modFilePath = Path.Combine(modFilePath, fileName);
                        string exeArguments = $"patch {flag} \"{modFilePath}\"";

                        if (File.Exists(modFilePath)) {
                            
                            try
                            {
                                var process = new Process();
                                process.StartInfo.FileName = exePath;
                                process.StartInfo.Arguments = exeArguments;
                                process.StartInfo.RedirectStandardOutput = true;
                                process.StartInfo.RedirectStandardError = true;
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.CreateNoWindow = true;

                                process.OutputDataReceived += (s, ev) =>
                                {
                                    if (ev.Data != null)
                                    {
                                        mainWindow.LogMessage(ev.Data);
                                    }
                                };
                                process.ErrorDataReceived += (s, ev) =>
                                {
                                    if (ev.Data != null)
                                    {
                                        mainWindow.LogMessage(ev.Data);
                                    }
                                };

                                process.Start();
                                process.BeginOutputReadLine();
                                process.BeginErrorReadLine();

                                while (!process.HasExited)
                                {
                                    Application.DoEvents();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error running executable!: {ex.Message}");
                            }
                            
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Folder Not Found!");
            }
        }
    }
}
