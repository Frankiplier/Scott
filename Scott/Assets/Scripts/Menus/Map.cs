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
        SceneManager.LoadSceneAsync(2);
        yield return new WaitForSeconds(3);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator AngerLevel()
    {
        transition.Play("Transition Level End");
        SceneManager.LoadSceneAsync(3);
        yield return new WaitForSeconds(3);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator EnvyLevel()
    {
        transition.Play("Transition Level End");
        SceneManager.LoadSceneAsync(4);
        yield return new WaitForSeconds(3);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator SadLevel()
    {
        transition.Play("Transition Level End");
        SceneManager.LoadSceneAsync(5);
        yield return new WaitForSeconds(3);
        transition.SetTrigger("Transition Level Start");
    }
}