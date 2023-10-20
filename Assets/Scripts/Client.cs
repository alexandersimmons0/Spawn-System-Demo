using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FactoryDemo{
    public class Client : MonoBehaviour{
        private int wheels = 0;
        private int seats = 0;
        private bool engine = true;
        public TMP_Text createdText;
        IVehicleFactory basicVehicleFactory = new BasicVehicleFactory();
        IVehicleFactory poweredVehicleFactory = new PoweredVehicleFactory();

        public void OnWheelCounterValueChanged(TMP_Dropdown wheelCounter){
            wheels = wheelCounter.value;
        }

        public void OnSeatValueChanged(TMP_Dropdown seatCounter){
            seats = seatCounter.value;
        }

        public void OnEngineValueChanged(TMP_Dropdown engineDrop){
            if(engineDrop.value == 0){
                engine = true;
            }else{
                engine = false;
            }
        }

        public void OnCreate(){
            if(wheels == 1){
                if(!engine){
                    IUnicycle basicUnicycle = basicVehicleFactory.CreateUnicycle();
                    createdText.text = basicUnicycle.GetDetails();
                }else if(engine){
                    IUnicycle fancyUnicycle = poweredVehicleFactory.CreateUnicycle();
                    createdText.text = fancyUnicycle.GetDetails();
                }
            }else if(wheels == 2){
                if(!engine){
                    IBike basicBike = basicVehicleFactory.CreateBike();
                    createdText.text = basicBike.GetDetails();
                }else if(engine){
                    IBike fancyBike = poweredVehicleFactory.CreateBike();
                    createdText.text = fancyBike.GetDetails();
                }
            }else if(wheels == 4){
                if(!engine){
                    ICar basicCar = basicVehicleFactory.CreateCar();
                    createdText.text = basicCar.GetDetails();
                }else if(engine){
                    ICar fancyCar = poweredVehicleFactory.CreateCar();
                    createdText.text = fancyCar.GetDetails();
                }
            }else{
                createdText.text = "invalid entry";
            }
        }
    }
}