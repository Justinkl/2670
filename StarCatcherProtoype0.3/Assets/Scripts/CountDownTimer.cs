using UnityEngine;
using System.Collections;

public class CountDownTimer : MonoBehaviour
{
    float timeRemaining = 90 ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    timeRemaining -= Time.deltaTime;
	}

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(600, 300, 100, 100), "Timer :" + timeRemaining);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 100, 100), "End");
        }
     {

     }
    }
}
