namespace WinFormsApp1
{
    partial class Form1
    {
   
        private System.ComponentModel.IContainer components = null;
        private TextBox firstValueTextBox;
        private TextBox secondValueTextBox;
        private Button addButton;
        private Button subtractButton;
        private Label resultLabel;
        private TableLayoutPanel calculatorLayout;

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
            addButton = new Button();
            subtractButton = new Button();
            resultLabel = new Label();
            calculatorLayout = new TableLayoutPanel();

            firstValueTextBox.Dock = DockStyle.Fill;
            firstValueTextBox.Name = "firstValueTextBox";
            firstValueTextBox.TabIndex = 0;

            secondValueTextBox.Dock = DockStyle.Fill;
            secondValueTextBox.Name = "secondValueTextBox";
            secondValueTextBox.TabIndex = 1;

            addButton.AutoSize = true;
            addButton.Name = "addButton";
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Tag = "+";
            addButton.Click += calculateButton_Click;

            subtractButton.AutoSize = true;
            subtractButton.Name = "subtractButton";
            subtractButton.Text = "Subtract";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Tag = "-";
            subtractButton.Click += calculateButton_Click;

            resultLabel.AutoSize = true;
            resultLabel.Name = "resultLabel";
            resultLabel.Text = "Result:";

            calculatorLayout.AutoSize = true;
            calculatorLayout.ColumnCount = 2;
            calculatorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            calculatorLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            calculatorLayout.Location = new Point(30, 30);
            calculatorLayout.Padding = new Padding(12);
            calculatorLayout.RowCount = 4;
            calculatorLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            calculatorLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            calculatorLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            calculatorLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            calculatorLayout.Controls.Add(new Label { AutoSize = true, Text = "First value:" }, 0, 0);
            calculatorLayout.Controls.Add(firstValueTextBox, 1, 0);
            calculatorLayout.Controls.Add(new Label { AutoSize = true, Text = "Second value:" }, 0, 1);
            calculatorLayout.Controls.Add(secondValueTextBox, 1, 1);
            calculatorLayout.Controls.Add(addButton, 0, 2);
            calculatorLayout.Controls.Add(subtractButton, 1, 2);
            calculatorLayout.Controls.Add(resultLabel, 0, 3);
            calculatorLayout.SetColumnSpan(resultLabel, 2);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculatorLayout);
            Text = "Calculator v3";
        }

        #endregion
    }
}
