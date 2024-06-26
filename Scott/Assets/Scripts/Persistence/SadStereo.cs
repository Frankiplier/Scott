using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadStereo : MonoBehaviour
{
    [SerializeField] SadContainer sad;
    public GameObject stereo;

    void Start()
    {
        stereo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (sad.sadDance == true)
        {
            stereo.SetActive(true);
        }
    }
}
