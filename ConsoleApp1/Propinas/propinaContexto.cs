using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Propinas
{
   public  class propinaContexto
    {
        private  ICalculadorPropina iCalculadorPropina;

       public void setEstrategia( ICalculadorPropina iCalculadorPropina)
        {
            this.iCalculadorPropina = iCalculadorPropina;
        }

       public  double calcularPropina(double monto)  {
        return iCalculadorPropina.CalcularPropina(monto);
    }
}
}
