using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JelousStereo : MonoBehaviour
{
    [SerializeField] JelousContainer jelous;
    public GameObject stereo;
    public GameObject NPC;

    void Start()
    {
        stereo.SetActive(false);
        NPC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (jelous.jelousDance == true)
        {
            stereo.SetActive(true);
            NPC.SetActive(true);
        }
    }
}
