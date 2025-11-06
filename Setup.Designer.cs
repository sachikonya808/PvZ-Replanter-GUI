namespace PvZ_Replanter_GUI
{
    partial class Setup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GamePath = new TextBox();
            BtnAddGamePath = new Button();
            continueButton = new Button();
            ContextBox = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // GamePath
            // 
            GamePath.Location = new Point(12, 107);
            GamePath.Name = "GamePath";
            GamePath.Size = new Size(590, 23);
            GamePath.TabIndex = 0;
            // 
            // BtnAddGamePath
            // 
            BtnAddGamePath.Location = new Point(12, 170);
            BtnAddGamePath.Name = "BtnAddGamePath";
            BtnAddGamePath.Size = new Size(114, 23);
            BtnAddGamePath.TabIndex = 3;
            BtnAddGamePath.Text = "Add Game Path";
            BtnAddGamePath.UseVisualStyleBackColor = true;
            BtnAddGamePath.Click += BtnAddGamePath_Click;
            // 
            // continueButton
            // 
            continueButton.Enabled = false;
            continueButton.Location = new Point(12, 260);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(141, 23);
            continueButton.TabIndex = 4;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Click += button1_Click;
            // 
            // ContextBox
            // 
            ContextBox.Location = new Point(361, 187);
            ContextBox.Name = "ContextBox";
            ContextBox.Size = new Size(241, 96);
            ContextBox.TabIndex = 5;
            ContextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(319, 30);
            label1.TabIndex = 6;
            label1.Text = "Looks like it's the first time you've launched PvZ: Replanter!\r\nPlease insert your Game Path in the text box down below";
            label1.Click += label1_Click;
            // 
            // Setup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 309);
            Controls.Add(label1);
            Controls.Add(ContextBox);
            Controls.Add(continueButton);
            Controls.Add(BtnAddGamePath);
            Controls.Add(GamePath);
            Name = "Setup";
            Text = "Setup";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GamePath;
        private Button BtnAddGamePath;
        private Button continueButton;
        private RichTextBox ContextBox;
        private Label label1;
    }
}
