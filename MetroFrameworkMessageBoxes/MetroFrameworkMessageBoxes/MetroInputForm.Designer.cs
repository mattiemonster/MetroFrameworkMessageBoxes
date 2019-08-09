namespace MetroFrameworkMessageBoxes
{
    partial class MetroInputForm
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
            this.inputBox = new MetroFramework.Controls.MetroTextBox();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.titleText = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(36, 62);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(337, 23);
            this.inputBox.TabIndex = 0;
            this.inputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(333, 91);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(40, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(268, 91);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(59, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.titleText.Location = new System.Drawing.Point(23, 21);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(96, 25);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "Input Box";
            this.titleText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MetroInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 127);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.inputBox);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroInputForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Input Box";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox inputBox;
        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroLabel titleText;
    }
}