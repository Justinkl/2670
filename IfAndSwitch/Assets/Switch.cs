using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public int animals = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        animals = Random.Range(1, 7);

        switch (animals)
        {
            case 1:
                print("I am a fox.");
                break;
            case 2:
                print("I am a frog.");
                break;
            case 3:
                print("I am a bug.");
                break;
            case 4:
                print("I am a chimp.");
                break;
            case 5:
                print("I am a turtle.");
                break;
            case 6:
                print("I am The Lion!");
                break;
            default:
                print("What animal are you?");
                break;
        }
	}
}
