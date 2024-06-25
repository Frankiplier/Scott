using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    [SerializeField] GameObject map;

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
        SceneManager.LoadSceneAsync(2);
    }

    public void AngerHouse()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void EnvyHouse()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void SadHouse()
    {
        SceneManager.LoadSceneAsync(5);
    }
}