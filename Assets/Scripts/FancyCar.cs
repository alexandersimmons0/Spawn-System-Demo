using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class FancyCar : ICar{
        string text = "fancy car";
        public string GetDetails(){
            return text;
        }
    }
}
