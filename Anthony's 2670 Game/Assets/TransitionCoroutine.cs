using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionCoroutine : MonoBehaviour {


	// Use this for initialization
	void Start () {
		StartCoroutine ("Countdown");
	}

	private IEnumerator Coundown ()
	{
		yield return new WaitForSeconds (10);
		SceneManager.LoadScene (0);
	}
}
