using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] Animator transition;

    public void Start()
    {
        map.SetActive(false);
    }

    public void MapOpen()
    {
        map.SetActive(true);
    }

    public void MapClose()
    {
        map.SetActive(false);
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
        transition.SetTrigger("Transition Level End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(2);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator AngerLevel()
    {
        transition.SetTrigger("Transition Level End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(3);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator EnvyLevel()
    {
        transition.SetTrigger("Transition Level End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(4);
        transition.SetTrigger("Transition Level Start");
    }

      IEnumerator SadLevel()
    {
        transition.SetTrigger("Transition Level End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(5);
        transition.SetTrigger("Transition Level Start");
    }
}