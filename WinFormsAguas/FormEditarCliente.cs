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
    public partial class FormEditarCliente : Form
    {
        //recebe o cliente editado
        Cliente _editado;

        FormCadCliente _formCliente;

        public FormEditarCliente(FormCadCliente form, Cliente editado)
        {
            InitializeComponent();
            _editado = editado; // da lista do outro form
            _formCliente = form;


            //leva as informacoes para editar 
            txtNomeCliente.Text = editado.Nome;
            txtMorada.Text = editado.Morada;
            txtContacto.Text = editado.Contacto.ToString();
            txtNif.Text = editado.Nif.ToString();
            txtEmail.Text = editado.Email;
            checkBoxEstadoCliente.Checked = editado.Estado;

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
                MessageBox.Show("É necessário informar o contribuinte válido!",
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

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = txtNomeCliente.Text;
                _editado.Morada = txtMorada.Text;
                _editado.Contacto = Convert.ToInt32(txtContacto.Text);
                _editado.Nif = Convert.ToInt32(txtNif.Text);
                _editado.Email = txtEmail.Text;
                _editado.Estado = checkBoxEstadoCliente.Checked;

                _formCliente.InitLista();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
