using System.Diagnostics;

namespace PvZ_Replanter_GUI
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAddGamePath_Click(object sender, EventArgs e)
        {
            string exePath = "./PvZ-Replanter.exe";
            string exeArguments = $"setup \"{GamePath.Text}\"";

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
                        ContextBox.Invoke(new Action(() => ContextBox.AppendText(ev.Data + Environment.NewLine)));
                    }
                };
                process.ErrorDataReceived += (s, ev) =>
                {
                    if (ev.Data != null)
                    {
                        ContextBox.Invoke(new Action(() => ContextBox.AppendText("[ERROR] " + ev.Data + Environment.NewLine)));
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running executable!: {ex.Message}");
            }

            exePath = Path.Combine(GamePath.Text, "Replanted.exe");

            if (File.Exists(exePath))
            {
                MessageBox.Show("Game Executable has been found!");
                
                File.WriteAllText("./config/game_path.txt", GamePath.Text);
                continueButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Game Path!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
