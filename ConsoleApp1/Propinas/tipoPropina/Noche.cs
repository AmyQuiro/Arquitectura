using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Propinas.tipoPropina
{
   public  class Noche : ICalculadorPropina
    {
        public decimal CalcularPropina(decimal valor)
        {
            decimal porcentaje = (decimal)0.1;
            return valor * porcentaje;
        }

     
    }
}
