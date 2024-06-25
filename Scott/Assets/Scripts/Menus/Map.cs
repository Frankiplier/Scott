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