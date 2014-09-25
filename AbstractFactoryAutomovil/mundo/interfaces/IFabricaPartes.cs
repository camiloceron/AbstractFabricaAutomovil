using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAutomovil.mundo.interfaces
{
    interface IFabricaPartes
    {
        IAuto crearAuto();
        IMotor crearMotor();        
        ICarroceria crearCarroceria();
    }
} 
