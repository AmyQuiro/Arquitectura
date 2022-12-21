using ConsoleApp1.MetodoPago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pago.MetodoPago
{
    public class QR : IMetodoPago
    {
        public bool pagar()
        {
            // se debe de consumir el canal de pago 
            throw new Exception("");
        }
    }
}
