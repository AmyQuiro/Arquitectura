using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Combo
{
    class ComboEspecial : ICombo
    {
        public string getDescripcion()
        {
            return "1 Hamburgueza sencilla, con porcion de papas Fritas, gaseosa personal";
        }

        public double getPrecio()
        {
            return 20;
        }
    }
}
