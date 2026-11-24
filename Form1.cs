namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button button || !TryGetInputValues(out var firstValue, out var secondValue))
            {
                return;
            }

            var result = button.Tag?.ToString() switch
            {
                "+" => firstValue + secondValue,
                "-" => firstValue - secondValue,
                _ => throw new InvalidOperationException("Unknown calculator operation.")
            };

            resultLabel.Text = $"Result: {result}";
        }

        private bool TryGetInputValues(out decimal firstValue, out decimal secondValue)
        {
            var firstValueIsValid = decimal.TryParse(firstValueTextBox.Text, out firstValue);
            var secondValueIsValid = decimal.TryParse(secondValueTextBox.Text, out secondValue);
            if (!firstValueIsValid || !secondValueIsValid)
            {
                MessageBox.Show("Enter a valid number in both fields.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
