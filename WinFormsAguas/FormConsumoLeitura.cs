using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAguas
{
    public partial class FormConsumoLeitura : Form
    {
        //variaveis para guardar o que vem do outro ecrã
        private Cliente _clienteSelecionado;
        private Contador _contadorSelecionado;

        private FormConsumo _formConsumo;

        int contaConsumos;
        int maiorLeitura = 0;

        public FormConsumoLeitura(FormConsumo formConsumo, Cliente clienteSelecionado, Contador contadorSelecionado)
        {
            InitializeComponent();

            //guarda o  cliente e o contador que chegou nas variáveis criadas
            _clienteSelecionado = clienteSelecionado;
            _contadorSelecionado = contadorSelecionado;

            _formConsumo = formConsumo;

            //mostra as informações na lbl
            lblClienteContador.Text = $"Cliente: {_clienteSelecionado.Nome} | Contador: {_contadorSelecionado.Id}";

        }

        private void FormConsumoLeitura_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Valida a leitura introduzida no formulário.
        /// </summary>
        private bool ValidaLeituraForm()
        {
            bool output = true;

            if (String.IsNullOrWhiteSpace(txtLeitura.Text))
            {
                MessageBox.Show("É necessário informar a leitura!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                output = false;
            }

            if (!int.TryParse(txtLeitura.Text, out int leituraConvertida))
            {
                MessageBox.Show("É necessário informar números inteiros válidos!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                output = false;
            }

            if (int.TryParse(txtLeitura.Text, out int verificarLeituraMaior))
            {
                if (verificarLeituraMaior < maiorLeitura)
                {
                    MessageBox.Show("A leitura não pode ser inferior a anterior!",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    output = false;
                }
            }

            foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
            {
                if (dateTimePickerLeitura.Value.Date == consumo.DataLeitura.Date)
                {
                    MessageBox.Show("Já existe uma leitura registada com esta data!",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                    output = false;
                }

            }

            //usadas para pegar o mes e ano para usar no bloco para testar
            int mes = dateTimePickerLeitura.Value.Month;
            int ano = dateTimePickerLeitura.Value.Year;

            bool existeLeituraMensal = false;

            foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
            {
                //verifica se já foi feito a leitura automatica
                if (consumo.DataLeitura.Month == mes && consumo.DataLeitura.Year == ano) 
                {
                    existeLeituraMensal = true;
                }
            }

            //mensagem de aviso
            if (existeLeituraMensal == true)
            {
                MessageBox.Show("Já existe uma leitura registada para este mês!",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }


        /// <summary>
        /// Calcula o volume consumido com base na leitura atual e na maior leitura anterior do contador.
        /// </summary>
        private double CalcularVolume()
        {
            int resultadoVolume = 0;

            // busca a maior leitura anterior para fazer o cálculo do consumo
            foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
            {
                if (maiorLeitura < consumo.LeituraContador)
                {
                    maiorLeitura = consumo.LeituraContador;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtLeitura.Text) && int.TryParse(txtLeitura.Text, out int leituraDigitada))
            {
                resultadoVolume = leituraDigitada - maiorLeitura;

                if (resultadoVolume < 0)
                {
                    resultadoVolume = 0;
                }
            }

            return resultadoVolume;

        }

        private void btnRegistarLeitura_Click(object sender, EventArgs e)
        {

            Consumo novoConsumo;

            if (ValidaLeituraForm())
            {
                contaConsumos = 0;

                // Busca o maior id do consumo
                foreach (Consumo consumo in _contadorSelecionado.ListaConsumos)
                {
                    if (contaConsumos < consumo.Id)
                    {
                        contaConsumos = consumo.Id;
                    }
                }

                contaConsumos++;

                novoConsumo = new Consumo()
                {
                    Id = contaConsumos,
                    LeituraContador = Convert.ToInt32(txtLeitura.Text),
                    DataLeitura = dateTimePickerLeitura.Value,
                    Observacao = txtObs.Text,
                    VolumeConsumido = CalcularVolume()
                };

                _contadorSelecionado.ListaConsumos.Add(novoConsumo);

                _formConsumo.InitLista();
                this.Close();
            }
        }

        private void txtLeitura_TextChanged(object sender, EventArgs e)
        {
            string volume = Convert.ToString(CalcularVolume());

            lblVolumeConsumido.Text = volume;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerLeitura_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
