using ConsoleApp1.Propinas.tipoPropina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Propinas
{
  public class Propina
    {
        private  propinaContexto ipropina;

        double calcularPropina(double monto, int  tipoPropinas)
        {
            switch (tipoPropinas)
            {
                case (int) TipoPropina.Grupo:
                    ipropina.setEstrategia(new Grupo());
                    break;
                case (int)TipoPropina.Individual:
                    ipropina.setEstrategia(new Individual());
                    break;
                case (int)TipoPropina.SinPropina:
                    ipropina.setEstrategia(new SinPropina());
                    break;

            }
            return ipropina.calcularPropina(monto);
        }

    }
}
