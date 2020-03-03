using System.Drawing;

namespace PokerNeuralNetwork
{
    partial class MainForm
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
            this.TitleBarPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new PokerNeuralNetwork.TitleBarButton();
            this.ExitButton = new PokerNeuralNetwork.TitleBarButton();
            this.GameInfoPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WindowInfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.WindowYBox = new System.Windows.Forms.TextBox();
            this.WindowHeightLabel = new System.Windows.Forms.Label();
            this.WindowYLabel = new System.Windows.Forms.Label();
            this.WindowWidthBox = new System.Windows.Forms.TextBox();
            this.WindowXLabel = new System.Windows.Forms.Label();
            this.WindowXBox = new System.Windows.Forms.TextBox();
            this.WindowHeightBox = new System.Windows.Forms.TextBox();
            this.WindowWidthLabel = new System.Windows.Forms.Label();
            this.MainTabControl = new PokerNeuralNetwork.CustomTabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.HoldemSettingsGroupBox = new PokerNeuralNetwork.CustomGroupBox();
            this.MainSettingsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SBText = new System.Windows.Forms.TextBox();
            this.SBValue = new System.Windows.Forms.NumericUpDown();
            this.ChipsValue = new System.Windows.Forms.NumericUpDown();
            this.ChipsText = new System.Windows.Forms.TextBox();
            this.PlayersText = new System.Windows.Forms.TextBox();
            this.PlayersValue = new System.Windows.Forms.NumericUpDown();
            this.ConsoleSettingsGroupBox = new PokerNeuralNetwork.CustomGroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsolePopoutCheckbox = new PokerNeuralNetwork.CustomCheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StartGroupBox = new PokerNeuralNetwork.CustomGroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.StartHoldemButton = new PokerNeuralNetwork.CustomButton();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.customTabControl1 = new PokerNeuralNetwork.CustomTabControl();
            this.PokerSettingsTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsoleSettingsTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.VisualTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PlayLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.Player2Card1 = new System.Windows.Forms.TextBox();
            this.Player2Card2 = new System.Windows.Forms.TextBox();
            this.Player2Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText2 = new System.Windows.Forms.TextBox();
            this.CurrentBet2 = new System.Windows.Forms.TextBox();
            this.PlayerLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player1Card1 = new System.Windows.Forms.TextBox();
            this.Player1Card2 = new System.Windows.Forms.TextBox();
            this.Player1Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText1 = new System.Windows.Forms.TextBox();
            this.CurrentBet1 = new System.Windows.Forms.TextBox();
            this.PlayerLayout0 = new System.Windows.Forms.TableLayoutPanel();
            this.Player0Card1 = new System.Windows.Forms.TextBox();
            this.Player0Card2 = new System.Windows.Forms.TextBox();
            this.Player0Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText0 = new System.Windows.Forms.TextBox();
            this.CurrentBet0 = new System.Windows.Forms.TextBox();
            this.MiddlePanel = new System.Windows.Forms.TableLayoutPanel();
            this.Flop1 = new System.Windows.Forms.TextBox();
            this.Flop2 = new System.Windows.Forms.TextBox();
            this.Flop3 = new System.Windows.Forms.TextBox();
            this.Turn1 = new System.Windows.Forms.TextBox();
            this.River1 = new System.Windows.Forms.TextBox();
            this.PotText = new System.Windows.Forms.TextBox();
            this.BetText = new System.Windows.Forms.TextBox();
            this.PlayerLayout5 = new System.Windows.Forms.TableLayoutPanel();
            this.Player5Card1 = new System.Windows.Forms.TextBox();
            this.Player5Card2 = new System.Windows.Forms.TextBox();
            this.Player5Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText5 = new System.Windows.Forms.TextBox();
            this.CurrentBet5 = new System.Windows.Forms.TextBox();
            this.PlayerLayout4 = new System.Windows.Forms.TableLayoutPanel();
            this.Player4Card1 = new System.Windows.Forms.TextBox();
            this.Player4Card2 = new System.Windows.Forms.TextBox();
            this.Player4Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText4 = new System.Windows.Forms.TextBox();
            this.CurrentBet4 = new System.Windows.Forms.TextBox();
            this.PlayerLayout3 = new System.Windows.Forms.TableLayoutPanel();
            this.Player3Card1 = new System.Windows.Forms.TextBox();
            this.Player3Card2 = new System.Windows.Forms.TextBox();
            this.Player3Money = new System.Windows.Forms.TextBox();
            this.BlindDealerText3 = new System.Windows.Forms.TextBox();
            this.CurrentBet3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ConsoleTab = new System.Windows.Forms.TabPage();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleSendButton = new PokerNeuralNetwork.CustomButton();
            this.RichConsoleText = new System.Windows.Forms.RichTextBox();
            this.ConsoleInput = new System.Windows.Forms.TextBox();
            this.InfoTab = new System.Windows.Forms.TabPage();
            this.DebuggingInfoPanel = new System.Windows.Forms.Panel();
            this.DebuggingInfoPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lilypadLabel = new System.Windows.Forms.Label();
            this.GitHubLink = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VersionNumberLabel = new System.Windows.Forms.Label();
            this.DebuggingInfoPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleBarPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.HoldemSettingsGroupBox.SuspendLayout();
            this.MainSettingsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SBValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChipsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersValue)).BeginInit();
            this.ConsoleSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.StartGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.customTabControl1.SuspendLayout();
            this.PokerSettingsTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ConsoleSettingsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.VisualTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PlayLayout.SuspendLayout();
            this.PlayerLayout2.SuspendLayout();
            this.PlayerLayout1.SuspendLayout();
            this.PlayerLayout0.SuspendLayout();
            this.MiddlePanel.SuspendLayout();
            this.PlayerLayout5.SuspendLayout();
            this.PlayerLayout4.SuspendLayout();
            this.PlayerLayout3.SuspendLayout();
            this.ConsoleTab.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.InfoTab.SuspendLayout();
            this.DebuggingInfoPanel.SuspendLayout();
            this.DebuggingInfoPanel2.SuspendLayout();
            this.DebuggingInfoPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBarPanel
            // 
            this.TitleBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.TitleBarPanel.Controls.Add(this.TitleLabel);
            this.TitleBarPanel.Controls.Add(this.MinimizeButton);
            this.TitleBarPanel.Controls.Add(this.ExitButton);
            this.TitleBarPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitleBarPanel.Name = "TitleBarPanel";
            this.TitleBarPanel.Size = new System.Drawing.Size(1000, 30);
            this.TitleBarPanel.TabIndex = 27;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(34, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(168, 21);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "Poker Neural Network ";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(890, -2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(55, 32);
            this.MinimizeButton.TabIndex = 28;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseCompatibleTextRendering = true;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(945, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(55, 30);
            this.ExitButton.TabIndex = 27;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // GameInfoPanel1
            // 
            this.GameInfoPanel1.ColumnCount = 4;
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.GameInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.GameInfoPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameInfoPanel1.Location = new System.Drawing.Point(0, 8);
            this.GameInfoPanel1.Name = "GameInfoPanel1";
            this.GameInfoPanel1.RowCount = 1;
            this.GameInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameInfoPanel1.Size = new System.Drawing.Size(522, 64);
            this.GameInfoPanel1.TabIndex = 27;
            // 
            // WindowInfoLabel
            // 
            this.WindowInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowInfoLabel.AutoSize = true;
            this.WindowInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowInfoLabel.ForeColor = System.Drawing.Color.White;
            this.WindowInfoLabel.Location = new System.Drawing.Point(69, 23);
            this.WindowInfoLabel.Name = "WindowInfoLabel";
            this.WindowInfoLabel.Size = new System.Drawing.Size(122, 17);
            this.WindowInfoLabel.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(230, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(209, 58);
            this.tableLayoutPanel4.TabIndex = 28;
            // 
            // WindowYBox
            // 
            this.WindowYBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowYBox.BackColor = System.Drawing.Color.Gray;
            this.WindowYBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowYBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowYBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowYBox.Location = new System.Drawing.Point(35, 32);
            this.WindowYBox.Name = "WindowYBox";
            this.WindowYBox.ReadOnly = true;
            this.WindowYBox.Size = new System.Drawing.Size(40, 29);
            this.WindowYBox.TabIndex = 8;
            this.WindowYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowHeightLabel
            // 
            this.WindowHeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowHeightLabel.AutoSize = true;
            this.WindowHeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeightLabel.ForeColor = System.Drawing.Color.White;
            this.WindowHeightLabel.Location = new System.Drawing.Point(107, 35);
            this.WindowHeightLabel.Name = "WindowHeightLabel";
            this.WindowHeightLabel.Size = new System.Drawing.Size(49, 17);
            this.WindowHeightLabel.TabIndex = 4;
            // 
            // WindowYLabel
            // 
            this.WindowYLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowYLabel.AutoSize = true;
            this.WindowYLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowYLabel.ForeColor = System.Drawing.Color.White;
            this.WindowYLabel.Location = new System.Drawing.Point(9, 35);
            this.WindowYLabel.Name = "WindowYLabel";
            this.WindowYLabel.Size = new System.Drawing.Size(18, 17);
            this.WindowYLabel.TabIndex = 2;
            // 
            // WindowWidthBox
            // 
            this.WindowWidthBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowWidthBox.BackColor = System.Drawing.Color.Gray;
            this.WindowWidthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowWidthBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowWidthBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowWidthBox.Location = new System.Drawing.Point(164, 3);
            this.WindowWidthBox.Name = "WindowWidthBox";
            this.WindowWidthBox.ReadOnly = true;
            this.WindowWidthBox.Size = new System.Drawing.Size(40, 29);
            this.WindowWidthBox.TabIndex = 7;
            this.WindowWidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowXLabel
            // 
            this.WindowXLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowXLabel.AutoSize = true;
            this.WindowXLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowXLabel.ForeColor = System.Drawing.Color.White;
            this.WindowXLabel.Location = new System.Drawing.Point(8, 6);
            this.WindowXLabel.Name = "WindowXLabel";
            this.WindowXLabel.Size = new System.Drawing.Size(19, 17);
            this.WindowXLabel.TabIndex = 1;
            // 
            // WindowXBox
            // 
            this.WindowXBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowXBox.BackColor = System.Drawing.Color.Gray;
            this.WindowXBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowXBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowXBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowXBox.Location = new System.Drawing.Point(35, 3);
            this.WindowXBox.Name = "WindowXBox";
            this.WindowXBox.ReadOnly = true;
            this.WindowXBox.Size = new System.Drawing.Size(40, 29);
            this.WindowXBox.TabIndex = 5;
            this.WindowXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowHeightBox
            // 
            this.WindowHeightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WindowHeightBox.BackColor = System.Drawing.Color.Gray;
            this.WindowHeightBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowHeightBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowHeightBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowHeightBox.Location = new System.Drawing.Point(164, 32);
            this.WindowHeightBox.Name = "WindowHeightBox";
            this.WindowHeightBox.ReadOnly = true;
            this.WindowHeightBox.Size = new System.Drawing.Size(40, 29);
            this.WindowHeightBox.TabIndex = 6;
            this.WindowHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WindowWidthLabel
            // 
            this.WindowWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WindowWidthLabel.AutoSize = true;
            this.WindowWidthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowWidthLabel.ForeColor = System.Drawing.Color.White;
            this.WindowWidthLabel.Location = new System.Drawing.Point(111, 6);
            this.WindowWidthLabel.Name = "WindowWidthLabel";
            this.WindowWidthLabel.Size = new System.Drawing.Size(45, 17);
            this.WindowWidthLabel.TabIndex = 3;
            // 
            // MainTabControl
            // 
            this.MainTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.AllowDrop = true;
            this.MainTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainTabControl.Controls.Add(this.MainTab);
            this.MainTabControl.Controls.Add(this.SettingsTab);
            this.MainTabControl.Controls.Add(this.VisualTab);
            this.MainTabControl.Controls.Add(this.ConsoleTab);
            this.MainTabControl.Controls.Add(this.InfoTab);
            this.MainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainTabControl.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTabControl.ItemSize = new System.Drawing.Size(240, 28);
            this.MainTabControl.Location = new System.Drawing.Point(10, 30);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.Padding = new System.Drawing.Point(10, 0);
            this.MainTabControl.RightToLeftLayout = true;
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(980, 760);
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.MainTab.Controls.Add(this.panel1);
            this.MainTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.Location = new System.Drawing.Point(4, 32);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(972, 724);
            this.MainTab.TabIndex = 9;
            this.MainTab.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.tableLayoutPanel6);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 724);
            this.panel1.TabIndex = 29;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.HoldemSettingsGroupBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.ConsoleSettingsGroupBox, 2, 0);
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(972, 291);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // HoldemSettingsGroupBox
            // 
            this.HoldemSettingsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HoldemSettingsGroupBox.Controls.Add(this.MainSettingsLayout);
            this.HoldemSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldemSettingsGroupBox.Location = new System.Drawing.Point(10, 37);
            this.HoldemSettingsGroupBox.Name = "HoldemSettingsGroupBox";
            this.HoldemSettingsGroupBox.Size = new System.Drawing.Size(303, 217);
            this.HoldemSettingsGroupBox.TabIndex = 22;
            this.HoldemSettingsGroupBox.TabStop = false;
            this.HoldemSettingsGroupBox.Text = "Hold\'em";
            // 
            // MainSettingsLayout
            // 
            this.MainSettingsLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainSettingsLayout.ColumnCount = 2;
            this.MainSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainSettingsLayout.Controls.Add(this.SBText, 0, 0);
            this.MainSettingsLayout.Controls.Add(this.SBValue, 1, 0);
            this.MainSettingsLayout.Controls.Add(this.ChipsValue, 1, 1);
            this.MainSettingsLayout.Controls.Add(this.ChipsText, 0, 1);
            this.MainSettingsLayout.Controls.Add(this.PlayersText, 0, 2);
            this.MainSettingsLayout.Controls.Add(this.PlayersValue, 1, 2);
            this.MainSettingsLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSettingsLayout.Location = new System.Drawing.Point(6, 15);
            this.MainSettingsLayout.Name = "MainSettingsLayout";
            this.MainSettingsLayout.RowCount = 3;
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainSettingsLayout.Size = new System.Drawing.Size(291, 196);
            this.MainSettingsLayout.TabIndex = 20;
            // 
            // SBText
            // 
            this.SBText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SBText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SBText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SBText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBText.ForeColor = System.Drawing.Color.White;
            this.SBText.Location = new System.Drawing.Point(52, 21);
            this.SBText.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SBText.Name = "SBText";
            this.SBText.Size = new System.Drawing.Size(83, 22);
            this.SBText.TabIndex = 12;
            this.SBText.Text = "SB";
            this.SBText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SBValue
            // 
            this.SBValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SBValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SBValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SBValue.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.SBValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SBValue.ForeColor = System.Drawing.Color.White;
            this.SBValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SBValue.Location = new System.Drawing.Point(155, 18);
            this.SBValue.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.SBValue.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.SBValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SBValue.Name = "SBValue";
            this.SBValue.Size = new System.Drawing.Size(85, 29);
            this.SBValue.TabIndex = 10;
            this.SBValue.Tag = "";
            this.SBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SBValue.UseWaitCursor = true;
            this.SBValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ChipsValue
            // 
            this.ChipsValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChipsValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ChipsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChipsValue.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ChipsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsValue.ForeColor = System.Drawing.Color.White;
            this.ChipsValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChipsValue.Location = new System.Drawing.Point(155, 83);
            this.ChipsValue.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ChipsValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ChipsValue.Name = "ChipsValue";
            this.ChipsValue.Size = new System.Drawing.Size(85, 29);
            this.ChipsValue.TabIndex = 11;
            this.ChipsValue.Tag = "";
            this.ChipsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChipsValue.UseWaitCursor = true;
            this.ChipsValue.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // ChipsText
            // 
            this.ChipsText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ChipsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ChipsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChipsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsText.ForeColor = System.Drawing.Color.White;
            this.ChipsText.Location = new System.Drawing.Point(52, 86);
            this.ChipsText.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ChipsText.Name = "ChipsText";
            this.ChipsText.Size = new System.Drawing.Size(83, 22);
            this.ChipsText.TabIndex = 13;
            this.ChipsText.Text = "Chips";
            this.ChipsText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlayersText
            // 
            this.PlayersText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlayersText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PlayersText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayersText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersText.ForeColor = System.Drawing.Color.White;
            this.PlayersText.Location = new System.Drawing.Point(52, 152);
            this.PlayersText.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PlayersText.Name = "PlayersText";
            this.PlayersText.Size = new System.Drawing.Size(83, 22);
            this.PlayersText.TabIndex = 14;
            this.PlayersText.Text = "Players";
            this.PlayersText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PlayersValue
            // 
            this.PlayersValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayersValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PlayersValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayersValue.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PlayersValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersValue.ForeColor = System.Drawing.Color.White;
            this.PlayersValue.Location = new System.Drawing.Point(155, 148);
            this.PlayersValue.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.PlayersValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.PlayersValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PlayersValue.Name = "PlayersValue";
            this.PlayersValue.Size = new System.Drawing.Size(85, 29);
            this.PlayersValue.TabIndex = 15;
            this.PlayersValue.Tag = "";
            this.PlayersValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayersValue.UseWaitCursor = true;
            this.PlayersValue.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ConsoleSettingsGroupBox
            // 
            this.ConsoleSettingsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsoleSettingsGroupBox.Controls.Add(this.tableLayoutPanel8);
            this.ConsoleSettingsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSettingsGroupBox.Location = new System.Drawing.Point(658, 37);
            this.ConsoleSettingsGroupBox.Name = "ConsoleSettingsGroupBox";
            this.ConsoleSettingsGroupBox.Size = new System.Drawing.Size(303, 217);
            this.ConsoleSettingsGroupBox.TabIndex = 23;
            this.ConsoleSettingsGroupBox.TabStop = false;
            this.ConsoleSettingsGroupBox.Text = "Console";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Controls.Add(this.ConsolePopoutCheckbox, 1, 0);
            this.tableLayoutPanel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel8.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(291, 196);
            this.tableLayoutPanel8.TabIndex = 20;
            // 
            // ConsolePopoutCheckbox
            // 
            this.ConsolePopoutCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsolePopoutCheckbox.AutoSize = true;
            this.ConsolePopoutCheckbox.Checked = true;
            this.ConsolePopoutCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ConsolePopoutCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsolePopoutCheckbox.Location = new System.Drawing.Point(106, 20);
            this.ConsolePopoutCheckbox.Name = "ConsolePopoutCheckbox";
            this.ConsolePopoutCheckbox.Size = new System.Drawing.Size(78, 25);
            this.ConsolePopoutCheckbox.TabIndex = 0;
            this.ConsolePopoutCheckbox.Text = "Popout";
            this.ConsolePopoutCheckbox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.StartGroupBox, 1, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 521);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(972, 201);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // StartGroupBox
            // 
            this.StartGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.StartGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGroupBox.Location = new System.Drawing.Point(364, 27);
            this.StartGroupBox.Name = "StartGroupBox";
            this.StartGroupBox.Size = new System.Drawing.Size(243, 146);
            this.StartGroupBox.TabIndex = 18;
            this.StartGroupBox.TabStop = false;
            this.StartGroupBox.Text = "Start";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.StartHoldemButton, 1, 1);
            this.tableLayoutPanel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(231, 125);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // StartHoldemButton
            // 
            this.StartHoldemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartHoldemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartHoldemButton.Location = new System.Drawing.Point(68, 40);
            this.StartHoldemButton.Name = "StartHoldemButton";
            this.StartHoldemButton.Size = new System.Drawing.Size(93, 45);
            this.StartHoldemButton.TabIndex = 16;
            this.StartHoldemButton.Text = "Hold\'em";
            this.StartHoldemButton.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.SettingsTab.Controls.Add(this.customTabControl1);
            this.SettingsTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsTab.Location = new System.Drawing.Point(4, 32);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(972, 724);
            this.SettingsTab.TabIndex = 10;
            this.SettingsTab.Text = "Settings";
            // 
            // customTabControl1
            // 
            this.customTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.customTabControl1.AllowDrop = true;
            this.customTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.customTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customTabControl1.Controls.Add(this.PokerSettingsTab);
            this.customTabControl1.Controls.Add(this.ConsoleSettingsTab);
            this.customTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.customTabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.customTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.customTabControl1.ItemSize = new System.Drawing.Size(240, 28);
            this.customTabControl1.Location = new System.Drawing.Point(0, 0);
            this.customTabControl1.Multiline = true;
            this.customTabControl1.Name = "customTabControl1";
            this.customTabControl1.Padding = new System.Drawing.Point(10, 0);
            this.customTabControl1.RightToLeftLayout = true;
            this.customTabControl1.SelectedIndex = 0;
            this.customTabControl1.Size = new System.Drawing.Size(972, 726);
            this.customTabControl1.TabIndex = 19;
            this.customTabControl1.TextColor = System.Drawing.Color.White;
            // 
            // PokerSettingsTab
            // 
            this.PokerSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.PokerSettingsTab.Controls.Add(this.panel3);
            this.PokerSettingsTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PokerSettingsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PokerSettingsTab.Location = new System.Drawing.Point(4, 32);
            this.PokerSettingsTab.Name = "PokerSettingsTab";
            this.PokerSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.PokerSettingsTab.Size = new System.Drawing.Size(964, 690);
            this.PokerSettingsTab.TabIndex = 1;
            this.PokerSettingsTab.Text = "Poker";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 690);
            this.panel3.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 682);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // ConsoleSettingsTab
            // 
            this.ConsoleSettingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.ConsoleSettingsTab.Controls.Add(this.panel2);
            this.ConsoleSettingsTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSettingsTab.Location = new System.Drawing.Point(4, 32);
            this.ConsoleSettingsTab.Name = "ConsoleSettingsTab";
            this.ConsoleSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleSettingsTab.Size = new System.Drawing.Size(964, 690);
            this.ConsoleSettingsTab.TabIndex = 2;
            this.ConsoleSettingsTab.Text = "Console";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.tableLayoutPanel7);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 690);
            this.panel2.TabIndex = 18;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 8);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(963, 682);
            this.tableLayoutPanel7.TabIndex = 21;
            // 
            // VisualTab
            // 
            this.VisualTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.VisualTab.Controls.Add(this.panel4);
            this.VisualTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualTab.Location = new System.Drawing.Point(4, 32);
            this.VisualTab.Name = "VisualTab";
            this.VisualTab.Size = new System.Drawing.Size(972, 724);
            this.VisualTab.TabIndex = 8;
            this.VisualTab.Text = "Visual";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.PlayLayout);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(972, 724);
            this.panel4.TabIndex = 28;
            // 
            // PlayLayout
            // 
            this.PlayLayout.ColumnCount = 3;
            this.PlayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PlayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PlayLayout.Controls.Add(this.PlayerLayout2, 2, 0);
            this.PlayLayout.Controls.Add(this.PlayerLayout1, 1, 0);
            this.PlayLayout.Controls.Add(this.PlayerLayout0, 0, 0);
            this.PlayLayout.Controls.Add(this.MiddlePanel, 1, 1);
            this.PlayLayout.Controls.Add(this.PlayerLayout5, 0, 2);
            this.PlayLayout.Controls.Add(this.PlayerLayout4, 1, 2);
            this.PlayLayout.Controls.Add(this.PlayerLayout3, 2, 2);
            this.PlayLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.PlayLayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayLayout.Location = new System.Drawing.Point(0, 8);
            this.PlayLayout.Name = "PlayLayout";
            this.PlayLayout.RowCount = 3;
            this.PlayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.PlayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.PlayLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.PlayLayout.Size = new System.Drawing.Size(972, 716);
            this.PlayLayout.TabIndex = 1;
            // 
            // PlayerLayout2
            // 
            this.PlayerLayout2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout2.ColumnCount = 2;
            this.PlayerLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout2.Controls.Add(this.Player2Card1, 0, 0);
            this.PlayerLayout2.Controls.Add(this.Player2Card2, 1, 0);
            this.PlayerLayout2.Controls.Add(this.Player2Money, 1, 4);
            this.PlayerLayout2.Controls.Add(this.BlindDealerText2, 0, 2);
            this.PlayerLayout2.Controls.Add(this.CurrentBet2, 1, 3);
            this.PlayerLayout2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout2.Location = new System.Drawing.Point(755, 3);
            this.PlayerLayout2.Name = "PlayerLayout2";
            this.PlayerLayout2.RowCount = 5;
            this.PlayerLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout2.Size = new System.Drawing.Size(190, 189);
            this.PlayerLayout2.TabIndex = 7;
            this.PlayerLayout2.Visible = false;
            // 
            // Player2Card1
            // 
            this.Player2Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player2Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player2Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player2Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Card1.ForeColor = System.Drawing.Color.White;
            this.Player2Card1.Location = new System.Drawing.Point(13, 8);
            this.Player2Card1.Name = "Player2Card1";
            this.Player2Card1.Size = new System.Drawing.Size(68, 22);
            this.Player2Card1.TabIndex = 2;
            this.Player2Card1.Text = "XX";
            this.Player2Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player2Card2
            // 
            this.Player2Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player2Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player2Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player2Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Card2.ForeColor = System.Drawing.Color.White;
            this.Player2Card2.Location = new System.Drawing.Point(108, 8);
            this.Player2Card2.Name = "Player2Card2";
            this.Player2Card2.Size = new System.Drawing.Size(68, 22);
            this.Player2Card2.TabIndex = 3;
            this.Player2Card2.Text = "XX";
            this.Player2Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player2Money
            // 
            this.Player2Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player2Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player2Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player2Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Money.ForeColor = System.Drawing.Color.White;
            this.Player2Money.Location = new System.Drawing.Point(101, 157);
            this.Player2Money.Name = "Player2Money";
            this.Player2Money.Size = new System.Drawing.Size(82, 22);
            this.Player2Money.TabIndex = 0;
            this.Player2Money.Text = "$NULL";
            this.Player2Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText2
            // 
            this.BlindDealerText2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText2.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText2.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText2.Name = "BlindDealerText2";
            this.BlindDealerText2.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText2.TabIndex = 8;
            this.BlindDealerText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet2
            // 
            this.CurrentBet2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet2.ForeColor = System.Drawing.Color.White;
            this.CurrentBet2.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet2.Name = "CurrentBet2";
            this.CurrentBet2.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet2.TabIndex = 9;
            this.CurrentBet2.Text = "$0";
            this.CurrentBet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerLayout1
            // 
            this.PlayerLayout1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout1.ColumnCount = 2;
            this.PlayerLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout1.Controls.Add(this.Player1Card1, 0, 0);
            this.PlayerLayout1.Controls.Add(this.Player1Card2, 1, 0);
            this.PlayerLayout1.Controls.Add(this.Player1Money, 1, 4);
            this.PlayerLayout1.Controls.Add(this.BlindDealerText1, 0, 2);
            this.PlayerLayout1.Controls.Add(this.CurrentBet1, 1, 3);
            this.PlayerLayout1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout1.Location = new System.Drawing.Point(391, 3);
            this.PlayerLayout1.Name = "PlayerLayout1";
            this.PlayerLayout1.RowCount = 5;
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PlayerLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PlayerLayout1.Size = new System.Drawing.Size(190, 189);
            this.PlayerLayout1.TabIndex = 6;
            this.PlayerLayout1.Visible = false;
            // 
            // Player1Card1
            // 
            this.Player1Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player1Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player1Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player1Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Card1.ForeColor = System.Drawing.Color.White;
            this.Player1Card1.Location = new System.Drawing.Point(13, 8);
            this.Player1Card1.Name = "Player1Card1";
            this.Player1Card1.Size = new System.Drawing.Size(68, 22);
            this.Player1Card1.TabIndex = 2;
            this.Player1Card1.Text = "XX";
            this.Player1Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player1Card2
            // 
            this.Player1Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player1Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player1Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player1Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Card2.ForeColor = System.Drawing.Color.White;
            this.Player1Card2.Location = new System.Drawing.Point(108, 8);
            this.Player1Card2.Name = "Player1Card2";
            this.Player1Card2.Size = new System.Drawing.Size(68, 22);
            this.Player1Card2.TabIndex = 3;
            this.Player1Card2.Text = "XX";
            this.Player1Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player1Money
            // 
            this.Player1Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player1Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player1Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player1Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Money.ForeColor = System.Drawing.Color.White;
            this.Player1Money.Location = new System.Drawing.Point(101, 157);
            this.Player1Money.Name = "Player1Money";
            this.Player1Money.Size = new System.Drawing.Size(82, 22);
            this.Player1Money.TabIndex = 0;
            this.Player1Money.Text = "$NULL";
            this.Player1Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText1
            // 
            this.BlindDealerText1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText1.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText1.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText1.Name = "BlindDealerText1";
            this.BlindDealerText1.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText1.TabIndex = 8;
            this.BlindDealerText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet1
            // 
            this.CurrentBet1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet1.ForeColor = System.Drawing.Color.White;
            this.CurrentBet1.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet1.Name = "CurrentBet1";
            this.CurrentBet1.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet1.TabIndex = 9;
            this.CurrentBet1.Text = "$0";
            this.CurrentBet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerLayout0
            // 
            this.PlayerLayout0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PlayerLayout0.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout0.ColumnCount = 2;
            this.PlayerLayout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout0.Controls.Add(this.Player0Card1, 0, 0);
            this.PlayerLayout0.Controls.Add(this.Player0Card2, 1, 0);
            this.PlayerLayout0.Controls.Add(this.Player0Money, 1, 4);
            this.PlayerLayout0.Controls.Add(this.BlindDealerText0, 0, 2);
            this.PlayerLayout0.Controls.Add(this.CurrentBet0, 1, 3);
            this.PlayerLayout0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout0.Location = new System.Drawing.Point(26, 3);
            this.PlayerLayout0.Name = "PlayerLayout0";
            this.PlayerLayout0.RowCount = 5;
            this.PlayerLayout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout0.Size = new System.Drawing.Size(190, 189);
            this.PlayerLayout0.TabIndex = 5;
            this.PlayerLayout0.Visible = false;
            // 
            // Player0Card1
            // 
            this.Player0Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player0Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player0Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player0Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player0Card1.ForeColor = System.Drawing.Color.White;
            this.Player0Card1.Location = new System.Drawing.Point(13, 8);
            this.Player0Card1.Name = "Player0Card1";
            this.Player0Card1.Size = new System.Drawing.Size(68, 22);
            this.Player0Card1.TabIndex = 2;
            this.Player0Card1.Text = "XX";
            this.Player0Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player0Card2
            // 
            this.Player0Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player0Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player0Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player0Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player0Card2.ForeColor = System.Drawing.Color.White;
            this.Player0Card2.Location = new System.Drawing.Point(108, 8);
            this.Player0Card2.Name = "Player0Card2";
            this.Player0Card2.Size = new System.Drawing.Size(68, 22);
            this.Player0Card2.TabIndex = 3;
            this.Player0Card2.Text = "XX";
            this.Player0Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player0Money
            // 
            this.Player0Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player0Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player0Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player0Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player0Money.ForeColor = System.Drawing.Color.White;
            this.Player0Money.Location = new System.Drawing.Point(101, 157);
            this.Player0Money.Name = "Player0Money";
            this.Player0Money.Size = new System.Drawing.Size(82, 22);
            this.Player0Money.TabIndex = 0;
            this.Player0Money.Text = "$NULL";
            this.Player0Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText0
            // 
            this.BlindDealerText0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText0.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText0.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText0.Name = "BlindDealerText0";
            this.BlindDealerText0.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText0.TabIndex = 7;
            this.BlindDealerText0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet0
            // 
            this.CurrentBet0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet0.ForeColor = System.Drawing.Color.White;
            this.CurrentBet0.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet0.Name = "CurrentBet0";
            this.CurrentBet0.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet0.TabIndex = 8;
            this.CurrentBet0.Text = "$0";
            this.CurrentBet0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.ColumnCount = 5;
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MiddlePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MiddlePanel.Controls.Add(this.Flop1, 0, 1);
            this.MiddlePanel.Controls.Add(this.Flop2, 1, 1);
            this.MiddlePanel.Controls.Add(this.Flop3, 2, 1);
            this.MiddlePanel.Controls.Add(this.Turn1, 3, 1);
            this.MiddlePanel.Controls.Add(this.River1, 4, 1);
            this.MiddlePanel.Controls.Add(this.PotText, 3, 2);
            this.MiddlePanel.Controls.Add(this.BetText, 4, 2);
            this.MiddlePanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddlePanel.Location = new System.Drawing.Point(246, 198);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.RowCount = 3;
            this.MiddlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MiddlePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MiddlePanel.Size = new System.Drawing.Size(480, 319);
            this.MiddlePanel.TabIndex = 12;
            // 
            // Flop1
            // 
            this.Flop1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Flop1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Flop1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flop1.ForeColor = System.Drawing.Color.White;
            this.Flop1.Location = new System.Drawing.Point(14, 147);
            this.Flop1.Name = "Flop1";
            this.Flop1.Size = new System.Drawing.Size(68, 22);
            this.Flop1.TabIndex = 3;
            this.Flop1.Text = "XX";
            this.Flop1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Flop1.Visible = false;
            // 
            // Flop2
            // 
            this.Flop2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Flop2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Flop2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flop2.ForeColor = System.Drawing.Color.White;
            this.Flop2.Location = new System.Drawing.Point(110, 147);
            this.Flop2.Name = "Flop2";
            this.Flop2.Size = new System.Drawing.Size(68, 22);
            this.Flop2.TabIndex = 4;
            this.Flop2.Text = "XX";
            this.Flop2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Flop2.Visible = false;
            // 
            // Flop3
            // 
            this.Flop3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Flop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Flop3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Flop3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flop3.ForeColor = System.Drawing.Color.White;
            this.Flop3.Location = new System.Drawing.Point(206, 147);
            this.Flop3.Name = "Flop3";
            this.Flop3.Size = new System.Drawing.Size(68, 22);
            this.Flop3.TabIndex = 5;
            this.Flop3.Text = "XX";
            this.Flop3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Flop3.Visible = false;
            // 
            // Turn1
            // 
            this.Turn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Turn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Turn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Turn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn1.ForeColor = System.Drawing.Color.White;
            this.Turn1.Location = new System.Drawing.Point(302, 147);
            this.Turn1.Name = "Turn1";
            this.Turn1.Size = new System.Drawing.Size(68, 22);
            this.Turn1.TabIndex = 6;
            this.Turn1.Text = "XX";
            this.Turn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Turn1.Visible = false;
            // 
            // River1
            // 
            this.River1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.River1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.River1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.River1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.River1.ForeColor = System.Drawing.Color.White;
            this.River1.Location = new System.Drawing.Point(398, 147);
            this.River1.Name = "River1";
            this.River1.Size = new System.Drawing.Size(68, 22);
            this.River1.TabIndex = 7;
            this.River1.Text = "XX";
            this.River1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.River1.Visible = false;
            // 
            // PotText
            // 
            this.PotText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PotText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PotText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotText.ForeColor = System.Drawing.Color.White;
            this.PotText.Location = new System.Drawing.Point(291, 275);
            this.PotText.Name = "PotText";
            this.PotText.Size = new System.Drawing.Size(90, 22);
            this.PotText.TabIndex = 8;
            this.PotText.Text = "Pot: $0";
            this.PotText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PotText.Visible = false;
            // 
            // BetText
            // 
            this.BetText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BetText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BetText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetText.ForeColor = System.Drawing.Color.White;
            this.BetText.Location = new System.Drawing.Point(387, 275);
            this.BetText.Name = "BetText";
            this.BetText.Size = new System.Drawing.Size(90, 22);
            this.BetText.TabIndex = 9;
            this.BetText.Text = "Bet: $0";
            this.BetText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BetText.Visible = false;
            // 
            // PlayerLayout5
            // 
            this.PlayerLayout5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout5.ColumnCount = 2;
            this.PlayerLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout5.Controls.Add(this.Player5Card1, 0, 0);
            this.PlayerLayout5.Controls.Add(this.Player5Card2, 1, 0);
            this.PlayerLayout5.Controls.Add(this.Player5Money, 1, 4);
            this.PlayerLayout5.Controls.Add(this.BlindDealerText5, 0, 2);
            this.PlayerLayout5.Controls.Add(this.CurrentBet5, 1, 3);
            this.PlayerLayout5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout5.Location = new System.Drawing.Point(26, 523);
            this.PlayerLayout5.Name = "PlayerLayout5";
            this.PlayerLayout5.RowCount = 5;
            this.PlayerLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout5.Size = new System.Drawing.Size(190, 190);
            this.PlayerLayout5.TabIndex = 4;
            this.PlayerLayout5.Visible = false;
            // 
            // Player5Card1
            // 
            this.Player5Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player5Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player5Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player5Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5Card1.ForeColor = System.Drawing.Color.White;
            this.Player5Card1.Location = new System.Drawing.Point(13, 8);
            this.Player5Card1.Name = "Player5Card1";
            this.Player5Card1.Size = new System.Drawing.Size(68, 22);
            this.Player5Card1.TabIndex = 2;
            this.Player5Card1.Text = "XX";
            this.Player5Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player5Card2
            // 
            this.Player5Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player5Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player5Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player5Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5Card2.ForeColor = System.Drawing.Color.White;
            this.Player5Card2.Location = new System.Drawing.Point(108, 8);
            this.Player5Card2.Name = "Player5Card2";
            this.Player5Card2.Size = new System.Drawing.Size(68, 22);
            this.Player5Card2.TabIndex = 3;
            this.Player5Card2.Text = "XX";
            this.Player5Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player5Money
            // 
            this.Player5Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player5Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player5Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player5Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5Money.ForeColor = System.Drawing.Color.White;
            this.Player5Money.Location = new System.Drawing.Point(101, 158);
            this.Player5Money.Name = "Player5Money";
            this.Player5Money.Size = new System.Drawing.Size(82, 22);
            this.Player5Money.TabIndex = 0;
            this.Player5Money.Text = "$NULL";
            this.Player5Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText5
            // 
            this.BlindDealerText5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText5.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText5.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText5.Name = "BlindDealerText5";
            this.BlindDealerText5.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText5.TabIndex = 8;
            this.BlindDealerText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet5
            // 
            this.CurrentBet5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet5.ForeColor = System.Drawing.Color.White;
            this.CurrentBet5.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet5.Name = "CurrentBet5";
            this.CurrentBet5.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet5.TabIndex = 9;
            this.CurrentBet5.Text = "$0";
            this.CurrentBet5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerLayout4
            // 
            this.PlayerLayout4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout4.ColumnCount = 2;
            this.PlayerLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout4.Controls.Add(this.Player4Card1, 0, 0);
            this.PlayerLayout4.Controls.Add(this.Player4Card2, 1, 0);
            this.PlayerLayout4.Controls.Add(this.Player4Money, 1, 4);
            this.PlayerLayout4.Controls.Add(this.BlindDealerText4, 0, 2);
            this.PlayerLayout4.Controls.Add(this.CurrentBet4, 1, 3);
            this.PlayerLayout4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout4.Location = new System.Drawing.Point(391, 523);
            this.PlayerLayout4.Name = "PlayerLayout4";
            this.PlayerLayout4.RowCount = 5;
            this.PlayerLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout4.Size = new System.Drawing.Size(190, 190);
            this.PlayerLayout4.TabIndex = 11;
            this.PlayerLayout4.Visible = false;
            // 
            // Player4Card1
            // 
            this.Player4Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player4Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player4Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player4Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Card1.ForeColor = System.Drawing.Color.White;
            this.Player4Card1.Location = new System.Drawing.Point(13, 8);
            this.Player4Card1.Name = "Player4Card1";
            this.Player4Card1.Size = new System.Drawing.Size(68, 22);
            this.Player4Card1.TabIndex = 2;
            this.Player4Card1.Text = "XX";
            this.Player4Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player4Card2
            // 
            this.Player4Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player4Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player4Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player4Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Card2.ForeColor = System.Drawing.Color.White;
            this.Player4Card2.Location = new System.Drawing.Point(108, 8);
            this.Player4Card2.Name = "Player4Card2";
            this.Player4Card2.Size = new System.Drawing.Size(68, 22);
            this.Player4Card2.TabIndex = 3;
            this.Player4Card2.Text = "XX";
            this.Player4Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player4Money
            // 
            this.Player4Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player4Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player4Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player4Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4Money.ForeColor = System.Drawing.Color.White;
            this.Player4Money.Location = new System.Drawing.Point(101, 158);
            this.Player4Money.Name = "Player4Money";
            this.Player4Money.Size = new System.Drawing.Size(82, 22);
            this.Player4Money.TabIndex = 0;
            this.Player4Money.Text = "$NULL";
            this.Player4Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText4
            // 
            this.BlindDealerText4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText4.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText4.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText4.Name = "BlindDealerText4";
            this.BlindDealerText4.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText4.TabIndex = 8;
            this.BlindDealerText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet4
            // 
            this.CurrentBet4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet4.ForeColor = System.Drawing.Color.White;
            this.CurrentBet4.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet4.Name = "CurrentBet4";
            this.CurrentBet4.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet4.TabIndex = 9;
            this.CurrentBet4.Text = "$0";
            this.CurrentBet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerLayout3
            // 
            this.PlayerLayout3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayerLayout3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.PlayerLayout3.ColumnCount = 2;
            this.PlayerLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PlayerLayout3.Controls.Add(this.Player3Card1, 0, 0);
            this.PlayerLayout3.Controls.Add(this.Player3Card2, 1, 0);
            this.PlayerLayout3.Controls.Add(this.Player3Money, 1, 4);
            this.PlayerLayout3.Controls.Add(this.BlindDealerText3, 0, 2);
            this.PlayerLayout3.Controls.Add(this.CurrentBet3, 1, 3);
            this.PlayerLayout3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLayout3.Location = new System.Drawing.Point(755, 523);
            this.PlayerLayout3.Name = "PlayerLayout3";
            this.PlayerLayout3.RowCount = 5;
            this.PlayerLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PlayerLayout3.Size = new System.Drawing.Size(190, 190);
            this.PlayerLayout3.TabIndex = 9;
            this.PlayerLayout3.Visible = false;
            // 
            // Player3Card1
            // 
            this.Player3Card1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player3Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player3Card1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player3Card1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Card1.ForeColor = System.Drawing.Color.White;
            this.Player3Card1.Location = new System.Drawing.Point(13, 8);
            this.Player3Card1.Name = "Player3Card1";
            this.Player3Card1.Size = new System.Drawing.Size(68, 22);
            this.Player3Card1.TabIndex = 2;
            this.Player3Card1.Text = "XX";
            this.Player3Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player3Card2
            // 
            this.Player3Card2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player3Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player3Card2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player3Card2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Card2.ForeColor = System.Drawing.Color.White;
            this.Player3Card2.Location = new System.Drawing.Point(108, 8);
            this.Player3Card2.Name = "Player3Card2";
            this.Player3Card2.Size = new System.Drawing.Size(68, 22);
            this.Player3Card2.TabIndex = 3;
            this.Player3Card2.Text = "XX";
            this.Player3Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player3Money
            // 
            this.Player3Money.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player3Money.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Player3Money.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Player3Money.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3Money.ForeColor = System.Drawing.Color.White;
            this.Player3Money.Location = new System.Drawing.Point(101, 158);
            this.Player3Money.Name = "Player3Money";
            this.Player3Money.Size = new System.Drawing.Size(82, 22);
            this.Player3Money.TabIndex = 0;
            this.Player3Money.Text = "$NULL";
            this.Player3Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BlindDealerText3
            // 
            this.BlindDealerText3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlindDealerText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BlindDealerText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlindDealerText3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlindDealerText3.ForeColor = System.Drawing.Color.White;
            this.BlindDealerText3.Location = new System.Drawing.Point(4, 82);
            this.BlindDealerText3.Name = "BlindDealerText3";
            this.BlindDealerText3.Size = new System.Drawing.Size(87, 22);
            this.BlindDealerText3.TabIndex = 8;
            this.BlindDealerText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentBet3
            // 
            this.CurrentBet3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentBet3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CurrentBet3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBet3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBet3.ForeColor = System.Drawing.Color.White;
            this.CurrentBet3.Location = new System.Drawing.Point(98, 119);
            this.CurrentBet3.Name = "CurrentBet3";
            this.CurrentBet3.Size = new System.Drawing.Size(88, 22);
            this.CurrentBet3.TabIndex = 9;
            this.CurrentBet3.Text = "$0";
            this.CurrentBet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 198);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 319);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ConsoleTab
            // 
            this.ConsoleTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ConsoleTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.ConsoleTab.Controls.Add(this.ConsolePanel);
            this.ConsoleTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTab.Location = new System.Drawing.Point(4, 32);
            this.ConsoleTab.Name = "ConsoleTab";
            this.ConsoleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsoleTab.Size = new System.Drawing.Size(972, 724);
            this.ConsoleTab.TabIndex = 11;
            this.ConsoleTab.Text = "Console";
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsolePanel.BackColor = System.Drawing.Color.Black;
            this.ConsolePanel.Controls.Add(this.ConsoleSendButton);
            this.ConsolePanel.Controls.Add(this.RichConsoleText);
            this.ConsolePanel.Controls.Add(this.ConsoleInput);
            this.ConsolePanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsolePanel.Location = new System.Drawing.Point(0, 0);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(972, 724);
            this.ConsolePanel.TabIndex = 2;
            // 
            // ConsoleSendButton
            // 
            this.ConsoleSendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleSendButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConsoleSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleSendButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleSendButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleSendButton.Location = new System.Drawing.Point(876, 696);
            this.ConsoleSendButton.Name = "ConsoleSendButton";
            this.ConsoleSendButton.Size = new System.Drawing.Size(93, 25);
            this.ConsoleSendButton.TabIndex = 5;
            this.ConsoleSendButton.TabStop = false;
            this.ConsoleSendButton.Text = "Send";
            this.ConsoleSendButton.UseVisualStyleBackColor = false;
            // 
            // RichConsoleText
            // 
            this.RichConsoleText.BackColor = System.Drawing.Color.Black;
            this.RichConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichConsoleText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichConsoleText.ForeColor = System.Drawing.Color.Lime;
            this.RichConsoleText.Location = new System.Drawing.Point(0, 0);
            this.RichConsoleText.Name = "RichConsoleText";
            this.RichConsoleText.ReadOnly = true;
            this.RichConsoleText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichConsoleText.Size = new System.Drawing.Size(972, 690);
            this.RichConsoleText.TabIndex = 3;
            this.RichConsoleText.Text = "";
            // 
            // ConsoleInput
            // 
            this.ConsoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ConsoleInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleInput.ForeColor = System.Drawing.Color.Aqua;
            this.ConsoleInput.Location = new System.Drawing.Point(3, 696);
            this.ConsoleInput.Name = "ConsoleInput";
            this.ConsoleInput.Size = new System.Drawing.Size(870, 29);
            this.ConsoleInput.TabIndex = 4;
            // 
            // InfoTab
            // 
            this.InfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(199)))));
            this.InfoTab.Controls.Add(this.DebuggingInfoPanel);
            this.InfoTab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoTab.Location = new System.Drawing.Point(4, 32);
            this.InfoTab.Name = "InfoTab";
            this.InfoTab.Size = new System.Drawing.Size(972, 724);
            this.InfoTab.TabIndex = 5;
            this.InfoTab.Text = "Info";
            // 
            // DebuggingInfoPanel
            // 
            this.DebuggingInfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DebuggingInfoPanel.Controls.Add(this.DebuggingInfoPanel2);
            this.DebuggingInfoPanel.Controls.Add(this.DebuggingInfoPanel1);
            this.DebuggingInfoPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebuggingInfoPanel.Location = new System.Drawing.Point(-1, -1);
            this.DebuggingInfoPanel.Name = "DebuggingInfoPanel";
            this.DebuggingInfoPanel.Size = new System.Drawing.Size(977, 729);
            this.DebuggingInfoPanel.TabIndex = 18;
            // 
            // DebuggingInfoPanel2
            // 
            this.DebuggingInfoPanel2.ColumnCount = 3;
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebuggingInfoPanel2.Controls.Add(this.label5, 0, 0);
            this.DebuggingInfoPanel2.Controls.Add(this.lilypadLabel, 2, 0);
            this.DebuggingInfoPanel2.Controls.Add(this.GitHubLink, 2, 2);
            this.DebuggingInfoPanel2.Controls.Add(this.VersionLabel, 0, 1);
            this.DebuggingInfoPanel2.Controls.Add(this.label4, 0, 2);
            this.DebuggingInfoPanel2.Controls.Add(this.VersionNumberLabel, 2, 1);
            this.DebuggingInfoPanel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebuggingInfoPanel2.Location = new System.Drawing.Point(96, 143);
            this.DebuggingInfoPanel2.Name = "DebuggingInfoPanel2";
            this.DebuggingInfoPanel2.RowCount = 3;
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel2.Size = new System.Drawing.Size(471, 75);
            this.DebuggingInfoPanel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(46, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author:";
            // 
            // lilypadLabel
            // 
            this.lilypadLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lilypadLabel.AutoSize = true;
            this.lilypadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilypadLabel.ForeColor = System.Drawing.Color.White;
            this.lilypadLabel.Location = new System.Drawing.Point(138, 2);
            this.lilypadLabel.Name = "lilypadLabel";
            this.lilypadLabel.Size = new System.Drawing.Size(116, 21);
            this.lilypadLabel.TabIndex = 12;
            this.lilypadLabel.Text = "Lilypad-666";
            // 
            // GitHubLink
            // 
            this.GitHubLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.GitHubLink.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            this.GitHubLink.Location = new System.Drawing.Point(138, 52);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(59, 21);
            this.GitHubLink.TabIndex = 16;
            this.GitHubLink.TabStop = true;
            this.GitHubLink.Tag = "";
            this.GitHubLink.Text = "GitHub";
            this.GitHubLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.White;
            this.VersionLabel.Location = new System.Drawing.Point(38, 27);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(69, 21);
            this.VersionLabel.TabIndex = 15;
            this.VersionLabel.Text = "Version: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Source Code:";
            // 
            // VersionNumberLabel
            // 
            this.VersionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionNumberLabel.AutoSize = true;
            this.VersionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionNumberLabel.ForeColor = System.Drawing.Color.White;
            this.VersionNumberLabel.Location = new System.Drawing.Point(138, 27);
            this.VersionNumberLabel.Name = "VersionNumberLabel";
            this.VersionNumberLabel.Size = new System.Drawing.Size(0, 21);
            this.VersionNumberLabel.TabIndex = 16;
            // 
            // DebuggingInfoPanel1
            // 
            this.DebuggingInfoPanel1.ColumnCount = 1;
            this.DebuggingInfoPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DebuggingInfoPanel1.Controls.Add(this.label3, 0, 0);
            this.DebuggingInfoPanel1.Controls.Add(this.label2, 0, 1);
            this.DebuggingInfoPanel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebuggingInfoPanel1.Location = new System.Drawing.Point(2, 21);
            this.DebuggingInfoPanel1.Name = "DebuggingInfoPanel1";
            this.DebuggingInfoPanel1.RowCount = 2;
            this.DebuggingInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.DebuggingInfoPanel1.Size = new System.Drawing.Size(962, 50);
            this.DebuggingInfoPanel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thank you for trying out my program!";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "It is greatly appreciated!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.TitleBarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Program Scripts ";
            this.TitleBarPanel.ResumeLayout(false);
            this.TitleBarPanel.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.HoldemSettingsGroupBox.ResumeLayout(false);
            this.MainSettingsLayout.ResumeLayout(false);
            this.MainSettingsLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SBValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChipsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersValue)).EndInit();
            this.ConsoleSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.StartGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.customTabControl1.ResumeLayout(false);
            this.PokerSettingsTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ConsoleSettingsTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.VisualTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.PlayLayout.ResumeLayout(false);
            this.PlayerLayout2.ResumeLayout(false);
            this.PlayerLayout2.PerformLayout();
            this.PlayerLayout1.ResumeLayout(false);
            this.PlayerLayout1.PerformLayout();
            this.PlayerLayout0.ResumeLayout(false);
            this.PlayerLayout0.PerformLayout();
            this.MiddlePanel.ResumeLayout(false);
            this.MiddlePanel.PerformLayout();
            this.PlayerLayout5.ResumeLayout(false);
            this.PlayerLayout5.PerformLayout();
            this.PlayerLayout4.ResumeLayout(false);
            this.PlayerLayout4.PerformLayout();
            this.PlayerLayout3.ResumeLayout(false);
            this.PlayerLayout3.PerformLayout();
            this.ConsoleTab.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.InfoTab.ResumeLayout(false);
            this.DebuggingInfoPanel.ResumeLayout(false);
            this.DebuggingInfoPanel2.ResumeLayout(false);
            this.DebuggingInfoPanel2.PerformLayout();
            this.DebuggingInfoPanel1.ResumeLayout(false);
            this.DebuggingInfoPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel TitleBarPanel;
        public TitleBarButton ExitButton;
        public TitleBarButton MinimizeButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel GameInfoPanel1;
        public System.Windows.Forms.Label WindowInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.TextBox WindowYBox;
        public System.Windows.Forms.Label WindowHeightLabel;
        public System.Windows.Forms.Label WindowYLabel;
        public System.Windows.Forms.TextBox WindowWidthBox;
        public System.Windows.Forms.Label WindowXLabel;
        public System.Windows.Forms.TextBox WindowXBox;
        public System.Windows.Forms.TextBox WindowHeightBox;
        public System.Windows.Forms.Label WindowWidthLabel;
        public System.Windows.Forms.TabPage InfoTab;
        private System.Windows.Forms.TabPage VisualTab;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel PlayLayout;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout2;
        private System.Windows.Forms.TextBox Player2Card1;
        private System.Windows.Forms.TextBox Player2Card2;
        private System.Windows.Forms.TextBox Player2Money;
        private System.Windows.Forms.TextBox BlindDealerText2;
        private System.Windows.Forms.TextBox CurrentBet2;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout1;
        private System.Windows.Forms.TextBox Player1Card1;
        private System.Windows.Forms.TextBox Player1Card2;
        private System.Windows.Forms.TextBox Player1Money;
        private System.Windows.Forms.TextBox BlindDealerText1;
        private System.Windows.Forms.TextBox CurrentBet1;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout0;
        private System.Windows.Forms.TextBox Player0Card1;
        private System.Windows.Forms.TextBox Player0Card2;
        private System.Windows.Forms.TextBox Player0Money;
        private System.Windows.Forms.TextBox BlindDealerText0;
        private System.Windows.Forms.TextBox CurrentBet0;
        private System.Windows.Forms.TableLayoutPanel MiddlePanel;
        private System.Windows.Forms.TextBox Flop1;
        private System.Windows.Forms.TextBox Flop2;
        private System.Windows.Forms.TextBox Flop3;
        private System.Windows.Forms.TextBox Turn1;
        private System.Windows.Forms.TextBox River1;
        private System.Windows.Forms.TextBox PotText;
        private System.Windows.Forms.TextBox BetText;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout5;
        private System.Windows.Forms.TextBox Player5Card1;
        private System.Windows.Forms.TextBox Player5Card2;
        private System.Windows.Forms.TextBox Player5Money;
        private System.Windows.Forms.TextBox BlindDealerText5;
        private System.Windows.Forms.TextBox CurrentBet5;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout4;
        private System.Windows.Forms.TextBox Player4Card1;
        private System.Windows.Forms.TextBox Player4Card2;
        private System.Windows.Forms.TextBox Player4Money;
        private System.Windows.Forms.TextBox BlindDealerText4;
        private System.Windows.Forms.TextBox CurrentBet4;
        private System.Windows.Forms.TableLayoutPanel PlayerLayout3;
        private System.Windows.Forms.TextBox Player3Card1;
        private System.Windows.Forms.TextBox Player3Card2;
        private System.Windows.Forms.TextBox Player3Money;
        private System.Windows.Forms.TextBox BlindDealerText3;
        private System.Windows.Forms.TextBox CurrentBet3;
        public CustomTabControl MainTabControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.Panel panel1;
        private CustomButton StartHoldemButton;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Panel DebuggingInfoPanel;
        private System.Windows.Forms.TableLayoutPanel DebuggingInfoPanel2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lilypadLabel;
        public System.Windows.Forms.LinkLabel GitHubLink;
        public System.Windows.Forms.Label VersionLabel;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VersionNumberLabel;
        private System.Windows.Forms.TableLayoutPanel DebuggingInfoPanel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public CustomTabControl customTabControl1;
        public System.Windows.Forms.TabPage PokerSettingsTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomGroupBox StartGroupBox;
        private System.Windows.Forms.TabPage ConsoleTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TabPage ConsoleSettingsTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CustomGroupBox HoldemSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel MainSettingsLayout;
        private System.Windows.Forms.TextBox SBText;
        private System.Windows.Forms.NumericUpDown SBValue;
        private System.Windows.Forms.NumericUpDown ChipsValue;
        private System.Windows.Forms.TextBox ChipsText;
        private System.Windows.Forms.TextBox PlayersText;
        private System.Windows.Forms.NumericUpDown PlayersValue;
        private CustomGroupBox ConsoleSettingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private CustomCheckBox ConsolePopoutCheckbox;
        private System.Windows.Forms.Panel ConsolePanel;
        public CustomButton ConsoleSendButton;
        public System.Windows.Forms.RichTextBox RichConsoleText;
        public System.Windows.Forms.TextBox ConsoleInput;
    }
}