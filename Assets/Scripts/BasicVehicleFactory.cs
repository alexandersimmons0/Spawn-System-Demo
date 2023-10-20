using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class BasicVehicleFactory : IVehicleFactory{
        public IUnicycle CreateUnicycle(){
            return new BasicUnicycle();
        }
        public IBike CreateBike(){
            return new BasicBike();
        }

        public ICar CreateCar(){
            return new BasicCar();
        }
    }
}