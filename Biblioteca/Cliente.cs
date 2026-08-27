using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Morada { get; set; }

        public int Contacto { get; set; }

        public int Nif { get; set; }

        public string Email { get; set; }

        public bool Estado { get; set; }
  
        public string EstadoTexto
        {
            get {  return (Estado) ? "Ativo" : "Inativo"; }
        }

        public List<Contador> ListaContadores { get; set; }

        public List<Consumo> ListaConsumos { get; set; }

        public List<Fatura> ListaFaturas { get; set; }

        //uso no form consumo
        public String NomeENif
        {
            get
            {
                return $"{Nome} - NIF - {Nif}";
            }
        }

        public override string ToString()
        {
            return $"{Nome} - {Nif}";
        }

    }
}
