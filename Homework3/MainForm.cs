namespace Homework3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string getInputFieldValue()
        {
            if (int.TryParse(inputField.Text, out int n))
            {
                return "You've Entered the Number " + inputField.Text;
            }
            else
            {
                return "You've entered an ivalid value, please reenter";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox msgBox = new MessageBox(this);
            msgBox.ShowDialog();
        }
    }
}