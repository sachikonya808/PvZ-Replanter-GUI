namespace PvZ_Replanter_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!Directory.Exists("./config")) {

                using (var setupForm = new Setup())
                {
                    if (setupForm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new MainWindow());
                    } else
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                Application.Run(new MainWindow());
            }
        }
    }
}