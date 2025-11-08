
namespace PvZ_Replanter_GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DecompressButton = new Button();
            UnpackButton = new Button();
            checkedListBox1 = new CheckedListBox();
            PatcherButton = new Button();
            RepackerButton = new Button();
            ModButton = new Button();
            OutputLog = new RichTextBox();
            RestorerButton = new Button();
            progressBar1 = new ProgressBar();
            ReplaceButton = new Button();
            SuspendLayout();
            // 
            // DecompressButton
            // 
            DecompressButton.Location = new Point(35, 35);
            DecompressButton.Name = "DecompressButton";
            DecompressButton.Size = new Size(141, 23);
            DecompressButton.TabIndex = 0;
            DecompressButton.Text = "Decompress Bundles";
            DecompressButton.UseVisualStyleBackColor = true;
            DecompressButton.Click += DecompressButton_Click;
            // 
            // UnpackButton
            // 
            UnpackButton.Location = new Point(35, 95);
            UnpackButton.Name = "UnpackButton";
            UnpackButton.Size = new Size(141, 23);
            UnpackButton.TabIndex = 1;
            UnpackButton.Text = "Unpack Assets";
            UnpackButton.UseVisualStyleBackColor = true;
            UnpackButton.Click += UnpackButton_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "spine.bundle", "previews.bundle", "music.bundle", "uialmanac.bundle" });
            checkedListBox1.Location = new Point(548, 20);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 526);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // PatcherButton
            // 
            PatcherButton.Location = new Point(35, 155);
            PatcherButton.Name = "PatcherButton";
            PatcherButton.Size = new Size(141, 23);
            PatcherButton.TabIndex = 3;
            PatcherButton.Text = "Patch Mods to Assets";
            PatcherButton.UseVisualStyleBackColor = true;
            PatcherButton.Click += PatcherButton_Click;
            // 
            // RepackerButton
            // 
            RepackerButton.Location = new Point(35, 215);
            RepackerButton.Name = "RepackerButton";
            RepackerButton.Size = new Size(141, 38);
            RepackerButton.TabIndex = 4;
            RepackerButton.Text = "Repack Assets to Bundle";
            RepackerButton.UseVisualStyleBackColor = true;
            RepackerButton.Click += RepackerButton_Click;
            // 
            // ModButton
            // 
            ModButton.Location = new Point(35, 523);
            ModButton.Name = "ModButton";
            ModButton.Size = new Size(141, 23);
            ModButton.TabIndex = 5;
            ModButton.Text = "Mod List";
            ModButton.UseVisualStyleBackColor = true;
            ModButton.Click += ModButton_Click;
            // 
            // OutputLog
            // 
            OutputLog.Location = new Point(721, 14);
            OutputLog.Name = "OutputLog";
            OutputLog.Size = new Size(205, 532);
            OutputLog.TabIndex = 6;
            OutputLog.Text = "";
            OutputLog.TextChanged += richTextBox1_TextChanged;
            // 
            // RestorerButton
            // 
            RestorerButton.Location = new Point(35, 350);
            RestorerButton.Name = "RestorerButton";
            RestorerButton.Size = new Size(141, 23);
            RestorerButton.TabIndex = 7;
            RestorerButton.Text = "Restore Original Files";
            RestorerButton.UseVisualStyleBackColor = true;
            RestorerButton.Click += RestorerButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(35, 566);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(891, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 8;
            progressBar1.Click += progressBar1_Click;
            // 
            // ReplaceButton
            // 
            ReplaceButton.Location = new Point(35, 290);
            ReplaceButton.Name = "ReplaceButton";
            ReplaceButton.Size = new Size(141, 23);
            ReplaceButton.TabIndex = 9;
            ReplaceButton.Text = "Replace Files";
            ReplaceButton.UseVisualStyleBackColor = true;
            ReplaceButton.Click += ReplaceButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 612);
            Controls.Add(ReplaceButton);
            Controls.Add(progressBar1);
            Controls.Add(RestorerButton);
            Controls.Add(OutputLog);
            Controls.Add(ModButton);
            Controls.Add(RepackerButton);
            Controls.Add(PatcherButton);
            Controls.Add(checkedListBox1);
            Controls.Add(UnpackButton);
            Controls.Add(DecompressButton);
            Name = "MainWindow";
            Text = "Plants. vs Zombies: REPLANTER";
            ResumeLayout(false);
        }

        #endregion

        private Button DecompressButton;
        private Button UnpackButton;
        private CheckedListBox checkedListBox1;
        private Button PatcherButton;
        private Button RepackerButton;
        private Button ModButton;
        private RichTextBox OutputLog;
        private Button RestorerButton;
        private ProgressBar progressBar1;
        private Button ReplaceButton;
    }
}