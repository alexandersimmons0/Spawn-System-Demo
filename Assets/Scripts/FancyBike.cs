using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class FancyBike : IBike{
        string text = "fancy bike";
        public string GetDetails(){
            return text;
        }
    }
}