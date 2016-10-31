using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text ScoreText;
    public float scoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        scoreCount += pointsPerSecond * Time.deltaTime;

        ScoreText.text = "Score: " + Mathf.Round (scoreCount);
	}
}
