namespace TestApp
{
    partial class Main
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
            this.msgBoxTitleText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.msgBoxMsgText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.msgBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.showMsgButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.inputBoxTitleText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.inputText = new MetroFramework.Controls.MetroLabel();
            this.openInputBoxButton = new MetroFramework.Controls.MetroButton();
            this.inputBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.msgBoxTab = new MetroFramework.Controls.MetroTabPage();
            this.textBoxMsgTab = new MetroFramework.Controls.MetroTabPage();
            this.inputBoxMessage = new MetroFramework.Controls.MetroTabPage();
            this.tabs.SuspendLayout();
            this.msgBoxTab.SuspendLayout();
            this.inputBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgBoxTitleText
            // 
            this.msgBoxTitleText.Location = new System.Drawing.Point(3, 26);
            this.msgBoxTitleText.Name = "msgBoxTitleText";
            this.msgBoxTitleText.Size = new System.Drawing.Size(936, 23);
            this.msgBoxTitleText.TabIndex = 1;
            this.msgBoxTitleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Title";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Message";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // msgBoxMsgText
            // 
            this.msgBoxMsgText.Location = new System.Drawing.Point(3, 74);
            this.msgBoxMsgText.Name = "msgBoxMsgText";
            this.msgBoxMsgText.Size = new System.Drawing.Size(936, 23);
            this.msgBoxMsgText.TabIndex = 2;
            this.msgBoxMsgText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Theme";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // msgBoxTheme
            // 
            this.msgBoxTheme.FormattingEnabled = true;
            this.msgBoxTheme.ItemHeight = 23;
            this.msgBoxTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.msgBoxTheme.Location = new System.Drawing.Point(3, 122);
            this.msgBoxTheme.Name = "msgBoxTheme";
            this.msgBoxTheme.Size = new System.Drawing.Size(936, 29);
            this.msgBoxTheme.TabIndex = 3;
            this.msgBoxTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // showMsgButton
            // 
            this.showMsgButton.Location = new System.Drawing.Point(3, 157);
            this.showMsgButton.Name = "showMsgButton";
            this.showMsgButton.Size = new System.Drawing.Size(936, 23);
            this.showMsgButton.TabIndex = 4;
            this.showMsgButton.Text = "Show Message";
            this.showMsgButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.showMsgButton.Click += new System.EventHandler(this.ShowMsgButton_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Title";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inputBoxTitleText
            // 
            this.inputBoxTitleText.Location = new System.Drawing.Point(3, 26);
            this.inputBoxTitleText.Name = "inputBoxTitleText";
            this.inputBoxTitleText.Size = new System.Drawing.Size(933, 23);
            this.inputBoxTitleText.TabIndex = 5;
            this.inputBoxTitleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 106);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Input:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inputText
            // 
            this.inputText.AutoSize = true;
            this.inputText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.inputText.Location = new System.Drawing.Point(3, 125);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(69, 19);
            this.inputText.TabIndex = 12;
            this.inputText.Text = "(no input)";
            this.inputText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openInputBoxButton
            // 
            this.openInputBoxButton.Location = new System.Drawing.Point(3, 401);
            this.openInputBoxButton.Name = "openInputBoxButton";
            this.openInputBoxButton.Size = new System.Drawing.Size(933, 23);
            this.openInputBoxButton.TabIndex = 7;
            this.openInputBoxButton.Text = "Open Input Box";
            this.openInputBoxButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.openInputBoxButton.Click += new System.EventHandler(this.OpenInputBoxButton_Click);
            // 
            // inputBoxTheme
            // 
            this.inputBoxTheme.FormattingEnabled = true;
            this.inputBoxTheme.ItemHeight = 23;
            this.inputBoxTheme.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.inputBoxTheme.Location = new System.Drawing.Point(3, 74);
            this.inputBoxTheme.Name = "inputBoxTheme";
            this.inputBoxTheme.Size = new System.Drawing.Size(933, 29);
            this.inputBoxTheme.TabIndex = 6;
            this.inputBoxTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(3, 52);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Theme";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.msgBoxTab);
            this.tabs.Controls.Add(this.textBoxMsgTab);
            this.tabs.Controls.Add(this.inputBoxMessage);
            this.tabs.Location = new System.Drawing.Point(23, 63);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(947, 464);
            this.tabs.TabIndex = 15;
            this.tabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // msgBoxTab
            // 
            this.msgBoxTab.Controls.Add(this.metroLabel2);
            this.msgBoxTab.Controls.Add(this.msgBoxTitleText);
            this.msgBoxTab.Controls.Add(this.metroLabel3);
            this.msgBoxTab.Controls.Add(this.msgBoxMsgText);
            this.msgBoxTab.Controls.Add(this.metroLabel4);
            this.msgBoxTab.Controls.Add(this.msgBoxTheme);
            this.msgBoxTab.Controls.Add(this.showMsgButton);
            this.msgBoxTab.HorizontalScrollbarBarColor = true;
            this.msgBoxTab.Location = new System.Drawing.Point(4, 35);
            this.msgBoxTab.Name = "msgBoxTab";
            this.msgBoxTab.Size = new System.Drawing.Size(939, 425);
            this.msgBoxTab.TabIndex = 0;
            this.msgBoxTab.Text = "Message Box";
            this.msgBoxTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.msgBoxTab.VerticalScrollbarBarColor = true;
            // 
            // textBoxMsgTab
            // 
            this.textBoxMsgTab.HorizontalScrollbarBarColor = true;
            this.textBoxMsgTab.Location = new System.Drawing.Point(4, 35);
            this.textBoxMsgTab.Name = "textBoxMsgTab";
            this.textBoxMsgTab.Size = new System.Drawing.Size(939, 425);
            this.textBoxMsgTab.TabIndex = 1;
            this.textBoxMsgTab.Text = "Text Box Message";
            this.textBoxMsgTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBoxMsgTab.VerticalScrollbarBarColor = true;
            // 
            // inputBoxMessage
            // 
            this.inputBoxMessage.Controls.Add(this.openInputBoxButton);
            this.inputBoxMessage.Controls.Add(this.inputBoxTheme);
            this.inputBoxMessage.Controls.Add(this.inputText);
            this.inputBoxMessage.Controls.Add(this.metroLabel7);
            this.inputBoxMessage.Controls.Add(this.metroLabel8);
            this.inputBoxMessage.Controls.Add(this.metroLabel5);
            this.inputBoxMessage.Controls.Add(this.inputBoxTitleText);
            this.inputBoxMessage.HorizontalScrollbarBarColor = true;
            this.inputBoxMessage.Location = new System.Drawing.Point(4, 35);
            this.inputBoxMessage.Name = "inputBoxMessage";
            this.inputBoxMessage.Size = new System.Drawing.Size(939, 425);
            this.inputBoxMessage.TabIndex = 2;
            this.inputBoxMessage.Text = "Input Box Message";
            this.inputBoxMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inputBoxMessage.VerticalScrollbarBarColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 550);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Metro Message Boxes Test";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabs.ResumeLayout(false);
            this.msgBoxTab.ResumeLayout(false);
            this.msgBoxTab.PerformLayout();
            this.inputBoxMessage.ResumeLayout(false);
            this.inputBoxMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox msgBoxTitleText;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox msgBoxMsgText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox msgBoxTheme;
        private MetroFramework.Controls.MetroButton showMsgButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox inputBoxTitleText;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel inputText;
        private MetroFramework.Controls.MetroButton openInputBoxButton;
        private MetroFramework.Controls.MetroComboBox inputBoxTheme;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage msgBoxTab;
        private MetroFramework.Controls.MetroTabPage textBoxMsgTab;
        private MetroFramework.Controls.MetroTabPage inputBoxMessage;
    }
}

