namespace DefinitleyMyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onCalcClick(object sender, EventArgs e)
        {
            textBox1.Text = (num1.Value + num2.Value).ToString();
        }
    }
}
