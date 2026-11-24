namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //საკითხი 1
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (TryGetInputValues(out var firstValue, out var secondValue))
            {
                resultLabel.Text = $"Result: {firstValue * secondValue}";
            }
        }


        //საკითხი 2
        private void divideButton_Click(object sender, EventArgs e)
        {
            if (!TryGetInputValues(out var firstValue, out var secondValue))
            {
                return;
            }

            if (secondValue == 0)
            {
                MessageBox.Show("The second value cannot be zero when dividing.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            resultLabel.Text = $"Result: {firstValue / secondValue}";
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
