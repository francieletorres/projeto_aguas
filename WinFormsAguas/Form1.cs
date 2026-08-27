using Biblioteca;

namespace WinFormsAguas
{
    public partial class FormPrincipal : Form
    {
        List<Cliente> ListaClientes;

        public FormPrincipal()
        {
            InitializeComponent();

            // ListaClientes = new List<Cliente>();
            ListaClientes = GestaoFicheiros.LerClientes();
            GestaoFicheiros.LerContadores(ListaClientes);
            GestaoFicheiros.LerConsumos(ListaClientes);
            GestaoFicheiros.LerFaturas(ListaClientes);

        }
       
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FormCadCliente formCliente = new FormCadCliente(ListaClientes);
            formCliente.Show();
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            FormContador formContador = new FormContador(ListaClientes);
            formContador.Show();
        }

        private void btnLeituraContador_Click(object sender, EventArgs e)
        {
            FormConsumo formConsumo = new FormConsumo(ListaClientes);
            formConsumo.Show();
        }

        private void btnFaturacao_Click(object sender, EventArgs e)
        {
            FormFatura formFaturacao = new FormFatura(ListaClientes);
            formFaturacao.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.Show();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                GestaoFicheiros.GravarClientes(ListaClientes);
                GestaoFicheiros.GravarContadores(ListaClientes);
                GestaoFicheiros.GravarConsumos(ListaClientes);
                GestaoFicheiros.GravarFaturas(ListaClientes);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar arquivo: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

    }
}
