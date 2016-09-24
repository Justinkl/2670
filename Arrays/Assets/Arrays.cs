using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

    public GameObject[] animals;

	// Use this for initialization
	void Start () {

        animals = GameObject.FindGameObjectsWithTag("Animal");

        for(int  i = 0; i < animals.Length; i++)
        {
            print("Animal Number:" + i + " is named " + animals[i].name);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
