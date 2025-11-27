using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PvZ_Replanter_GUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void LogMessage(string message)
        {
            if (OutputLog.InvokeRequired)
            {
                string hourMinute = DateTime.Now.ToString("HH:mm");
                OutputLog.Invoke(new Action(() => OutputLog.AppendText($"[{hourMinute}]: {message}" + Environment.NewLine)));
            }
            else
            {
                OutputLog.AppendText(message + Environment.NewLine);
            }
        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    Decompresser.DecompressHandler(checkedItem, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }
        }

        private void UnpackButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    Unpacker.UnpackerHandler(checkedItem, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string[] btnGetChecked_Click(object sender, EventArgs e)
        {
            string[] checkedItems = checkedListBox1.CheckedItems
                .OfType<string>()
                .ToArray();

            return checkedItems;
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RepackerButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    Repacker.RepackerHandler(checkedItem, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }


        }

        private void RestorerButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    string gameFilePath = FlagManager.FlagChecker(checkedItem);

                    BundleRestorer.RestorerHandler(gameFilePath, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            ModList modList = new ModList();
            modList.ShowDialog();
        }

        private void PatcherButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    Patcher.PatcherHandler(checkedItem, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            string[] checkedItems = btnGetChecked_Click(sender, e);

            int tasks = checkedItems.Length;
            int progress = 0;
            progressBar1.Value = 0;

            foreach (string checkedItem in checkedItems)
            {
                if (checkedItem == null)
                {
                    MessageBox.Show("No Items Selected");
                    return;
                }
                else
                {
                    string gameFilePath = FlagManager.FlagChecker(checkedItem);

                    BundleReplacer.ReplacerHandler(gameFilePath, this);

                    progress++;
                    progressBar1.Value = (progress * 100) / tasks;
                    Application.DoEvents();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gamePath = File.ReadAllText("./config/game_path.txt");
            gamePath = Path.Combine(gamePath, "Replanted.exe");

            Process.Start(gamePath);
        }
    }
}
