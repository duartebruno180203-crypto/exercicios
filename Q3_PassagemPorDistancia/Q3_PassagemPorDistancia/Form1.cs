namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double km, valor;
            km = Convert.ToDouble(txtkm.Text);
            {
                if (km <= 200)
                {
                    valor = km * 0.50;
                }
                else
                {
                    valor = km * 0.45;
                }

                txtValor.Text = valor.ToString();
            }
        }
    }
}
