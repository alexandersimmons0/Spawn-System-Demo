using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public interface IVehicleFactory{
        IUnicycle CreateUnicycle();
        IBike CreateBike();
        ICar CreateCar();
    }
}