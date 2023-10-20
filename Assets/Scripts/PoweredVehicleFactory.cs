using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class PoweredVehicleFactory : IVehicleFactory{
        public IUnicycle CreateUnicycle(){
            return new FancyUnicycle();
        }

        public IBike CreateBike(){
            return new FancyBike();
        }

        public ICar CreateCar(){
            return new FancyCar();
        }
    }
}