using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

    private int WallDistance = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        WallWalking();
	
	}
    void WallWalking()
    {
        for (int i = 0; i < 5; i++)
        {
            WallDistance = Random.Range(1, 20);

            if(WallDistance >= 15)
            {
                print("Is that wall over there?");

            }
            if (WallDistance >= 5 && WallDistance <= 10)
            {
                print("I'm getting to close!");
            }
            if (WallDistance >= 1 && WallDistance <=4)
            {
                print("Ah Crap!");
            }
            if (WallDistance <= 0)
            {
                print("SPLAT!");
            }

        }
    }

}
