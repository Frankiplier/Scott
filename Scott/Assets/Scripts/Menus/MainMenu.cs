using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject credits;
    [SerializeField] GameObject tutorial;
    bool tutorialEnabled;
    bool creditsEnabled;

    void Start()
    {
        credits.SetActive(false);
        creditsEnabled = false;

        tutorial.SetActive(false);
        tutorialEnabled = false;
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Credits()
    {
        creditsEnabled ^= true;
        credits.SetActive(creditsEnabled);
    }

    public void Tutorial()
    {
        tutorialEnabled ^= true;
        tutorial.SetActive(tutorialEnabled);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
