using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [Header("UI Pages")]
    public GameObject MainMenu;

    [Header("Main Menu Buttons")]
    public Button StartButton;

    

    void Start()
    {
        EnableMenu();

        StartButton.onClick.AddListener(StartGame);

    }

    public void EnableMenu()
    {
        MainMenu.SetActive(true);
    }

    public void HideAll()
    {
        MainMenu.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("1.MainGame");
    }
}
