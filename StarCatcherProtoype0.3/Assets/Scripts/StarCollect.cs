using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StarCollect : MonoBehaviour {

	public int pointsToAdd;

	public GameObject starEnable;
	private StarControl StarControllerScript;

	void Start()
	{
		StarControllerScript = GetComponent<StarControl> ();
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.GetComponent<Move> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		starEnable.gameObject.SetActive (false);
	}

}