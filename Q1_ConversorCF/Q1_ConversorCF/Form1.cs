namespace Q1_ConversorCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double Celsius, Resultado;
            //Entrada

            Celsius = Convert.ToDouble(txtcelsius.Text);
            //Processamento
            Resultado = (Celsius * 9 / 5) + 32;
            //Saida
            lbresultado.Text = Resultado.ToString();
        }
    }
}
