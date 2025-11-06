using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PvZ_Replanter_GUI
{
    public partial class ModList : Form
    {
        string modPath = "./mods";
        string savedList = "./config/checked_items.txt";

        public ModList()
        {
            InitializeComponent();
            LoadItems();
        }

        private void modsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadItems()
        {
            modsListBox1.Items.Clear();

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
                    modsListBox1.Items.Add(fileName, isChecked);
                }
            }
            else
            {
                MessageBox.Show("Folder Not Found!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            var lines = new List<string>();
            for (int i = 0 ; i < modsListBox1.Items.Count ; i++)
            {
                string fileName = modsListBox1.Items[i].ToString();
                bool isChecked = modsListBox1.GetItemChecked(i);
                lines.Add($"{fileName}|{isChecked}");
            }

            File.WriteAllLines(savedList, lines);

            MessageBox.Show("Selection saved!");
            this.Close();
        }
    }
}
