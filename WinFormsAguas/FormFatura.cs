using Biblioteca;

namespace WinFormsAguas
{
    public partial class FormFatura : Form
    {
        private List<Cliente> _listaClientes;

        private Fatura _faturaSelecionada;
        public FormFatura(List<Cliente> listaClientes)
        {
            InitializeComponent();
            _listaClientes = listaClientes;

            //mostra 30 dias para tras, para mostrar o historico do último mês
            dateTimePickerInicio.Value = DateTime.Today.AddDays(-30);

            comboBoxEstado.SelectedIndex = 0;

        }

        private void FormFatura_Load(object sender, EventArgs e)
        {
            //selecionar a linha toda do datagridview
            dataGridViewListaFaturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            String nomeCliente = txtCliente.Text;
            DateTime dataInicio = dateTimePickerInicio.Value;
            DateTime dataFim = dateTimePickerFim.Value;

            //aviso para escolher estado de pagamento
            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um estado de pagamento!",
                   "Aviso",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }
            //pega o estado de pagamento
            string estadoFatura = comboBoxEstado.SelectedItem.ToString();

            //lista temporaria para guardar as faturas
            List<Fatura> tempListaFatura = new List<Fatura>();

            foreach (Cliente cliente in _listaClientes)
            {
                if (cliente.Nome.ToLower() == nomeCliente.ToLower() || nomeCliente == string.Empty)
                {
                    foreach (Contador contador in cliente.ListaContadores)
                    {
                        foreach (Fatura fatura in contador.ListaFaturas)
                        {
                            if (fatura.DataEmissao >= dataInicio && fatura.DataEmissao <= dataFim)
                            {
                                if (comboBoxEstado.SelectedIndex == 0) // Todas
                                {
                                    tempListaFatura.Add(fatura);
                                }
                                else if (comboBoxEstado.SelectedIndex == 1 && fatura.Pago == true && fatura.Anulada == false) // Faturas Pagas
                                {
                                    tempListaFatura.Add(fatura);
                                }
                                else if (comboBoxEstado.SelectedIndex == 2 && fatura.Pago == false && fatura.Anulada == false) // Em dívida
                                {
                                    tempListaFatura.Add(fatura);
                                }
                            }
                        }
                    }
                }
            }

            dataGridViewListaFaturas.DataSource = null;
            dataGridViewListaFaturas.DataSource = tempListaFatura;

            dataGridViewListaFaturas.Columns["ValorFatura"].DefaultCellStyle.Format = "C2";
            dataGridViewListaFaturas.Columns["ValorFatura"].HeaderText = "Valor";

            //para a lista iniciar sempre limpa
            dataGridViewListaFaturas.CurrentCell = null;
            dataGridViewListaFaturas.ClearSelection();


        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrirFatura_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaFaturas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione uma Fatura na tabela para realizar a consulta!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _faturaSelecionada = (Fatura)dataGridViewListaFaturas.CurrentRow.DataBoundItem;

            FormVisualizarFatura formVisualizarFatura = new FormVisualizarFatura(_faturaSelecionada);
            formVisualizarFatura.Show();

        }

        private void lblFaturacao_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
