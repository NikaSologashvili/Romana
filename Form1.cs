namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            BackColor = Color.Aqua;
            MessageBox.Show("Button 1 was clicked!", "Button 1");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
            MessageBox.Show("Button 2 was clicked!", "Button 2");
        }
    }
}
