using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    GameObject MainMenu;
    // Use this for initialization
    void Start() {
        MainMenu = GameObject.Find("MainMenuCanvas");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("escape"))
        {
            ShowMainMenu();
        }
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
    }
    public void ShowMainMenu()
    {
        MainMenu.SetActive(!MainMenu.activeSelf);
        MainMenu.GetComponent<Image>().enabled = false;
        foreach (Transform child in MainMenu.transform)
        {
            if (child.gameObject.name == "StartButton")
            {
                child.gameObject.SetActive(false);
                // for each child named Bone
            }
            if (child.gameObject.name == "ResumeButton")
            {
                child.gameObject.SetActive(true);
                // for each child named Bone
            }
            if (child.gameObject.name == "RestartButton")
            {
                child.gameObject.SetActive(true);
                // for each child named Bone
            }
            if (child.gameObject.name == "Panel")
            {
                child.gameObject.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 600f);
                // for each child named Bone
            }
        }

    }
    public void LeaveGame()
    {
        Exitgame.ExitGame();
    }
    public void ResetGame()
    {
        Exitgame.ResetGame();
    }
}