using UnityEngine;
using System.Collections;

public class SuperPowers : MonoBehaviour {

    void Start()
    {
        print("Creating a Power");
        Power myPower = new Power();
        print("Creating a Power");
        Flight myFlight = new Flight();

        myPower.SayHello();
        myPower.Given();
        
        myFlight.SayHello();
        myFlight.Given();

        print("Creating a Power");
        myPower = new Power("Invisibility");
        print("Creating Flight");
        myFlight = new Flight("Float");
        
        myPower.SayHello();
        myPower.Given();
        
        myFlight.SayHello();
        myFlight.Given();
    }
}
