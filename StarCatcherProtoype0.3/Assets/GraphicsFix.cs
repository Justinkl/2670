using UnityEngine;
using System.Collections;

public class GraphicsFix : MonoBehaviour {

	public Transform rotateRef;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation.y = rotateRef.transform.rotation.y;
	}
}
