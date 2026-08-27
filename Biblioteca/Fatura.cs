using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Fatura
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Contador Contador { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorFatura { get; set; }
        public bool Anulada { get; set; }
        public bool Pago { get; set; }


        public override string ToString()
        {
            return $"{Id} - {DataEmissao} - {ValorFatura} - {Anulada} - {Pago}";
        }




    }
}
