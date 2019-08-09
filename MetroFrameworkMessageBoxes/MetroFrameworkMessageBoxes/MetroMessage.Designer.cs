namespace MetroFrameworkMessageBoxes
{
    partial class MetroMessage
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
            this.titleText = new MetroFramework.Controls.MetroLabel();
            this.messageText = new MetroFramework.Controls.MetroLabel();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titleText.Location = new System.Drawing.Point(14, 18);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(50, 25);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Title";
            this.titleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageText
            // 
            this.messageText.AutoSize = true;
            this.messageText.Location = new System.Drawing.Point(23, 43);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(60, 19);
            this.messageText.TabIndex = 1;
            this.messageText.Text = "Message";
            this.messageText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(312, 73);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // MetroMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 100);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.titleText);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroMessage";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Message";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel titleText;
        private MetroFramework.Controls.MetroLabel messageText;
        private MetroFramework.Controls.MetroButton okButton;
    }
}