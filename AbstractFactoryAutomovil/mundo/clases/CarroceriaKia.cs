using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;

namespace AbstractFactoryAutomovil.mundo.clases
{
    class CarroceriaKia: ICarroceria
    {
        public string darNombre()
        {
            return "carroceria Kia";
        }
    }
}
