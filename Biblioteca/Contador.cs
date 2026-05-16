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

        public List<Consumo> Consumos { get; set; } = null!;
         

        





    }
}
