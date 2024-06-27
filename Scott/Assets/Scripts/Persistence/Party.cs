using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;
    [SerializeField] JelousContainer jelous;
    public GameObject crowd;
    public GameObject ball;
    public GameObject lights;

    void Start()
    {
        crowd.SetActive(false);
        ball.SetActive(false);
        lights.SetActive(false);
    }

    void Update()
    {
        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            crowd.SetActive(true);
            ball.SetActive(false);
            lights.SetActive(false);
        }
    }
}
