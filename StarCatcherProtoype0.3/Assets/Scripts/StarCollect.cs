using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StarCollect : MonoBehaviour {

	public int points = 0;
	public Text countText;
	public GameObject[] wolf;

	void Start()
	{
		SetCountText ();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive (false);
			points = points + 1;
			SetCountText ();
		}

		if (other.gameObject.CompareTag ("wolf")) {
			points = points - 1;
			if (points < 0)
				points = 0;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Score: " + points.ToString ();
	}
}