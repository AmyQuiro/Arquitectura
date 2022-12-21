using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cafe
{
    public class CafeExpreso : Bebida
    {
        public override string getDescripcion()
        {
            return "Cafe expreso";
        }

        public override double getPrecio()
        {
            return 10;
        }
    }
}
