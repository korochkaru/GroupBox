namespace groupbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        { 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        int clicks = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            if (clicks == 0) { label1.Text = "Зачем кликаешь?"; };
            if (clicks == 1) { label1.Text = "Ничего не будет. (2)"; };
            if (clicks == 2) { label1.Text = "Ладно. (3)"; };
            if (clicks == 3) { label1.Text = "Хватит, нет? (4)"; };
            if (clicks == 4) { label1.Text = "Пока. (5)"; };
            if (clicks == 5) { this.Close(); };
            clicks++;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { label1.Text = "Выбрана клубника."; }
            if (radioButton2.Checked) { label1.Text = "Выбрана земляника."; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
