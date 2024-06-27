using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionMusic : MonoBehaviour
{
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;
    [SerializeField] JelousContainer jelous;


    public AudioClip Felix;
    public AudioClip FelixSad;
    public AudioClip FelixSadAngry;
    public AudioClip FelixAngry;
    public AudioClip FelixAngryJelous;
    public AudioClip FelixJelous;
    public AudioClip FelixJelousSad;
    public AudioClip Party;

    void Start()
    {
        GetComponent<AudioSource>().clip = Felix;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (sad.sadDance == true)
        {
            GetComponent<AudioSource>().clip = FelixSad;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (sad.sadDance == true && angry.angryDance == true)
        {
            GetComponent<AudioSource>().clip = FelixSadAngry;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (angry.angryDance == true)
        {
            GetComponent<AudioSource>().clip = FelixAngry;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (jelous.jelousDance == true && angry.angryDance == true)
        {
            GetComponent<AudioSource>().clip = FelixAngryJelous;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (jelous.jelousDance == true)
        {
            GetComponent<AudioSource>().clip = FelixJelous;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (sad.sadDance == true && jelous.jelousDance == true)
        {
            GetComponent<AudioSource>().clip = FelixJelousSad;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }

        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            GetComponent<AudioSource>().clip = Party;
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().loop = true;
        }
    }
}
