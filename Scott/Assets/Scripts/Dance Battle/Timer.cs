using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] Object scene;
    public float seconds;
    public bool hasDanced = false;

    void Start()
    {
        StartCoroutine(EndDance());
    }

    private IEnumerator EndDance()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(scene.name);
        hasDanced = true;
    }
}
