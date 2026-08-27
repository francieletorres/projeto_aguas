using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestaoFicheiros
    {
        /// <summary>
        /// Grava a lista de clientes num ficheiro de texto, substituindo o ficheiro antigo.
        /// </summary>
        /// <param name="clientes">A lista de clientes que será guardada no ficheiro.</param>
        public static void GravarClientes(List<Cliente> clientes)
        {
            string ficheiro = @"cliente.txt";

            StreamWriter sw = new StreamWriter(ficheiro, false); // o false substitui o ficheiro antigo

            foreach (Cliente cliente in clientes)
            {
                string linha = $"{cliente.Id};{cliente.Nome};{cliente.Morada};{cliente.Contacto};{cliente.Nif};{cliente.Email};{cliente.Estado}";

                sw.WriteLine(linha);
            }
            sw.Close();
        }

        /// <summary>
        /// Lê o ficheiro de texto e carrega a lista de clientes.
        /// </summary>
        /// <returns>A lista com todos os clientes encontrados ou uma lista vazia caso o ficheiro não exista.</returns>
        public static List<Cliente> LerClientes()
        {
            string ficheiro = @"cliente.txt";

            List<Cliente> listaCliente = new List<Cliente>();

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');

                    Cliente novoCliente = new Cliente
                    {
                        Id = Convert.ToInt32(campos[0]),
                        Nome = campos[1],
                        Morada = campos[2],
                        Contacto = Convert.ToInt32(campos[3]),
                        Nif = Convert.ToInt32(campos[4]),
                        Email = campos[5],
                        Estado = Convert.ToBoolean(campos[6]),

                        // para evitar o erro null quando estao vazias
                        ListaContadores = new List<Contador>(),
                        ListaConsumos = new List<Consumo>(),
                        ListaFaturas = new List<Fatura>()
                    };

                    listaCliente.Add(novoCliente);
                }
                sr.Close();
            }
            return listaCliente;
        }

        //o contador é guardado dentro da lista de cada cliente por isso chamo a lista de cliente aqui


        /// <summary>
        /// Guarda os contadores de todos os clientes.
        /// </summary>
        /// <param name="clientes">A lista de clientes que contém os contadores a gravar.</param>
        public static void GravarContadores(List<Cliente> clientes)
        {
            string ficheiro = @"contador.txt";

            StreamWriter sw = new StreamWriter(ficheiro, false);

            foreach (Cliente cliente in clientes)
            {
                foreach (Contador contador in cliente.ListaContadores)
                {
                    string linha = $"{contador.ClienteId};{contador.Id};{contador.DataInstalacao};{contador.Estado}";

                    sw.WriteLine(linha);
                }
            }
            sw.Close();
        }

        /// <summary>
        /// Lê o ficheiro e associa cada contador ao seu cliente correspondente.
        /// </summary>
        /// <param name="listaClientes">A lista de clientes onde os contadores serão inseridos de acordo com o Nif do cliente.</param>
        public static void LerContadores(List<Cliente> listaClientes)
        {
            string ficheiro = @"contador.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');

                    Contador novoContador = new Contador
                    {
                        Id = Convert.ToInt32(campos[1]),
                        ClienteId = Convert.ToInt32(campos[0]),
                        DataInstalacao = Convert.ToDateTime(campos[2]),
                        Estado = Convert.ToBoolean(campos[3]),
                        // Inicializ a lista de consumos dele para não dar null depois
                        ListaConsumos = new List<Consumo>(),
                        ListaFaturas = new List<Fatura>(),
                    };

                    foreach (Cliente cliente in listaClientes)
                    {
                        if (cliente.Nif == novoContador.ClienteId)
                        { 
                            cliente.ListaContadores.Add(novoContador);
                            break; 
                        }
                    }
                }
                sr.Close();
            }
        }

        /// <summary>
        /// Guarda os consumos de todos os contadores no ficheiro.
        /// </summary>
        /// <param name="Clientes">A lista de clientes que contém os consumos a guardar.</param>
        public static void GravarConsumos(List<Cliente> Clientes)
        {
            string ficheiro = @"consumo.txt";

            StreamWriter sw = new StreamWriter(ficheiro, false);

            foreach (Cliente cliente in Clientes)
            {
                foreach (Contador contador in cliente.ListaContadores)
                {
                    foreach (Consumo consumo in contador.ListaConsumos)
                    {
                        string linha = $"{cliente.Nif};{contador.Id};{consumo.Id};{consumo.DataLeitura};{consumo.LeituraContador};{consumo.VolumeConsumido};{consumo.Observacao};{consumo.TemFatura}";

                        sw.WriteLine(linha);

                    }
                }
            }
            sw.Close();
        }

        /// <summary>
        /// Lê o ficheiro consumo e adiciona os consumos aos respetivos contadores de cada cliente.
        /// </summary>
        /// <param name="listaClientes">A lista de clientes onde os consumos serão guardados com base no NIF e no ID do contador</param>
        public static void LerConsumos(List<Cliente> listaClientes)
        {
            string ficheiro = @"consumo.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');

                    Consumo novoConsumo = new Consumo
                    {
                        Id = Convert.ToInt32(campos[2]),
                        DataLeitura = Convert.ToDateTime(campos[3]),
                        LeituraContador = Convert.ToInt32(campos[4]),
                        VolumeConsumido = Convert.ToInt32(campos[5]),
                        Observacao = campos[6],
                        TemFatura = Convert.ToBoolean(campos[7])
                    };

                    foreach (Cliente cliente in listaClientes)
                    {
                        // Encontra o Cliente correto
                        if (cliente.Nif == Convert.ToInt32(campos[0]))
                        {
                            foreach (Contador contador in cliente.ListaContadores)
                            {
                                if (contador.Id == Convert.ToInt32(campos[1]))
                                {
                                    contador.ListaConsumos.Add(novoConsumo);
                                    break;
                                }
                            }
                        }
                    }
                }
                sr.Close();
            }
        }


        /// <summary>
        /// Guarda os dados das faturas de todos os clientes.
        /// </summary>
        /// <param name="Clientes">A lista de clientes que contém as faturas a guardar.</param>
        public static void GravarFaturas(List<Cliente> Clientes)
        {
            string ficheiro = @"fatura.txt";

            StreamWriter sw = new StreamWriter(ficheiro, false);

            foreach (Cliente cliente in Clientes)
            {
                foreach (Contador contador in cliente.ListaContadores)
                {
                    foreach (Fatura fatura in contador.ListaFaturas)
                    {
                        string linha = $"{cliente.Nif};{contador.Id};{fatura.Id};{fatura.DataEmissao};{fatura.ValorFatura};{fatura.Anulada};{fatura.Pago}";

                        sw.WriteLine(linha);
                    }
                }
            }
            sw.Close();
        }


        /// <summary>
        /// Lê a fatura e associa cada faura ao respetivo contador e cliente
        /// </summary>
        /// <param name="listaClientes">A lista de clientes onde as faturas carregadas serão guardadas.</param>
        public static void LerFaturas(List<Cliente> listaClientes)
        {
            string ficheiro = @"fatura.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = linha.Split(';');

                    Fatura novaFatura = new Fatura
                    {
                        Id = Convert.ToInt32(campos[2]),
                        DataEmissao = Convert.ToDateTime(campos[3]),
                        ValorFatura = Convert.ToDouble(campos[4]),
                        Anulada = Convert.ToBoolean(campos[5]),
                        Pago = Convert.ToBoolean(campos[6]),
                    };

                    foreach (Cliente cliente in listaClientes)
                    {
                        // Encontra o Cliente correto
                        if (cliente.Nif == Convert.ToInt32(campos[0]))
                        {
                            foreach (Contador contador in cliente.ListaContadores)
                            {
                                if (contador.Id == Convert.ToInt32(campos[1]))
                                {
                                    novaFatura.Cliente = cliente;
                                    novaFatura.Contador = contador;

                                    contador.ListaFaturas.Add(novaFatura);
                                    break;
                                }
                            }
                        }
                    }
                }
                sr.Close();
            }
        }
    }
}
