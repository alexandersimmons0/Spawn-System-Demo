using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryDemo{
    public class BasicUnicycle : IUnicycle{
        string text = "basic unicycle";
        public string GetDetails(){
            return text;
        }      
    }
}