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
            playFelixSad();
        }

        if (sad.sadDance == true && angry.angryDance == true)
        {
            playFelixSadAngry();
        }

        if (angry.angryDance == true)
        {
            playFelixAngry();
        }

        if (jelous.jelousDance == true && angry.angryDance == true)
        {
            playFelixAngryJelous();
        }

        if (jelous.jelousDance == true)
        {
            playFelixJelous();
        }

        if (sad.sadDance == true && jelous.jelousDance == true)
        {
            playFelixJelousSad();
        }

        if (sad.sadDance == true && jelous.jelousDance == true && angry.angryDance == true)
        {
            playParty();
        }
    }

    IEnumerator playFelixSad()
    {
        GetComponent<AudioSource>().clip = FelixSad;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playFelixSadAngry()
    {
        GetComponent<AudioSource>().clip = FelixSadAngry;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playFelixAngry()
    {
        GetComponent<AudioSource>().clip = FelixAngry;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playFelixAngryJelous()
    {
        GetComponent<AudioSource>().clip = FelixAngryJelous;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playFelixJelous()
    {
        GetComponent<AudioSource>().clip = FelixJelous;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playFelixJelousSad()
    {
        GetComponent<AudioSource>().clip = FelixJelousSad;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }

    IEnumerator playParty()
    {
        GetComponent<AudioSource>().clip = Party;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
        yield return new WaitForSeconds(0);
    }
}
