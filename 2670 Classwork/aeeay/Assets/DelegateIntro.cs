using UnityEngine;
using System;

public class DelegateIntro : MonoBehaviour {

    public static Action MyEvent;
    public static Action<string> EventWithArgs;

    public static Action<string> EventString;

    public delegate void DelWithArgs(string s);
    public static DelWithArgs EventReturnArgs;

    public delegate string DelString();

	// Use this for initialization
	void Start () {

        string data = EventReturnArgs("Cat");

        print(EventString());

        EventWithArgs("Hello World");

        if (MyEvent != null)
            MyEvent();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
