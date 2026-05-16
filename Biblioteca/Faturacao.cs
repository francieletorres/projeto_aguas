using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Faturacao
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Contador Contador { get; set; }
        public DateTime Data { get; set; }
        public double ValorFatura { get; set; }
        public bool Cancelada { get; set; }        // Estado

    }
}
