using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class BasicCar : ICar{
        string text = "basic car";
        public string GetDetails(){
            return text;
        }
    }
}