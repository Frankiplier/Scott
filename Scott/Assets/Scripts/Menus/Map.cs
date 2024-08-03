using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject mapButton;
    [SerializeField] Animator transition;

    [SerializeField] JelousContainer jelous;
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;

    [SerializeField] GameObject jelousHouse;
    [SerializeField] GameObject angryHouse;
    [SerializeField] GameObject sadHouse;

    void OnEnable()
    {
        transition.Play("Transition Level Start");
    }

    public void Start()
    {
        map.SetActive(false);
        mapButton.SetActive(true);
    }

    void Update()
    {
        if (jelous.jelousDance == true)
        {
            jelousHouse.SetActive(false);
        }

        if (angry.angryDance == true)
        {
            angryHouse.SetActive(false);
        }

        if (sad.sadDance == true)
        {
            sadHouse.SetActive(false);
        }
    }

    public void MapOpen()
    {
        map.SetActive(true);
        mapButton.SetActive(false);
    }

    public void MapClose()
    {
        map.SetActive(false);
        mapButton.SetActive(true);
    }

    public void Garage()
    {
        StartCoroutine(GarageLevel());
    }

    public void AngerHouse()
    {
         StartCoroutine(AngerLevel());
    }

    public void EnvyHouse()
    {
        StartCoroutine(EnvyLevel());
    }

    public void SadHouse()
    {
         StartCoroutine(SadLevel());
    }

    IEnumerator GarageLevel()
    {
        transition.Play("Transition Level End");
        yield return new WaitForSeconds(0);
        SceneManager.LoadSceneAsync(2);
    }

      IEnumerator AngerLevel()
    {
        transition.Play("Transition Level End");
        yield return new WaitForSeconds(0);
        SceneManager.LoadSceneAsync(3);
    }

      IEnumerator EnvyLevel()
    {
        transition.Play("Transition Level End");
        yield return new WaitForSeconds(0);
        SceneManager.LoadSceneAsync(4);
    }

      IEnumerator SadLevel()
    {
        transition.Play("Transition Level End");
        yield return new WaitForSeconds(0);
        SceneManager.LoadSceneAsync(5);
    }
}