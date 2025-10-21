namespace A1_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowButon_Click(object sender, EventArgs e)
        {
            yellowLabel.BackColor = Color.Yellow;
            yellowLabel.Text = "Yellow Text Set";
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            redLabel.BackColor = Color.Red;
            redLabel.Text = "Red Text Set";
        }

        //Too Lazy to copy&paste the rest. Sorry
    }
}
