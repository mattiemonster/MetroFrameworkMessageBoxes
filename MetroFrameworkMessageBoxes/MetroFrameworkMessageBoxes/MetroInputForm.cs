using System;
using System.Windows.Forms;
using MetroFramework;

namespace MetroFrameworkMessageBoxes
{
    public partial class MetroInputForm : MetroFramework.Forms.MetroForm
    {
        public MetroInputForm(string title)
        {
            InitializeComponent();
            titleText.Text = title;
            ActiveControl = inputBox;
            inputBox.Focus();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetThemeDark()
        {
            Theme = MetroThemeStyle.Dark;
            titleText.Theme = MetroThemeStyle.Dark;
            inputBox.Theme = MetroThemeStyle.Dark;
            cancelButton.Theme = MetroThemeStyle.Dark;
            okButton.Theme = MetroThemeStyle.Dark;
        }

        public void SetThemeLight()
        {
            Theme = MetroThemeStyle.Light;
            titleText.Theme = MetroThemeStyle.Light;
            inputBox.Theme = MetroThemeStyle.Light;
            cancelButton.Theme = MetroThemeStyle.Light;
            okButton.Theme = MetroThemeStyle.Light;
        }

        public static DialogResult Show(String title, out String inputValue, MetroMessageTheme theme)
        {
            MetroInputForm inputBox = null;
            DialogResult results = DialogResult.None;

            using (inputBox = new MetroInputForm(title))
            {
                switch(theme)
                {
                    case MetroMessageTheme.Dark:
                        inputBox.SetThemeDark();
                        break;
                    case MetroMessageTheme.Light:
                        inputBox.SetThemeLight();
                        break;
                }

                results = inputBox.ShowDialog();
                inputValue = inputBox.inputBox.Text;
            }

            return results;
        }

        public static DialogResult Show(String title, out String inputValue)
        {
            MetroInputForm inputBox = null;
            DialogResult results = DialogResult.None;

            using (inputBox = new MetroInputForm(title))
            {
                results = inputBox.ShowDialog();
                inputValue = inputBox.inputBox.Text;
            }

            return results;
        }

    }
}
