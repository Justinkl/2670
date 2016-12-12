using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransitionCoroutine : MonoBehaviour {


	// Use this for initialization
	void Start () {
        StartCoroutine("Countdown");
	
	}
	
	// Update is called once per frame
	private IEnumerator Countdown ()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
	}
}
