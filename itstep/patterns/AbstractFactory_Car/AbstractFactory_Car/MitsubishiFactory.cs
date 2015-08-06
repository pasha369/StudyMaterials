﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Car
{
    class MitsubishiFactory : IMitsubishiFactory
    {
        public IFamilyCar _familyCar;
        public ISportCar _sportCar;

        public MitsubishiFactory()
        {
            _familyCar = new FamilyCar()
                             {
                                 Color = "--",
                                 Motor = "--",
                                 Shield = "--"
                             };
            _sportCar = new SportCar()
            {
                Color = "--",
                Motor = "--",
                Shield = "--"
            };
        }

        public IFamilyCar getFamilyCar()
        {
            return _familyCar;
        }

        public ISportCar getSportCar()
        {
            return _sportCar;
        }

    }
}
