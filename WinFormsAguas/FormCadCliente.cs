using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsAguas
{
    public partial class FormCadCliente : Form
    {
        List<Cliente> _listaClientes;

        int contaClientes;

        public FormCadCliente(List<Cliente> listaCliente)
        {

            InitializeComponent();
            _listaClientes = listaCliente;

        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {

            InitLista();

        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente;

            if (ValidaForm())
            {
                contaClientes = 0;

                if (_listaClientes != null)
                {
                    // atribui os id na ordem correta
                    foreach (Cliente cliente in _listaClientes)
                    {
                        if (cliente.Id > contaClientes)
                        {
                            contaClientes = cliente.Id;
                        }
                    }
                }

                contaClientes++;

                novoCliente = new Cliente
                {
                    Id = contaClientes,
                    Nome = txtNomeCliente.Text,
                    Morada = txtMorada.Text,
                    Contacto = Convert.ToInt32(txtContacto.Text),
                    Nif = Convert.ToInt32(txtNif.Text),
                    Email = txtEmail.Text,
                    Estado = true,
                    ListaContadores = new List<Contador>(),
                };

                _listaClientes.Add(novoCliente);

                //atualiza o grid na tela
                InitLista();

                //limpar os inputs  depois que guarda
                limparCamposCliente();

            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Inicializa e atualiza a tabela (DataGridView) com a lista atual de clientes.
        /// </summary>
        public void InitLista()
        {
            //limpar o grid view antes
            DataGridViewClientes.DataSource = null;

            //lista vazia dava erro, por isso preciso do if
            if (_listaClientes.Count > 0)
            {

                //mostra os clientes
                DataGridViewClientes.DataSource = _listaClientes;

                // oculta algumas propriedades da lista
                //DataGridViewClientes.Columns["Id"].Visible = false;
                DataGridViewClientes.Columns["Morada"].Visible = false;
                DataGridViewClientes.Columns["Estado"].Visible = false;
                DataGridViewClientes.Columns["NomeENif"].Visible = false;

                // Altera o título da coluna do estado do cliente
                DataGridViewClientes.Columns["EstadoTexto"].HeaderText = "Estado do Cliente";


                DataGridViewClientes.CurrentCell = null;
                DataGridViewClientes.ClearSelection();

                //selecionar a linha toda do datagridview
                DataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        /// <summary>
        /// Valida os campos preenchidos no formulário.
        /// </summary>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || !Regex.IsMatch(txtNomeCliente.Text, @"^[A-Za-zA-ÿ ]+$"))
            {
                MessageBox.Show("É necessário informar um nome de cliente válido!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtMorada.Text))
            {
                MessageBox.Show("É necessário informar a morada!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtContacto.Text) || !Regex.IsMatch(txtContacto.Text, @"^[239]\d{8}$"))
            {
                MessageBox.Show("É necessário informar um contacto válido!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtNif.Text) || !Regex.IsMatch(txtNif.Text, @"^\d{9}$"))
            {
                MessageBox.Show("É necessário informar um contribuinte válido!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("É necessário informar um email válido!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {

            limparCamposCliente();
        }


        /// <summary>
        /// Limpa os campos do formulário.  
        /// </summary>
        private void limparCamposCliente()
        {
            txtNomeCliente.Text = string.Empty;
            txtMorada.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtNif.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            //  Verifica se existe uma linha selecionada no DataGridView
            if (DataGridViewClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na tabela antes de clicar em Editar.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 
            }

            //selecionar o cliente
            Cliente clienteAEditar = (Cliente)DataGridViewClientes.CurrentRow.DataBoundItem;
            Cliente editado = null;

            if (clienteAEditar != null)
            {
                foreach (Cliente cliente in _listaClientes)
                {
                    if (clienteAEditar.Id == cliente.Id)
                    {
                        editado = cliente;
                    }
                }
            }

            //abrir o novo form para editar
            FormEditarCliente formEditarCliente = new FormEditarCliente(this, editado);
            formEditarCliente.Show();
        }

        /// <summary>
        /// Verifica se o cliente possui histórico de consumos ou faturas associado aos seus contadores.
        /// </summary>
        private bool VerificaClienteTemHistorico(Cliente cliente)
        {
            if (cliente.ListaContadores == null || cliente.ListaContadores.Count == 0)
            {
                return false;
            }

            foreach (Contador contador in cliente.ListaContadores)
            {
                if ((contador.ListaConsumos != null && contador.ListaConsumos.Count > 0) || (contador.ListaFaturas != null && contador.ListaFaturas.Count > 0))
                {
                    return true;
                }
            }

            return false;
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            //  Verifica se existe uma linha selecionada no DataGridView
            if (DataGridViewClientes.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um cliente na tabela antes de clicar em Apagar.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 
            }

            //seleciona um item da lista
            Cliente clienteAApagar = (Cliente)DataGridViewClientes.CurrentRow.DataBoundItem;

            Cliente apagado = null;

            if (clienteAApagar != null)
            {

                foreach (Cliente cliente in _listaClientes)
                {
                    if (clienteAApagar.Id == cliente.Id)
                    {
                        apagado = cliente; //atribui o cliente a var apagado
                    }
                }

                if (apagado != null)
                {

                    if (VerificaClienteTemHistorico(apagado))
                    {
                        MessageBox.Show($"Este Cliente não pode ser apagado, porque possui leituras ou faturas!",
                            "Operação cancelada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        return;
                    }

                    DialogResult resposta;

                    bool estadoCliente = apagado.Estado;

                    resposta = MessageBox.Show($"Tem certeza que pretende apagar o {apagado.Nome}? ",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        //apagado.Estado = false;  // nao removo da lista apenas deixo ativo ou inativo
                        _listaClientes.Remove(apagado); // remove da lista
                        InitLista();                   
                    }
                }
            }
        }

        private void DataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
