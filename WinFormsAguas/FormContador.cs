using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAguas
{
    public partial class FormContador : Form
    {
        private List<Cliente> _listaClientes;

        //guarda o cliente que está selecionado na combobox
        private Cliente _clienteSelecionado;

        int contaContadores = 0;

        public FormContador(List<Cliente> listaCliente)
        {
            InitializeComponent();
            _listaClientes = listaCliente;

            // mostra a lista de clientes
            ComboBoxClientes.DataSource = _listaClientes;
            ComboBoxClientes.DisplayMember = "NomeENif";

            // Para ter a opção vazia no começo da lista
            ComboBoxClientes.SelectedIndex = -1;

        }

        private void ComboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verifica se há um cliente selecionado na combobox
            if (ComboBoxClientes.SelectedIndex != null)
            { 
                _clienteSelecionado = (Cliente)ComboBoxClientes.SelectedItem;

                InitLista();
            }
        }

        private void btnRegistarContador_Click(object sender, EventArgs e)
        {

            if (_clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro");
                return;
            }

            Contador novoContador;

            if (ValidaForm())
            {
                novoContador = new Contador
                {
                    Id = contaContadores,
                    ClienteId = _clienteSelecionado.Nif,
                    DataInstalacao = dateTimePickerContador.Value,
                    Estado = checkBoxEstadoContador.Checked,
                    ListaConsumos = new List<Consumo>(),
                    ListaFaturas = new List<Fatura>(),
                };

                // adicionar contador ao cliente
                _clienteSelecionado.ListaContadores.Add(novoContador);


                //atualiza o grid view
                InitLista();
            }
        }

        /// <summary>
        /// Atualiza o DataGridView para mostrar as informaçoes do cliente selecionado.
        /// </summary>
        public void InitLista()
        {
            //limpa o que estava no grid antes
            dataGridViewContador.DataSource = null;

            contaContadores = 1;

            //mostra os contadores do cliente selecionado, se houver
            if (_clienteSelecionado != null && _clienteSelecionado.ListaContadores != null && _clienteSelecionado.ListaContadores.Count > 0)
            {

                // Verifica qual foi o último id atribuido para seguir a sequencia
                foreach (Contador contador in _clienteSelecionado.ListaContadores)
                {
                    if (contaContadores < contador.Id)
                    {
                        contaContadores = contador.Id;
                    }
                }

                contaContadores++;

                dataGridViewContador.DataSource = _clienteSelecionado.ListaContadores;
                //dataGridViewContador.Columns["Id"].Visible = false;
                dataGridViewContador.Columns["Estado"].Visible = false;
                dataGridViewContador.Columns["EstadoTexto"].HeaderText = "Estado do Contador";
            }

            dataGridViewContador.CurrentCell = null;
            dataGridViewContador.ClearSelection();

            //selecionar a linha toda do datagridview
            dataGridViewContador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Valida se a data selecionada nao é no futuro.
        /// </summary>
        private bool ValidaForm()
        {
            bool output = true;

            if (dateTimePickerContador.Value.Date > DateTime.Today)
            {
                MessageBox.Show("A data de registo não pode ser uma data futura.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void FormContador_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpar os campos
            dateTimePickerContador.Value = DateTime.Now;
            checkBoxEstadoContador.Checked = false;
            ComboBoxClientes.SelectedIndex = -1;
        }

        private void btnEditarContador_Click(object sender, EventArgs e)
        {
            if (dataGridViewContador.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um contador na tabela antes de clicar em Editar.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Contador contadorAEditar = (Contador)dataGridViewContador.CurrentRow.DataBoundItem;
            Contador editado = null;

            if (contadorAEditar != null)
            {
                foreach (Contador contador in _clienteSelecionado.ListaContadores)
                {
                    if (contadorAEditar.Id == contador.Id)
                    {
                        editado = contador;
                    }
                }
            }

            FormEditarContador formEditarContador = new FormEditarContador(this, editado);
            formEditarContador.Show();
        }

        private void dataGridViewContador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Verifica se o contador tem histórico de consumos ou faturas.
        /// </summary>
        private bool VerificaContadorTemHistorico (List<Consumo> listaConsumos, List<Fatura> listaFaturas)
        {
            // se tem leitura ou faturas
            if (listaConsumos.Count > 0 || listaFaturas.Count > 0) // tava assim antes (listaConsumos.Count != null && listaConsumos.Count > 0)
            {
                return true;
            }

            //se nao tem leitura retorna falso
            return false;
        }


        private void btnApagarContador_Click(object sender, EventArgs e)
        {
            //  Verifica se existe uma linha selecionada no DataGridView
            if (dataGridViewContador.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um contador na tabela antes de clicar em Apagar.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 
            }

            Contador contadorAApagar = (Contador)dataGridViewContador.CurrentRow.DataBoundItem; //seleciona um item da lista
            Contador apagado = null;

            if (contadorAApagar != null)
            {
                foreach (Contador contador in _clienteSelecionado.ListaContadores)
                {
                    if (contadorAApagar.Id == contador.Id)
                    {
                        apagado = contador; //atribui o cliente a var apagado
                    }
                }

                if (apagado != null)
                {
                    //conferir se pode ser apagado
                    if (VerificaContadorTemHistorico(apagado.ListaConsumos, apagado.ListaFaturas))
                    {
                        MessageBox.Show($"Este contador não pode ser apagado, porque possui leituras ou faturas!",
                            "Operação cancelada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        return;
                    }


                    DialogResult resposta;

                    bool estadoCliente = apagado.Estado;

                    resposta = MessageBox.Show($"Tem certeza que pretende apagar o contador {apagado.Id}?",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);


                    if (DialogResult.OK == resposta)
                    {
                        //apagado.Estado = false;  // nao removo da lista apenas deixo ativo ou inativo
                        _clienteSelecionado.ListaContadores.Remove(apagado); // remove da lista
                        InitLista();                    //update lista

                        MessageBox.Show("Contador apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
