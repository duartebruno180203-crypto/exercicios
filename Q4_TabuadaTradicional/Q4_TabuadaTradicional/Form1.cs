namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            textBox1.Focus();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}
