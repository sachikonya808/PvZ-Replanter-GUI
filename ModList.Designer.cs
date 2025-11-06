namespace PvZ_Replanter_GUI
{
    partial class ModList
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
            modsListBox1 = new CheckedListBox();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // modsListBox1
            // 
            modsListBox1.FormattingEnabled = true;
            modsListBox1.IntegralHeight = false;
            modsListBox1.Location = new Point(47, 32);
            modsListBox1.Name = "modsListBox1";
            modsListBox1.ScrollAlwaysVisible = true;
            modsListBox1.Size = new Size(503, 544);
            modsListBox1.TabIndex = 0;
            modsListBox1.SelectedIndexChanged += modsListBox1_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(274, 586);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ModList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 621);
            Controls.Add(SaveButton);
            Controls.Add(modsListBox1);
            Name = "ModList";
            Text = "Mod List";
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox modsListBox1;
        private VScrollBar vScrollBar1;
        private Button SaveButton;
    }
}