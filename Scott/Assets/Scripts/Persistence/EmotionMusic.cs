using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionMusic : MonoBehaviour
{
    [SerializeField] AngryContainer angry;
    [SerializeField] SadContainer sad;
    [SerializeField] JelousContainer jelous;


    public AudioSource Felix;
    public AudioSource FelixSad;
    public AudioSource FelixSadAngry;
    public AudioSource FelixAngry;
    public AudioSource FelixAngryJelous;
    public AudioSource FelixJelous;
    public AudioSource FelixJelousSad;
    public AudioSource Party;

    void Start()
    {
        StartCoroutine(playMusic());
    }

    void Update()
    {
        
    }

    IEnumerator playMusic()
    {
        if (sad.sadDance == false && jelous.jelousDance == false && angry.angryDance == false)
        {
            Felix.Play();
        }

        if (sad.sadDance == true && jelous.jelousDance == false && angry.angryDance == false)
        {
            FelixSad.Play();
        }

        if (sad.sadDance == true && angry.angryDance == true && jelous.jelousDance == false)
        {
            FelixSadAngry.Play();
        }

        if (angry.angryDance == true && sad.sadDance == false && jelous.jelousDance == false)
        {
            FelixAngry.Play();
        }

        if (jelous.jelousDance == true && angry.angryDance == true && sad.sadDance == false)
        {
            FelixAngryJelous.Play();
        }

        if (jelous.jelousDance == true && angry.angryDance == false && sad.sadDance == false)
        {
            FelixJelous.Play();
        }

        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == false)
        {
            FelixJelousSad.Play();
        }

        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            Party.Play();
        }

        yield return new WaitForSeconds(0);
    }
}
