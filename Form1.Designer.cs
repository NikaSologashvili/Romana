namespace WinFormsApp1
{
    partial class Form1
    {
   
        private System.ComponentModel.IContainer components = null;
        private TextBox firstValueTextBox;
        private TextBox secondValueTextBox;
        private Button multiplyButton;
        private Button divideButton;
        private Label resultLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            firstValueTextBox = new TextBox();
            secondValueTextBox = new TextBox();
            multiplyButton = new Button();
            divideButton = new Button();
            resultLabel = new Label();

            var firstValueLabel = new Label();
            firstValueLabel.AutoSize = true;
            firstValueLabel.Location = new Point(50, 53);
            firstValueLabel.Text = "First value:";

            firstValueTextBox.Location = new Point(150, 50);
            firstValueTextBox.Name = "firstValueTextBox";
            firstValueTextBox.Size = new Size(180, 23);
            firstValueTextBox.TabIndex = 0;

            var secondValueLabel = new Label();
            secondValueLabel.AutoSize = true;
            secondValueLabel.Location = new Point(50, 93);
            secondValueLabel.Text = "Second value:";

            secondValueTextBox.Location = new Point(150, 90);
            secondValueTextBox.Name = "secondValueTextBox";
            secondValueTextBox.Size = new Size(180, 23);
            secondValueTextBox.TabIndex = 1;

            multiplyButton.Location = new Point(50, 135);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(120, 40);
            multiplyButton.TabIndex = 2;
            multiplyButton.Text = "Multiply";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;

            divideButton.Location = new Point(190, 135);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(120, 40);
            divideButton.TabIndex = 3;
            divideButton.Text = "Divide";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;

            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(50, 195);
            resultLabel.Name = "resultLabel";
            resultLabel.Text = "Result:";

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(firstValueLabel);
            Controls.Add(firstValueTextBox);
            Controls.Add(secondValueLabel);
            Controls.Add(secondValueTextBox);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(resultLabel);
            Text = "Calculator";
        }

        #endregion
    }
}
