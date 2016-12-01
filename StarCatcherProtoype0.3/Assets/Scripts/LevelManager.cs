using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadScene()
    {
       SceneManager.LoadScene(1);
    }
}