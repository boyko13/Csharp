namespace Passwordgenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLenght = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLenght)
        {
            string allcharacters = "ABCDEFGHIJKLMNOPRSTUWXYZ0123456789abcdefghijKlmnoprstuwxyz!!@#$%^&*";
            string randomPassword = ""; 

            for (int i = 0; i < passwordLenght; i++)
            {
                int randomNum = character.Next(0, allcharacters.Length);
                randomPassword += allcharacters[randomNum];
            }
            Passwordlabel.Text = randomPassword;
        }
        public Form1()
        {
            InitializeComponent();
            passwordlenghtSlider.Minimum = 5;
            passwordlenghtSlider.Maximum = 20;
            passwordGenerator(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copyButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Passwordlabel.Text);
        }

        private void passwordlenghtSlider_Scroll(object sender, EventArgs e)
        {
            Passwordlenghtlabel.Text = "Password Lengh: " + passwordlenghtSlider.Value.ToString();
            currentPasswordLenght = passwordlenghtSlider.Value;
            passwordGenerator(currentPasswordLenght);
        }
    }
}
