using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    //Remove ForLoop component and attach this one to the Empty GameObject

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        WallWalking();

    }
    void WallWalking()
    {
        int i = 0;

        while (i != 9)
        {
            i++;
            print(i);
        }
    }
}
