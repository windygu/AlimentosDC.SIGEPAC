using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.EN
{
    public class Ingreso
    {
        public int Id { get; set; }
        public byte IdUsuario { get; set; }
        public string Usuario { get; set; }
        public int IdMarca { get; set; }
        public string Marca { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string NumeroCCF { get; set; }
        public double Sumas { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
    }
}
