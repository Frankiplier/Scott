using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryStereo : MonoBehaviour
{
    [SerializeField] AngryContainer angry;
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
        if (angry.angryDance == true)
        {
            stereo.SetActive(true);
            NPC.SetActive(true);
        }
    }
}
