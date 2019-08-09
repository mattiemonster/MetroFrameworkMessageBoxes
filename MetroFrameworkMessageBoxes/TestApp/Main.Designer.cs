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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.msgBoxTitleText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.msgBoxMsgText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.msgBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.showMsgButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.inputBoxTitleText = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.inputText = new MetroFramework.Controls.MetroLabel();
            this.openInputBoxButton = new MetroFramework.Controls.MetroButton();
            this.inputBoxTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(163, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Message Box Test";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // msgBoxTitleText
            // 
            this.msgBoxTitleText.Location = new System.Drawing.Point(23, 107);
            this.msgBoxTitleText.Name = "msgBoxTitleText";
            this.msgBoxTitleText.Size = new System.Drawing.Size(365, 23);
            this.msgBoxTitleText.TabIndex = 1;
            this.msgBoxTitleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Title";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Message";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // msgBoxMsgText
            // 
            this.msgBoxMsgText.Location = new System.Drawing.Point(23, 155);
            this.msgBoxMsgText.Name = "msgBoxMsgText";
            this.msgBoxMsgText.Size = new System.Drawing.Size(365, 23);
            this.msgBoxMsgText.TabIndex = 2;
            this.msgBoxMsgText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 181);
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
            this.msgBoxTheme.Location = new System.Drawing.Point(23, 203);
            this.msgBoxTheme.Name = "msgBoxTheme";
            this.msgBoxTheme.Size = new System.Drawing.Size(365, 29);
            this.msgBoxTheme.TabIndex = 3;
            this.msgBoxTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // showMsgButton
            // 
            this.showMsgButton.Location = new System.Drawing.Point(23, 239);
            this.showMsgButton.Name = "showMsgButton";
            this.showMsgButton.Size = new System.Drawing.Size(365, 23);
            this.showMsgButton.TabIndex = 4;
            this.showMsgButton.Text = "Show Message";
            this.showMsgButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.showMsgButton.Click += new System.EventHandler(this.ShowMsgButton_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Title";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inputBoxTitleText
            // 
            this.inputBoxTitleText.Location = new System.Drawing.Point(23, 321);
            this.inputBoxTitleText.Name = "inputBoxTitleText";
            this.inputBoxTitleText.Size = new System.Drawing.Size(365, 23);
            this.inputBoxTitleText.TabIndex = 5;
            this.inputBoxTitleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 274);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(135, 25);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Input Box Test";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 401);
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
            this.inputText.Location = new System.Drawing.Point(23, 420);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(69, 19);
            this.inputText.TabIndex = 12;
            this.inputText.Text = "(no input)";
            this.inputText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openInputBoxButton
            // 
            this.openInputBoxButton.Location = new System.Drawing.Point(23, 504);
            this.openInputBoxButton.Name = "openInputBoxButton";
            this.openInputBoxButton.Size = new System.Drawing.Size(365, 23);
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
            this.inputBoxTheme.Location = new System.Drawing.Point(23, 369);
            this.inputBoxTheme.Name = "inputBoxTheme";
            this.inputBoxTheme.Size = new System.Drawing.Size(365, 29);
            this.inputBoxTheme.TabIndex = 6;
            this.inputBoxTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 347);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Theme";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.inputBoxTheme);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.openInputBoxButton);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.inputBoxTitleText);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.showMsgButton);
            this.Controls.Add(this.msgBoxTheme);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.msgBoxMsgText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.msgBoxTitleText);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "Metro Message Boxes Test";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox msgBoxTitleText;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox msgBoxMsgText;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox msgBoxTheme;
        private MetroFramework.Controls.MetroButton showMsgButton;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox inputBoxTitleText;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel inputText;
        private MetroFramework.Controls.MetroButton openInputBoxButton;
        private MetroFramework.Controls.MetroComboBox inputBoxTheme;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}

