namespace GeniyIdiot_WindowsFormApp_new
{
    public partial class WelcomeMenu : Form
    {
        public string NameUser;
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputUser = InputNameTextBox.Text;
            if (inputUser != string.Empty)
            {
                NameUser = inputUser;
                Close();
            }
        }
    }
}
