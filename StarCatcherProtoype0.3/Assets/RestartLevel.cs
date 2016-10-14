using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    void Start()
    {
      //  Statics.nextPosition = Statics.startPos;
    }

    void OnTriggerEnter()
    {
        RestartLevels();
    }

    public void RestartLevels()
    {
        SceneManager.LoadScene(0);
    }
}
