using UnityEngine;
using System.Collections;
using System;

public class SendThisRight : MonoBehaviour {

    public static Action<GameObject> SendThis;

    void AddToList (GameObject _go)
    {
        level.Add(_go);
    }

	// Use this for initialization
	void Start () {
        SendThisRight.SendThis += AddToList;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
