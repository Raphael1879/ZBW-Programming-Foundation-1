namespace A5_1_1
{
    public partial class Picker : Form
    {
        public Picker()
        {
            InitializeComponent();
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            redValueLabel.Text = redTrackBar.Value.ToString();
            CalculateColor();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            greenValueLabel.Text = greenTrackBar.Value.ToString();
            CalculateColor();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            blueValueLabel.Text = blueTrackBar.Value.ToString();
            CalculateColor();

        }


        private void CalculateColor()
        {
            var red = redTrackBar.Value;
            var blue = blueTrackBar.Value;
            var green = greenTrackBar.Value;

            colorBox.BackColor = Color.FromArgb(255, red, green, blue);
            CalculateColorLabelBasedOnRadioButtons();
        }


        private void CalculateColorLabelBasedOnRadioButtons()
        {
            var color = colorBox.BackColor;

            if (dezimalRadioButton.Checked)
            {
                colorValueLabel.Text = colorBox?.BackColor.ToString() ?? "undefined";
            }
            else if (hexRadioButton.Checked)
            {
                colorValueLabel.Text = $"#{color.R:X2}{color.G:X2}{color.B:X2}";

            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) => CalculateColorLabelBasedOnRadioButtons();
        
    }
}
