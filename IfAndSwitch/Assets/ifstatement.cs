using UnityEngine;
using System.Collections;

public class ifstatement : MonoBehaviour {

    public float weight = 3;


    // Use this for initialization
    void Start()
    {
    }

	// Update is called once per frame
	void Update ()
    {
        if (weight < 4)
        {
            print("Oh you are so skinny!");
        }
        else
        {
            print("I forgot you weight!");
        }
    }

}
