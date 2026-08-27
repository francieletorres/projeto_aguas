using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contador
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataInstalacao { get; set; }
        public bool Estado { get; set; }

        public string EstadoTexto
        {
            get { return (Estado) ? "Ativo" : "Inativo"; }
        }

        public override string ToString()
        {
            return $"{Id}";
        }

        public List<Consumo> ListaConsumos { get; set; }

        public List<Fatura> ListaFaturas { get; set; }
    }
}
