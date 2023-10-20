using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class VehicleRequirements{
        int seatNumbers;
        int wheelCount;
        bool hasEngine;

        public VehicleRequirements(int seats, int wheels, bool engine){
            seatNumbers = seats;
            wheelCount = wheels;
            hasEngine = engine;
        }
    }
}