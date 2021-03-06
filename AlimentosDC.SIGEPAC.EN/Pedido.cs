﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.EN
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public byte IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Dui { get; set; }
        public int NumeroPedido { get; set; }
        public string NumeroCCF { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public string Estado { get; set; }
        public double Sumas { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        
    }
}
