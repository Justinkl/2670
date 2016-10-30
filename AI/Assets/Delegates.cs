using UnityEngine;
using System.Collections;
using System;

public class Delegates : MonoBehaviour {

    Action<int> Move;
    Action Idle;
    Action Jump;

    int speed = 200;

    void MoveHandler (int _speed)
    {
        print("moving at" + _speed + "mph.");
        Move = null;
        Idle = IdleHandler;
    }

    void IdleHandler ()
    {
        print("Idling");
        Idle = null;
        Jump = JumpHandler;
    }

    void JumpHandler ()
    {
        print("Jumping");
        Jump = null;
    }
	// Use this for initialization
	void Start () {
        Move = MoveHandler;
        Idle = IdleHandler;
        Jump = JumpHandler;
	}
	
	// Update is called once per frame
	void Update () {

       if(Move != null)
            Move(50);
       if(Idle != null)
            Idle();
       if(Jump != null)
            Jump();

	}
}
