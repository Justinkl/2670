using UnityEngine;
using System.Collections;

public class GraphicsFix : MonoBehaviour {

	public Transform rotateRef;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.eulerAngles = rotateRef.transform.eulerAngles;
		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, (-transform.eulerAngles.y / 2 ), transform.eulerAngles.z);
	}
}
