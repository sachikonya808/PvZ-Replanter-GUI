using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class FlagManager
    {
        public static string FlagBuilder(string file)
        {   
            if (file == "spine.bundle")
            {
                return "-spine";
            }
            if (file == "previews.bundle")
            {
                return "-preview";
            }

            return "0";
        }

        public static string FlagChecker(string command)
        {
            string configPath = "./config/config.json";

            string flags = FlagBuilder(command);

            if (File.Exists(configPath))
            {
                string jsonString = File.ReadAllText(configPath);
                var config = JsonSerializer.Deserialize<Config>(jsonString);

                if (config != null)
                {
                    if (flags.Contains("-spine"))
                    {
                        return config.spine_bundle_location;
                    }

                    if (flags.Contains("-preview"))
                    {
                        return config.preview_bundle_location;
                    }
                }
            }

            Console.WriteLine("No config file! Delete the config folder and restart the program");
            return "0";
        }
        class Config
        {
            public string spine_bundle_location { get; set; }
            public string preview_bundle_location { get; set; }
        }
    }
}
