namespace Schleifen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedOperation = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (selectedOperation is null)
            {
                resultTextBox.Text = "Wähle eine Operation aus!";
                return;
            }

            if (sbyte.TryParse(textBox1.Text, out var n1) && sbyte.TryParse(textBox2.Text, out var n2))
            {
                DoCalculation(selectedOperation!.Text, n1, n2);
            }
            else
            {
                resultTextBox.Text = "Nur Zahlen von -128 bus 127 erlaubt!";
                return;
            }
        }

        private void DoCalculation(string operation, sbyte n1, sbyte n2)
        {
            try
            {
                var result = "";
                switch (operation)
                {
                    case "+":
                        {
                            result = (n1 + n2).ToString();
                        }
                        break;
                    case "-":
                        {
                            result = (n1 - n2).ToString();
                        }
                        break;
                    case "*":
                        {
                            result = (n1 * n2).ToString();
                        }
                        break;
                    case "/":
                        {
                            result = ((Decimal)n1 / (Decimal)n2).ToString();
                        }
                        break;
                }

                resultTextBox.Text = result;
                listBox1.Items.Add($"{n1} {operation} {n2} = {result}");
            }

            catch (DivideByZeroException ex)
            {
                resultTextBox.Text = "Kann nicht durch 0 dividieren. DUMME SIECH!!!!";
                listBox1.Items.Add($"{n1} {operation} {n2} = ERROR");
            }
            catch (Exception ex)
            {
                resultTextBox.Text = "Something went very wrong";
                listBox1.Items.Add($"{n1} {operation} {n2} = ERROR");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
