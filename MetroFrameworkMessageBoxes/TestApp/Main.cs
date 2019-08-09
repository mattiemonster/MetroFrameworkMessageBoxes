using System;
using System.Windows.Forms;
using MetroFrameworkMessageBoxes;

namespace TestApp
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            msgBoxTheme.SelectedIndex = 0;
            inputBoxTheme.SelectedIndex = 0;
            textBoxMsgTheme.SelectedIndex = 0;
        }

        private void ShowMsgButton_Click(object sender, EventArgs e)
        {
            if (msgBoxTheme.SelectedIndex < 0 || msgBoxTheme.SelectedIndex > 1)
                return;

            if (msgBoxTheme.SelectedIndex == 0)
                MetroMessage.Show(msgBoxTitleText.Text, msgBoxMsgText.Text, MetroMessageTheme.Light);
            else
                MetroMessage.Show(msgBoxTitleText.Text, msgBoxMsgText.Text, MetroMessageTheme.Dark);
        }

        private void OpenInputBoxButton_Click(object sender, EventArgs e)
        {
            if (inputBoxTheme.SelectedIndex < 0 || inputBoxTheme.SelectedIndex > 1)
                return;

            string input;
            DialogResult result;

            if (inputBoxTheme.SelectedIndex == 0)
            {
                result = MetroInputForm.Show(inputBoxTitleText.Text, out input, MetroMessageTheme.Light);
            }
            else
            {
                result = MetroInputForm.Show(inputBoxTitleText.Text, out input, MetroMessageTheme.Dark);
            }

            if (result == DialogResult.OK)
                inputText.Text = input;
        }

        private void ShowTextBoxMsgButton_Click(object sender, EventArgs e)
        {
            if (textBoxMsgTheme.SelectedIndex < 0 || textBoxMsgTheme.SelectedIndex > 1)
                return;

            if (textBoxMsgTheme.SelectedIndex == 0)
                MetroTextBoxMessage.Show(textBoxMsgTitle.Text, textBoxMsgText.Text, MetroMessageTheme.Light);
            else
                MetroTextBoxMessage.Show(textBoxMsgTitle.Text, textBoxMsgText.Text, MetroMessageTheme.Dark);
        }
    }
}
