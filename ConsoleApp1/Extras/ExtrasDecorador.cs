using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extras
{

    public   abstract class ExtrasDecorador : ICombo
    {
        public ICombo _combo;

        ExtrasDecorador(ICombo combo) {
            this._combo = combo;
        }

        public string getDescripcion()
        {
            return this._combo.getDescripcion();
        }

        public double getPrecio()
        {
            return this.getPrecio();
        }
    }
}
