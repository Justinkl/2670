using UnityEngine;
using System.Collections;
using System;

public class EventHandlerIntro : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DelegateIntro.MyEvent += MyEventHandler;
        DelegateIntro.EventWithArgs += EventWithArgsHandler;
        DelegateIntro.EventString += EventStringHandler;
        DelegateIntro.EventReturnArgs += EventReturnArgsHandler;

	
	}

    private string EventReturnArgsHandler(string s)
    {
        return
    }

    private string EventStringHandler()
    {
        print("Do you like cats?");
        return ("I hate cats");
    }

    private void MyEventHandler()
    {
        throw new NotImplementedException();
    }

    private void EventWithArgsHandler(string s)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
