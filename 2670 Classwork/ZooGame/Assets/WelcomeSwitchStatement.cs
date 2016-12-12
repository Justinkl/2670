using UnityEngine;
using System.Collections;

public class WelcomeSwitchStatement : MonoBehaviour {

    public int welcome = 3;
    //private bool wellhellotherevar = true;
	// Use this for initialization
	void Start () {

        Intro();
    }
	
	public void Intro () {
        switch (welcome)
        {
            case 3:
                //StartCoroutine("wellhellothere");
                print("Well hello there!");
                goto case 2;
            case 2:
                print("Welcome to Justin's collection!");
                goto case 1;
            case 1:
                print("We have a special treat for you today so let's not waste time!");
                goto default;
            default:
                print("Just follow me and have fun!");
                break;
          }
        }
	
       //private IEnumerator Wellhellothere ()
         //  {
        //if(wellhellotherevar == true){
          //  wellhellotherevar = false;
        //}
         //   yield return new WaitForSeconds(3);
       // wellhellotherevar = true;
        
	//}
}