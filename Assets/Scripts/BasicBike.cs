using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class BasicBike : IBike{
        string text = "basic bike";
        public string GetDetails(){
            return text;
        }
    }
}

