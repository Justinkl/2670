using UnityEngine;
using System.Collections;

public class Flight : Power
{

    public Flight()
    {
        type = "gravity";
        Debug.Log("1st Flight Constructor Called");
    }
    public Flight(string newType) : base(newType)
    {
        Debug.Log("2nd Flight Constructor Called");
    }
}
