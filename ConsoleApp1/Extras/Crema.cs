using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extras
{
    public class Crema  : ExtrasDecorador {


        public Crema(Bebida combo) : base(combo) { }

        public override string getDescripcion()
        {
            return _combo.getDescripcion().Trim() + ", con crema";
        }

        public override double getPrecio()
        {
            return _combo.getPrecio() + 5;
        }
    }
    
}
