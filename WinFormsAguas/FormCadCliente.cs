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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsAguas
{
    public partial class FormCadCliente : Form
    {
        List<Cliente> Clientes;  // Add a referencia 1 definir o atributo

        int contaClientes = 1;


        public FormCadCliente()
        {
            Clientes = new List<Cliente>();  // 2 instancio a lista
            InitializeComponent();
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente;

            if (ValidaForm())
            {
                novoCliente = new Cliente
                {
                    Id = contaClientes,
                    Nome = txtNomeCliente.Text,
                    Morada = txtMorada.Text,
                    Contacto = Convert.ToInt32(txtContacto.Text),
                    Nif = Convert.ToInt32(txtNif.Text),
                    Email = txtEmail.Text,
                };

                Clientes.Add(novoCliente);
                contaClientes++;

                InitLista();

            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //limpar as caixas depois que guarda
            txtNomeCliente.Text = string.Empty;
            txtMorada.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtNif.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }

        public void InitLista()
        {

            listBoxClientes.DataSource = null;
            listBoxClientes.DataSource = Clientes;

           
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("É necessário informar o nome do cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtMorada.Text))
            {
                MessageBox.Show("É necessário informar a morada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            //posso usar regex(expressao regular?)
            if (string.IsNullOrWhiteSpace(txtContacto.Text) || !Regex.IsMatch(txtContacto.Text, @"^\d{9}$"))
            {
                MessageBox.Show("É necessário informar um contacto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtNif.Text) || !Regex.IsMatch(txtNif.Text, @"^\d{9}$"))
            {
                MessageBox.Show("É necessário informar o contribuinte válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
            {
                MessageBox.Show("É necessário informar um email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = string.Empty;
            txtMorada.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtNif.Text = string.Empty;
            txtEmail.Text = string.Empty;

            MessageBox.Show("O Cliente será apagado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
