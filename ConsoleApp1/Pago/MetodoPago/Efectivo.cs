using ConsoleApp1.MetodoPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pago.MetodoPago
{
    public class Efectivo : IMetodoPago
    {
        public bool pagar()
        {
            return true;
        }
    }
}
