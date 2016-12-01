using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{
	public Text timerText;
    public float timeRemaining = 60 ;
	private bool timerIsActive = true;

	// Use this for initialization
	void Start () {
	
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
    timeRemaining -= Time.deltaTime;
		timerText.text = "Time Left; " + timeRemaining.ToString ("f0");

		if (timeRemaining < 0) 
		{
			timeRemaining = 0;
			timerIsActive = false;
			GameOver ();
		}
	}

	public void GameOver ()
	{
	}
    
}
