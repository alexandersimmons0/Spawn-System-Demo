using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class FancyUnicycle : IUnicycle{
        string text = "fancy unicycle";
        public string GetDetails(){
            return text;
        } 
    }
}