using UnityEngine;
using System.Collections;

public class Function : MonoBehaviour {

    int myInt = 3001;

    //Use this for initialization
    void Start()
    {
        myInt = MultiplyByThree(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByThree(int number)
    {
        int ret;
        ret = number * 3;
        return ret;
    }
	
	// Update is called once per frame
	void Update () {

        if (myInt > 9000)
        {
            print("IT'S OVER NINE THOUSAAAAAND!!");
        }

	
	}
}
