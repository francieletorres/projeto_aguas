using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAguas
{
    public partial class FormVisualizarFatura : Form
    {

        private Fatura _faturaSelecionada;

        public FormVisualizarFatura(Fatura fatura)
        {
            InitializeComponent();
            _faturaSelecionada = fatura;

            atualizarDadosFatura();
        }


        /// <summary>
        /// Atualiza os detalhes da fatura apresentados no ecrã com base na fatura selecionada.
        /// </summary>
        private void atualizarDadosFatura()
        {
            lblIdFatura.Text = _faturaSelecionada.Id.ToString();
            lblNomeCliente.Text = _faturaSelecionada.Cliente.Nome;
            lblMorada.Text = _faturaSelecionada.Cliente.Morada;
            lblContacto.Text = _faturaSelecionada.Cliente.Contacto.ToString();
            lblIdContador.Text = _faturaSelecionada.Contador.Id.ToString();
            lblDataEmissao.Text = _faturaSelecionada.DataEmissao.ToShortDateString();
            lblValorTotal.Text = _faturaSelecionada.ValorFatura.ToString("C2");
            lblEstado.Text = _faturaSelecionada.Anulada ? "Anulada" : (_faturaSelecionada.Pago ? "Paga" : "Em dívida");

            AtualizarEstadoBotoes();
        }

        private void FormVisualizarFatura_Load(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            _faturaSelecionada.Pago = true;

            MessageBox.Show("Pagamento registado com sucesso!", "Sucesso",
             MessageBoxButtons.OK, MessageBoxIcon.Information);

            atualizarDadosFatura();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show($"Tem certeza que deseja Anular a fatura {_faturaSelecionada.Id}?",
                 "Anular",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question);

            if (DialogResult.OK == confirmar)
            {
                _faturaSelecionada.Anulada = true;
                _faturaSelecionada.Pago = false;

                // Informar no consumo que ele não tem mais fatura
                List<Consumo> listaConsumo = _faturaSelecionada.Contador.ListaConsumos;

                foreach(Consumo consumo in listaConsumo)
                {
                    if(_faturaSelecionada.Id == consumo.Id)
                    {
                        consumo.TemFatura = false;
                    }
                }

                MessageBox.Show("Fatura Anulada com sucesso!",
                    "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                atualizarDadosFatura();
            }
        }


        /// <summary>
        /// Atualiza os botões e a etiqueta de estado com base no estado da fatura selecionada.
        /// </summary>
        private void AtualizarEstadoBotoes()
        {
            lblEstado.Text = _faturaSelecionada.Anulada ? "Anulada" : (_faturaSelecionada.Pago ? "Paga" : "Em dívida");

            if (_faturaSelecionada.Anulada)
            {
                btnAnular.Enabled = false;
                btnPagar.Enabled = false;
            }
            else if (_faturaSelecionada.Pago)
            {
                btnAnular.Enabled = false;
                btnPagar.Enabled = false;
            }
            else
            {
                btnAnular.Enabled = true;
                btnPagar.Enabled = true;
            }


        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblFatura_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
