using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAguas
{
    public partial class FormConsumo : Form
    {

        private List<Cliente> _listaClientes;

        private Cliente _clienteSelecionado;
        private Contador _contadorSelecionado;
        private Consumo _consumoSelecionado;

        public FormConsumo(List<Cliente> listaClientes)
        {
            InitializeComponent();
            _listaClientes = listaClientes;

            // mostra a lista de clientes
            ComboBoxClientes.DataSource = _listaClientes;
            ComboBoxClientes.DisplayMember = "NomeENif";


            // Para ter a opção vazia no começo da lista
            ComboBoxClientes.SelectedIndex = -1;

            //o programa faz esse método antes de qualquer coisa, e caso ja tenha leitura ele mostra
            VerificarLeiturasEstimadas();

            // Limpa a listagem
            InitLista();
        }

        private void ComboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            _contadorSelecionado = null;

            if (ComboBoxClientes.SelectedIndex != -1 && ComboBoxClientes.SelectedItem != null)
            {
                _clienteSelecionado = (Cliente)ComboBoxClientes.SelectedItem;

                // desliga o evento do ComboBox para ele não disparar sozinho
                ComboBoxContadores.SelectedIndexChanged -= ComboBoxContadores_SelectedIndexChanged;

                ComboBoxContadores.DataSource = null;
                ComboBoxContadores.DataSource = _clienteSelecionado.ListaContadores;
                ComboBoxContadores.DisplayMember = "Id";
                ComboBoxContadores.SelectedIndex = -1;


                // Liga o evento do ComboBox
                ComboBoxContadores.SelectedIndexChanged += ComboBoxContadores_SelectedIndexChanged;

            }

            // Limpa a listagem
            InitLista();

        }

        private void ComboBoxContadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxContadores.SelectedIndex != -1 && ComboBoxContadores.SelectedItem != null)
            {
                _contadorSelecionado = (Contador)ComboBoxContadores.SelectedItem;

                InitLista();
            }
        }

        /// <summary>
        /// Preenche a tabela com os registos de consumo do contador selecionado.
        /// </summary>
        public void InitLista()
        {
            //limpar o grid view antes
            DataGridViewListaConsumos.DataSource = null;

            // Validar se a lista é válida para não dar erro no DataGridViewListaConsumos ao clicar
            if (_contadorSelecionado != null && _contadorSelecionado.ListaConsumos != null && _contadorSelecionado.ListaConsumos.Count > 0)
            {
                //mostra os consumos
                DataGridViewListaConsumos.DataSource = _contadorSelecionado.ListaConsumos;

                // oculta algumas propriedades da lista
                DataGridViewListaConsumos.Columns["Observacao"].Visible = false;

                // Altera o título da coluna do estado do cliente
                DataGridViewListaConsumos.Columns["DataLeitura"].HeaderText = "Data Leitura";
                DataGridViewListaConsumos.Columns["LeituraContador"].HeaderText = "Leitura";
                DataGridViewListaConsumos.Columns["VolumeConsumido"].HeaderText = "Consumido";
            }

            DataGridViewListaConsumos.CurrentCell = null;
            DataGridViewListaConsumos.ClearSelection();

            //selecionar a linha toda do datagridview
            DataGridViewListaConsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        /// <summary>
        /// Verifica se o cliente está ativo para registar consumos.
        /// </summary>
        private bool ValidarEstadoCliente()
        {
            if (_clienteSelecionado == null || _clienteSelecionado.Estado == false)
            {
                MessageBox.Show("Cliente Inativo não pode registar Consumo!",
                    "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Verifica se o contador está selecionado e ativo para registar consumos.
        /// </summary>
        private bool ValidarEstadoContador()
        {
            //Contador selecionado
            Contador _contadorSelecionado = (Contador)ComboBoxContadores.SelectedItem;

            //testa se nada foi selecionado
            if (_contadorSelecionado == null)
            {
                MessageBox.Show("É necessário selecionar um contador! ",
                    "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }

            //testa o estado dele
            if (_contadorSelecionado.Estado == false)
            {
                MessageBox.Show("Contador Inativo não pode registar Consumo!",
                    "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ComboBoxClientes.SelectedIndex = -1;
            ComboBoxContadores.SelectedIndex = -1;
        }

        private void btnRegistarLeitura_Click(object sender, EventArgs e)
        {
            //se for falso o cliente nao pode registar a leitura e nao entra no form inserir leitura
            if (ValidarEstadoCliente() == false || ValidarEstadoContador() == false)
            {
                return;
            }
            else
            {
                _clienteSelecionado = (Cliente)ComboBoxClientes.SelectedItem;
                _contadorSelecionado = (Contador)ComboBoxContadores.SelectedItem;

                FormConsumoLeitura formConsumoLeitura = new FormConsumoLeitura(this, _clienteSelecionado, _contadorSelecionado);
                formConsumoLeitura.Show();
            }
        }

        /// <summary>
        ///Verifica e gera leituras estimadas para clientes ativos após um determinado dia do mês. 
        ///A estimativa é calculada com base na média dos  consumos anteriores.
        /// </summary>
        private void VerificarLeiturasEstimadas()
        {
            //a partir deste dia a leitura é automatica
            int dataLimite = 25;

            //aqui compara qual é o dia
            if (DateTime.Now.Day < dataLimite)
            {
                return; //se ainda nao for dia 25 ele já sai do método
            }

            //usadas para pegar o mes e ano para usar no bloco para testar
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            //percorre a lista de clientes e contadores e consumos
            foreach (Cliente cliente in _listaClientes)
            {
                if(cliente.Estado == false)
                {
                    continue;
                }
                foreach (Contador contador in cliente.ListaContadores)
                {
                    if(contador.Estado == false)
                    {
                        continue;
                    }
                    bool jaTemLeitura = false;

                    foreach (Consumo consumo in contador.ListaConsumos)
                    {
                        //vendo se o mes e ano da leitura é igual ao mes atual, e se tiver, quer dizer que já tem leitura
                        if (consumo.DataLeitura.Month == mes && consumo.DataLeitura.Year == ano)
                        {
                            jaTemLeitura = true;
                        }
                    }

                    //caso nao tenha leitura ele entra aqui e faz automatico
                    if (jaTemLeitura == false)
                    {

                        Consumo novoConsumo;

                        //media do consumo para fazer a estimativa para o volume consumido
                        double mediaConsumo = 0;
                        //pega a maior leitura anterior 
                        int maiorLeitura = 0;
                        

                        int contaConsumos = 0;


                        // Busca o maior id do consumo
                        foreach (Consumo consumo in contador.ListaConsumos)
                        {
                            if (contaConsumos < consumo.Id)
                            {
                                contaConsumos = consumo.Id;
                            }
                            mediaConsumo += consumo.VolumeConsumido;


                            if (maiorLeitura < consumo.LeituraContador)
                            {
                                maiorLeitura = consumo.LeituraContador;
                            }  

                        }

                        contaConsumos++;

                        if (contador.ListaConsumos.Count != 0)
                        {
                            mediaConsumo = mediaConsumo / contador.ListaConsumos.Count;
                        }
                        else
                        {
                            mediaConsumo = 5;
                        }

                        novoConsumo = new Consumo()
                        {
                            Id = contaConsumos,
                            LeituraContador = Convert.ToInt32(maiorLeitura + mediaConsumo),
                            DataLeitura = DateTime.Now,
                            VolumeConsumido = mediaConsumo,
                            TemFatura = false,
                        };

                        contador.ListaConsumos.Add(novoConsumo);
                    }

                }
            }
        }

        private void btnEditarConsumo_Click(object sender, EventArgs e)
        {
            //  Verifica se existe uma linha selecionada no DataGridView
            if (DataGridViewListaConsumos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um consumo na tabela antes de clicar em Editar!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Consumo consumoAEditar = (Consumo)DataGridViewListaConsumos.CurrentRow.DataBoundItem;
            Consumo editado = null;

            if (consumoAEditar != null)
            {
                foreach(Consumo consumo in _contadorSelecionado.ListaConsumos)
                {
                    if(consumoAEditar.Id == consumo.Id)
                    {
                        editado = consumo;
                    }
                }
            }

            // bloqueia se ja tiver fatura
            if(editado.TemFatura)
            {
                MessageBox.Show("Não é possivel editar consumo que já possui faturas!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 
            }

            //bloqueia se for um consumo antigo 

            int ultimoIdDaLista = 0;

            //pegamos o ultimo id guardado no contador
            foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
            {
                if (consumo.Id > ultimoIdDaLista)
                {
                   ultimoIdDaLista = consumo.Id;
                }
            }
            //se o id de consumo for menor que o maior id, neste caso o anterior
            if(editado.Id < ultimoIdDaLista)
            {
                MessageBox.Show("Apenas é permitido editar a última leitura realizada! Leituras anteriores não podem ser modificadas",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 

            }


            FormEditarConsumo formEditarConsumo = new FormEditarConsumo(this, editado);
            formEditarConsumo.Show();
        }

        private void btnApagarConsumo_Click(object sender, EventArgs e)
        {
            //  Verifica se existe uma linha selecionada no DataGridView
            if (DataGridViewListaConsumos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um consumo na tabela antes de clicar em Apagar!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return; // Para a execução aqui 
            }

            Consumo consumoAApagar = (Consumo)DataGridViewListaConsumos.CurrentRow.DataBoundItem;
            Consumo apagado = null;

            if (consumoAApagar != null)
            {
                foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
                {
                    if (consumoAApagar.Id == consumo.Id)
                    {
                        apagado = consumo;

                    }
                }
            }

            if (apagado != null)
            {
                if (VerificaSeConsumoTemFatura(_contadorSelecionado.ListaFaturas, apagado.Id))
                {
                    MessageBox.Show($"Este consumo não pode ser apagado, porque possui fatura!",
                       "Erro",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Stop);
                    return;
                }
            }

            DialogResult resposta;

            resposta = MessageBox.Show($"Tem certeza que deseja apagar o consumo do Id {apagado.Id}?",
                "Apagar",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if(DialogResult.OK == resposta)
            {
                _contadorSelecionado.ListaConsumos.Remove(apagado);

                InitLista();
                MessageBox.Show("Consumo apagado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        /// <summary>
        /// Verifica se o Id de um consumo está associado a alguma fatura.
        /// </summary>
        private bool VerificaSeConsumoTemFatura(List<Fatura> listaFaturas, int idConsumoAApagar)
        {
            bool jaTemFatura = false;

            foreach(Fatura fatura in listaFaturas)
            {
                if(idConsumoAApagar == fatura.Id)
                {
                    jaTemFatura = true;
                }
            }

            return jaTemFatura;
        }

        /// <summary>
        /// Calcula o valor da fatura baseado em escalões de consumo.
        /// </summary>
        /// <returns>O total calculado.</returns>
        public double CalcularFatura(double volumeConsumido)
        {
            double valorFinal = 0;
            double volumeRestante = volumeConsumido;

            // 1 escalao ate 5m cubicos (0,30)
            if (volumeRestante > 5)
            {
                valorFinal += 5 * 0.30;
                volumeRestante -= 5;
            }
            else
            {
                valorFinal += volumeRestante * 0.30;
                volumeRestante = 0;
            }

            //2 escalao superior a 5 até 15 (0.80)
            if (volumeRestante > 10)
            {
                valorFinal += 10 * 0.80;
                volumeRestante -= 10;
            }
            else
            {
                valorFinal += volumeRestante * 0.80;
                volumeRestante = 0;
            }

            //3 escalao superior a 15 até 25 (1.20)
            if (volumeRestante > 10)
            {
                valorFinal += 10 * 1.20;
                volumeRestante -= 10;
            }
            else
            {
                valorFinal += volumeRestante * 1.20;
                volumeRestante = 0;
            }

            //4 escalao superior a 25 (1.60)
            if (volumeRestante > 0)
            {
                valorFinal += volumeRestante * 1.60;
            }

            return Math.Round(valorFinal, 2);
        }

        private void btnGerarFatura_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaConsumos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecione um consumo na tabela para gerar a fatura!!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // pega o consumo da datagrid
            _consumoSelecionado = (Consumo)DataGridViewListaConsumos.CurrentRow.DataBoundItem;

            // aqui verifica se ja foi faturado
            if (_consumoSelecionado.TemFatura == true)
            {
                MessageBox.Show("Este Consumo já possui uma fatura gerada!",
                   "Erro",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            Fatura novaFatura = new Fatura
            {
                Id = _consumoSelecionado.Id,
                Cliente = _clienteSelecionado,
                Contador = _contadorSelecionado,
                DataEmissao = DateTime.Now,
                Anulada = false,
                Pago = false,

                ValorFatura = CalcularFatura(_consumoSelecionado.VolumeConsumido)
            };

            _contadorSelecionado.ListaFaturas.Add(novaFatura);

            //Quando a fatura é gerada isso passa a ser true
            _consumoSelecionado.TemFatura = true;

            InitLista();

            FormVisualizarFatura formVisualizarFatura = new FormVisualizarFatura(novaFatura);
            formVisualizarFatura.Show();
        }

        private void FormConsumo_Load(object sender, EventArgs e)
        {
            InitLista();

        }
    }
}
