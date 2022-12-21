using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Propinas.tipoPropina
{
    public class Grupo : ICalculadorPropina
    {
        public double CalcularPropina(double valor)
        {
            double porcentaje = 10 / 100;
            return valor * porcentaje;
        }

      
    }
}
