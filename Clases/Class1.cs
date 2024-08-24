using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Operaciones
    {
        public string obtenerResultado(string operacion)
        {
            try
            {
                DataTable tabla = new DataTable();
                string resultado = tabla.Compute(operacion, "").ToString();
                if (resultado == "∞") return "Syntax error";
                return resultado.Replace(',','.');
            }
            catch (Exception ex)
            {
                if (ex is System.OverflowException) return "Overflow";

                else return "Syntax error";
            }
        }

    }
}
