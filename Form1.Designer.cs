namespace WinFormsApp1
{
    partial class Form1
    {
   
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private Button button2;


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
            button1 = new Button();
            button2 = new Button();

            button1.Location = new Point(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 0;
            button1.BackColor = Color.Aqua;
            button1.Text = "Button 1";
            button1.Click += show_button_Click;

            button2.Location = new Point(50, 110);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.BackColor = Color.LightBlue;
            button2.TabIndex = 1;
            button2.Text = "Button 2";
            button2.Click += button2_Click;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Text = "Form1";
        }

        #endregion
    }
}
