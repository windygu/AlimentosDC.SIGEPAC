using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlimentosDC.SIGEPAC.EN
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public bool StatusAdmin { get; set; }
        public byte[] Imagen { get; set; }
    }
}
