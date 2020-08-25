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
        public byte Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public bool StatusAdmin { get; set; }
        public byte[] Imagen { get; set; } 
    }
}
