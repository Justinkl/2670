using UnityEngine;
using System.Collections;

public class Power
    {
        public string type;

        
        public Power()
        {
            type = "teleport";
            Debug.Log("1st Power Constructor Called");
        }
        
        public Power(string newType)
        {
            type = newType;
            Debug.Log("2nd Power Constructor Called");
        }

        public void Given()
        {
            Debug.Log("The " + type + "Power has been given.");
        }

        public void SayHello()
        {
            Debug.Log("I have a super power.");
        }
    }
