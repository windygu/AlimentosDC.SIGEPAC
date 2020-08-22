using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlimentosDC.SIGEPAC.UI
{
    public class Validaciones
    {
        public static byte ValidarPrecio(string textoDelPrecio)
        {
            string patronTresDecimales = @"\d+[.]\d{3}";
            Regex objetoValidador = new Regex(patronTresDecimales);
            byte valorDeRetorno;
            float c;
            if (float.TryParse(textoDelPrecio.Trim(), out c) && (objetoValidador.IsMatch(textoDelPrecio.Trim())))
            {
                valorDeRetorno = 1;
            }
            else if (float.TryParse(textoDelPrecio.Trim(), out c) == false)
            {
                valorDeRetorno = 2;
            }
            else
            {
                if (textoDelPrecio.Trim().Substring(textoDelPrecio.Trim().Length - 1, 1) == ".")
                {
                    valorDeRetorno = 2;
                }
                else valorDeRetorno = 0;
            }
            return valorDeRetorno;
        }

        public static int ValidarDui(string pTextoDui)
        {
            string patronDuiValido = @"\d{8}[-]\d";
            Regex objetoValidador = new Regex(patronDuiValido);
            return objetoValidador.IsMatch(pTextoDui) ? 1 : 0;
        }

        public static int ValidarCorreo(string pTextoCorreo)
        {
            string patronCorreoValido = @"^\w+([.]\w+)*[@]\w+([.]\w+)*[.]\w+$";
            Regex objetoValidador = new Regex(patronCorreoValido);
            return objetoValidador.IsMatch(pTextoCorreo) ? 1 : 0;
        }
    }
}
