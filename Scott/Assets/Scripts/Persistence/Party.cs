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
    public GameObject gj;
    public GameObject tuto;

    void Start()
    {
        crowd.SetActive(false);
        ball.SetActive(false);
        lights.SetActive(false);
        gj.SetActive(false);
        tuto.SetActive(true);
    }

    void Update()
    {
        if (sad.sadDance == true || jelous.jelousDance == true || angry.angryDance == true)
        {
            tuto.SetActive(false);
        }

        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            crowd.SetActive(true);
            ball.SetActive(true);
            lights.SetActive(true);
            gj.SetActive(true);
        }
    }
}
