using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cafe
{
    public class CafeSolo : Bebida
    {
        public override string getDescripcion()
        {
            return "Cafe solo";
        }

        public override double getPrecio()
        {
            return 7;
        }
    }
}
