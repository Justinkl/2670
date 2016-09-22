using UnityEngine;
using System.Collections;

public class Recycler : MonoBehaviour {

    public static Action<Recycler> RecycleAction;
    public bool canBeRecycled;
    public Transform cube;

    void Start()
    {
        gameObject = this.GetComponent<Transform>();
        if (RecycleAction != null && canBeRecycled)
        {
            RecycleAction(this);
        }
    }

    void OnTriggerEnter()
    {
        canBeRecycled = true;
        Start();
    }

}