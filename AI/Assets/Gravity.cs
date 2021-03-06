﻿using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    CharacterController myCC;
    Vector3 TempPos;
    public float gravity = 1;


	// Use this for initialization
	void Start () {
        myCC = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
        TempPos.y -= gravity * Time.deltaTime;

        if(myCC.isGrounded)
        {
            TempPos.y = 0;
        }
        print(myCC.velocity);
        myCC.Move(TempPos);
	
	}
}
