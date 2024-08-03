using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject credits;
    [SerializeField] GameObject tutorial;

    bool creditsEnabled;
    bool tutorialEnabled;

    public Button creditsButton;
    public Button tutorialButton;


    void Start()
    {
        credits.SetActive(false);
        creditsEnabled = false;

        tutorial.SetActive(false);
        tutorialEnabled = false;

        creditsButton = GameObject.FindGameObjectWithTag("CreditsButton").GetComponent<Button>();
        tutorialButton = GameObject.FindGameObjectWithTag("TutorialButton").GetComponent<Button>();
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Credits()
    {
        creditsEnabled ^= true;
        credits.SetActive(creditsEnabled);

        if (creditsEnabled == true) 
        {
            tutorialButton.interactable = false;
        }
        
        else
        {
            tutorialButton.interactable = true;
        }
    }

    public void Tutorial()
    {
        tutorialEnabled ^= true;
        tutorial.SetActive(tutorialEnabled);

        if (tutorialEnabled == true) 
        {
            creditsButton.interactable = false;
        }
        
        else
        {
            creditsButton.interactable = true;
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
