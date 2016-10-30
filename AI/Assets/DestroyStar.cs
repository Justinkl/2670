using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

    public float endTime = 3;

   // IEnumerator EndStar ()
   // {
    //    yield return new WaitForSeconds(endTime);
    //    Destroy(gameObject);
    //}

	// Use this for initialization
	void OnCollisionEnter () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, endTime);
    }
}
