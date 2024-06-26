using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public string sceneName;
    public float seconds;
    public bool hasDanced = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(EndDance());
        }
    }

    private IEnumerator EndDance()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneName);
        hasDanced = true;
    }
}
