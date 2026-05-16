using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Consumo
    {
        public int Id { get; set; } 

        public DateTime DataLeitura { get; set; }

        public int LeituraContador { get; set; }

        public double VolumeConsumido { get; set; }

        public string Observacao { get; set; }




    }
}
