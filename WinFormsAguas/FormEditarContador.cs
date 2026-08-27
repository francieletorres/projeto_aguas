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
    public partial class FormEditarContador : Form
    {
        Contador _editado;

        FormContador _formContador;

        public FormEditarContador(FormContador formContador, Contador editado)
        {
            InitializeComponent();

            //guardando as variaveis globais 
            _formContador = formContador;
            _editado = editado;

            //Leva as informacoes atuais do contador para este form
            dateTimePickerEditarContador.Value = editado.DataInstalacao;
            checkBoxEstadoContador.Checked = editado.Estado;
        }

        private void btnGuardarContador_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.DataInstalacao = dateTimePickerEditarContador.Value;
                _editado.Estado = checkBoxEstadoContador.Checked;

                _formContador.InitLista();
                this.Close();
            }
        }

        /// <summary>
        /// Valida se a data selecionada nao é no futuro.
        /// </summary>
        private bool ValidaForm()
        {
            bool output = true;

            if (dateTimePickerEditarContador.Value.Date > DateTime.Today)
            {
                MessageBox.Show("A data de registo não pode ser uma data futura.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
