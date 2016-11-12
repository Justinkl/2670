using UnityEngine;
using System.Collections;

public class ScopesAndModifiers : MonoBehaviour {
    //These variables are in scope with the ScopesAndModifiers class


    //Since MyNumbers are public, you can change the number to above 10 and get the print
    public float MyNumbers = 10;


    //Since OtherNumbers is private, it can't be change outside the script
    //if you wanted it to stop saying your numbers are low, you would have to change it here and only here
    private float OtherNumbers = 9;


	// Use this for initialization
	void Start () {
        //The if statements below are in scope with the start function
	
        if (MyNumbers > 10)
        {
            print("I got my numbers up!");
        }

        if (OtherNumbers < 10)
        {
            print("Your numbers are low.");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
