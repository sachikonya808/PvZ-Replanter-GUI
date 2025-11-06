using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class Unpacker
    {
        public static void UnpackerHandler(string checkedItem, MainWindow mainWindow)
        {
            string flag = FlagManager.FlagBuilder(checkedItem);

            if (flag == "0")
            {
                MessageBox.Show($"{checkedItem} support has not been implemented!");
                return;
            }

            string exePath = "./PvZ-Replanter.exe";
            string exeArguments = $"unpack {flag}\"";

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
