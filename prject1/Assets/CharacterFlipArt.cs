using UnityEngine;
using System.Collections;

public class CharacterFlipArt : MonoBehaviour {

    public Transform CharacerArt;

    public bool forward = true;

    void FlipCharacter (bool _b)
    {
        CharacterFlipArt.Rotate(0, 180, 0);
        forward = _b;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.RightArrow) && forward)
        {
            FlipCharacter(false);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !forward)
        {
            FlipCharacter(true);
        }
	}
}
