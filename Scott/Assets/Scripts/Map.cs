using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject map;
    private bool isVisible;

    public void Start()
    {
        map.SetActive(false);
        isVisible = false;
    }

    public void MapOpen()
    {
        map.SetActive(true);
        isVisible = true;
    }

    public void MapClose()
    {
        map.SetActive(false);
        isVisible = false;
    }

    public void AngerHouse()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void EnvyHouse()
    {
        SceneManager.LoadSceneAsync(1);
    }

     public void Garage()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void SadHouse()
    {
        SceneManager.LoadSceneAsync(3);
    }
}