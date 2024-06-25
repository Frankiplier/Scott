using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject credits;
    public GameObject backButton;
    [SerializeField] GameObject tutorial;
    bool tutorialEnabled;

    void Start()
    {
        credits.SetActive(false);
        backButton.SetActive(false);

        tutorial.SetActive(false);
        tutorialEnabled = false;
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Credits()
    {
        credits.SetActive(true);
        backButton.SetActive(true);
    }

    public void Back()
    {
        credits.SetActive(false);
        backButton.SetActive(false);
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
