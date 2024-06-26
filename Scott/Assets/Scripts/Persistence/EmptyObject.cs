using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptyObject : MonoBehaviour
{
    [SerializeField] JelousContainer jelous;
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;

    void Awake()
    {
        jelous.jelousDance = false;
        angry.angryDance = false;
        sad.sadDance = false;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Envy Battle"))
        {
            jelous.jelousDance = true;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Angry Battle"))
        {
            angry.angryDance = true;
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Sad Battle"))
        {
            sad.sadDance = true;
        }        
    }

    private void OnDisable()
    {
        Destroy(gameObject);
        return;
    }
}
