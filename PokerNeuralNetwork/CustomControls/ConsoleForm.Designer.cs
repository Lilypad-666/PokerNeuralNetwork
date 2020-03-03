namespace PokerNeuralNetwork {
    partial class ConsoleForm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ConsoleTitleBar = new System.Windows.Forms.Panel();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.ConsoleMinimizeButton = new PokerNeuralNetwork.TitleBarButton();
            this.ConsoleExitButton = new PokerNeuralNetwork.TitleBarButton();
            this.RichConsoleText = new System.Windows.Forms.RichTextBox();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.ConsoleSendButton = new PokerNeuralNetwork.CustomButton();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleTitleBar.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleTitleBar
            // 
            this.ConsoleTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.ConsoleTitleBar.Controls.Add(this.ConsoleLabel);
            this.ConsoleTitleBar.Controls.Add(this.ConsoleMinimizeButton);
            this.ConsoleTitleBar.Controls.Add(this.ConsoleExitButton);
            this.ConsoleTitleBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTitleBar.Location = new System.Drawing.Point(0, 0);
            this.ConsoleTitleBar.Name = "ConsoleTitleBar";
            this.ConsoleTitleBar.Size = new System.Drawing.Size(1000, 30);
            this.ConsoleTitleBar.TabIndex = 28;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLabel.ForeColor = System.Drawing.Color.White;
            this.ConsoleLabel.Location = new System.Drawing.Point(34, 6);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(188, 17);
            this.ConsoleLabel.TabIndex = 29;
            this.ConsoleLabel.Text = "Poker Neural Network Console";
            // 
            // ConsoleMinimizeButton
            // 
            this.ConsoleMinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.ConsoleMinimizeButton.FlatAppearance.BorderSize = 0;
            this.ConsoleMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleMinimizeButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold);
            this.ConsoleMinimizeButton.ForeColor = System.Drawing.Color.White;
            this.ConsoleMinimizeButton.Location = new System.Drawing.Point(890, -2);
            this.ConsoleMinimizeButton.Name = "ConsoleMinimizeButton";
            this.ConsoleMinimizeButton.Size = new System.Drawing.Size(55, 32);
            this.ConsoleMinimizeButton.TabIndex = 28;
            this.ConsoleMinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConsoleMinimizeButton.UseCompatibleTextRendering = true;
            this.ConsoleMinimizeButton.UseVisualStyleBackColor = false;
            // 
            // ConsoleExitButton
            // 
            this.ConsoleExitButton.BackColor = System.Drawing.Color.Red;
            this.ConsoleExitButton.FlatAppearance.BorderSize = 0;
            this.ConsoleExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleExitButton.Font = new System.Drawing.Font("Marlett", 12F);
            this.ConsoleExitButton.ForeColor = System.Drawing.Color.White;
            this.ConsoleExitButton.Location = new System.Drawing.Point(945, 0);
            this.ConsoleExitButton.Name = "ConsoleExitButton";
            this.ConsoleExitButton.Size = new System.Drawing.Size(55, 30);
            this.ConsoleExitButton.TabIndex = 27;
            this.ConsoleExitButton.UseVisualStyleBackColor = false;
            // 
            // RichConsoleText
            // 
            this.RichConsoleText.BackColor = System.Drawing.Color.Black;
            this.RichConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichConsoleText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichConsoleText.ForeColor = System.Drawing.Color.Lime;
            this.RichConsoleText.Location = new System.Drawing.Point(10, 10);
            this.RichConsoleText.Name = "RichConsoleText";
            this.RichConsoleText.ReadOnly = true;
            this.RichConsoleText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichConsoleText.Size = new System.Drawing.Size(960, 716);
            this.RichConsoleText.TabIndex = 3;
            this.RichConsoleText.Text = "";
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleInput.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleInput.Location = new System.Drawing.Point(3, 732);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(878, 25);
            this.ConsoleInput.TabIndex = 4;
            // 
            // ConsoleSendButton
            // 
            this.ConsoleSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleSendButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsoleSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleSendButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSendButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleSendButton.Location = new System.Drawing.Point(884, 732);
            this.ConsoleSendButton.Name = "ConsoleSendButton";
            this.ConsoleSendButton.Size = new System.Drawing.Size(93, 25);
            this.ConsoleSendButton.TabIndex = 5;
            this.ConsoleSendButton.TabStop = false;
            this.ConsoleSendButton.Text = "Send";
            this.ConsoleSendButton.UseVisualStyleBackColor = false;
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.ConsolePanel.Controls.Add(this.ConsoleSendButton);
            this.ConsolePanel.Controls.Add(this.RichConsoleText);
            this.ConsolePanel.Controls.Add(this.ConsoleInput);
            this.ConsolePanel.Location = new System.Drawing.Point(10, 30);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(980, 760);
            this.ConsolePanel.TabIndex = 1;
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.ConsoleTitleBar);
            this.Controls.Add(this.ConsolePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsoleForm";
            this.ConsoleTitleBar.ResumeLayout(false);
            this.ConsoleTitleBar.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel ConsoleTitleBar;
        public System.Windows.Forms.Label ConsoleLabel;
        public TitleBarButton ConsoleMinimizeButton;
        public TitleBarButton ConsoleExitButton;
        public System.Windows.Forms.RichTextBox RichConsoleText;
        public System.Windows.Forms.TextBox ConsoleInput;
        public CustomButton ConsoleSendButton;
        private System.Windows.Forms.Panel ConsolePanel;
    }
}
