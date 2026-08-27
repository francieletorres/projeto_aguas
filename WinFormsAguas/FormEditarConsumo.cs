using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAguas
{
    public partial class FormEditarConsumo : Form
    {
        Consumo _editado;
        int maiorLeitura = 0;

        FormConsumo _formConsumo;

        public FormEditarConsumo(FormConsumo formConsumo, Consumo editado)
        {
            InitializeComponent();
            _formConsumo = formConsumo;
            maiorLeitura = Convert.ToInt32(editado.LeituraContador - editado.VolumeConsumido);
            _editado = editado; // vem do outro form

            txtLeitura.Text = editado.LeituraContador.ToString();
            dateTimePickerLeitura.Value = editado.DataLeitura;
            lblVolumeConsumido.Text = editado.VolumeConsumido.ToString();
            txtObs.Text = editado.Observacao;
        }

        /// <summary>
        /// Valida a leitura introduzida no formulário,garantindo que o valor existe, é um número inteiro válido e não é inferior à leitura anterior.
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

            return output;
        }
        private void FormEditarConsumo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistarLeitura_Click(object sender, EventArgs e)
        {
            if (ValidaLeituraForm())
            {
                _editado.LeituraContador = Convert.ToInt32(txtLeitura.Text);
                _editado.DataLeitura = dateTimePickerLeitura.Value;
                _editado.VolumeConsumido = _editado.LeituraContador - maiorLeitura;
                _editado.Observacao = txtObs.Text;

                _formConsumo.InitLista();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblVolumeConsumido_Click(object sender, EventArgs e)
        {

        }

        private void txtLeitura_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLeitura.Text) && int.TryParse(txtLeitura.Text, out int leituraDigitada))
            {
                lblVolumeConsumido.Text = Convert.ToString(leituraDigitada - maiorLeitura);
            }
        }
    }
}
