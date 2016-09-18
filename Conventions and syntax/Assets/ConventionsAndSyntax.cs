using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour {
    //A";" is going to terminate the end of this variable
    public float speed = 100;


	// Use this for initialization
	void Start () {
        // indenting helps organize code
	if(speed > 99)
        {
            print("GOTTA GO FAST");
        }
    // I will disable the bottom piece by making it muti-line comment like the example in te videos
    /*
    if(speed < 101)
        {
            print("YOU'RE TOO SLOW!");
        }
    */
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
