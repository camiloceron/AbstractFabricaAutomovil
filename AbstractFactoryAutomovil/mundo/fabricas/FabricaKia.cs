using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAutomovil.mundo.interfaces;
using AbstractFactoryAutomovil.mundo.clases;

namespace AbstractFactoryAutomovil.mundo.fabricas
{
    class FabricaKia: IFabricaPartes
    {
        public IAuto crearAuto()
        {
            return new AutoKia();
        }

        public IMotor crearMotor()
        {
            return new MotorKia();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaKia();
        }
    }
}
