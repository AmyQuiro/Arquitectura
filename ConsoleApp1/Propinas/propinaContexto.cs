using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Propinas
{
   public  class propinaContexto
    {
        private  ICalculadorPropina _iCalculadorPropina;

       public void setEstrategia( ICalculadorPropina iCalculadorPropina)
        {
            if (iCalculadorPropina == null) throw new Exception("La estrategia no puede ser null");
            this._iCalculadorPropina = iCalculadorPropina;
        }

       public decimal calcularPropina(decimal monto)  {
            if (_iCalculadorPropina == null) return 0;

        return _iCalculadorPropina.CalcularPropina(monto);
    }
}
}
