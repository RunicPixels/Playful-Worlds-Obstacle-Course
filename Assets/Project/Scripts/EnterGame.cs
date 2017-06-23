using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DebugMode()
    {
        SceneManager.LoadScene("Prototype 1", LoadSceneMode.Additive);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Additive);
    }
}
