using System;

namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            //Entrada de Dados
            double Cotacao;
            double Dolares;
            double resultado;
            //Processamento de Dados
            Cotacao = Convert.ToDouble(txtcotacao.Text);
            Dolares = Convert.ToDouble(txtdolares.Text);
            resultado = Cotacao * Dolares;
            //Saida de Dados
            lbresultado.Text = resultado.ToString();

        }
    }
}
