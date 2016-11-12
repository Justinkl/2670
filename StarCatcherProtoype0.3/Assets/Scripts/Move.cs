using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	private int count;
	public Text Score;

    //This is the CharacterController component
    private CharacterController myCC;
    //Temp var of datatype vector3 to move the character
    private Vector3 tempPos;
    //Speed of the temp var in x
    public float speed = 1;
    public float gravity = 1;
    public float jumpSpeed = 12;
    public int jumpCount = 0;
    public int jumpCountMax = 2;
    // Use this for initialization
    void Start()
    {
        //This "Finds"{ the ChararcterController component
        myCC = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        //pulling for input and comparing jumpCount

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax - 1)
        {
            //incrementing the jumpCount by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }

        //Test if the character controller is grounded
        if (myCC.isGrounded)
        {
            //reset the jump count if grounded
            jumpCount = 0;
        }
        //adding the gravity var to the y position of the tempPos var
        tempPos.y -= gravity;
        //adding the speed var to the tempPos var x value with the right and left arrow keys
        tempPos.x = speed * Input.GetAxis("Horizontal");
        //Moves the character controller at an even pace (deltaTime)
        myCC.Move(tempPos * Time.deltaTime);

    }

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Star")) {
			Destroy (other.gameObject);
			count = count + 1;
			SetCountCountText ();
		}
	}

	void SetCountCountText ()
	{
		Score.text = "Score: " + count.ToString ();
	}
}
