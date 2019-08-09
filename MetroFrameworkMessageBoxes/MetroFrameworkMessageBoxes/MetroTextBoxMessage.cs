using MetroFramework;
using System.Windows.Forms;

namespace MetroFrameworkMessageBoxes
{
    public partial class MetroTextBoxMessage : MetroFramework.Forms.MetroForm
    {
        public MetroTextBoxMessage()
        {
            InitializeComponent();
        }

        public void SetThemeDark()
        {
            Theme = MetroThemeStyle.Dark;
            titleText.Theme = MetroThemeStyle.Dark;
            messageText.Theme = MetroThemeStyle.Dark;
            okButton.Theme = MetroThemeStyle.Dark;
        }

        public void SetThemeLight()
        {
            Theme = MetroThemeStyle.Light;
            titleText.Theme = MetroThemeStyle.Light;
            messageText.Theme = MetroThemeStyle.Light;
            okButton.Theme = MetroThemeStyle.Light;
        }

        public static void Show(string title, string message)
        {
            MetroTextBoxMessage msg = new MetroTextBoxMessage();
            msg.titleText.Text = title;
            msg.messageText.Text = message;
            msg.ShowDialog();
        }

        public static void Show(string title, string message, MetroMessageTheme theme)
        {
            MetroTextBoxMessage msg = new MetroTextBoxMessage();
            msg.titleText.Text = title;
            msg.messageText.Text = message;

            switch (theme)
            {
                case MetroMessageTheme.Dark:
                    msg.SetThemeDark();
                    break;
                case MetroMessageTheme.Light:
                    msg.SetThemeLight();
                    break;
            }

            msg.ShowDialog();
        }

        public static void Show(string title, string message, IWin32Window owner)
        {
            MetroTextBoxMessage msg = new MetroTextBoxMessage();
            msg.titleText.Text = title;
            msg.messageText.Text = message;
            msg.ShowDialog(owner);
        }

        public static void Show(string title, string message, MetroMessageTheme theme, IWin32Window owner)
        {
            MetroTextBoxMessage msg = new MetroTextBoxMessage();
            msg.titleText.Text = title;
            msg.messageText.Text = message;

            switch (theme)
            {
                case MetroMessageTheme.Dark:
                    msg.SetThemeDark();
                    break;
                case MetroMessageTheme.Light:
                    msg.SetThemeLight();
                    break;
            }

            msg.ShowDialog(owner);
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
