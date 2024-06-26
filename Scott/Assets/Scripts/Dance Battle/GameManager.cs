using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller beatScroller;
    public static GameManager instance;
    public GameObject word;

    float timeToDance;

    void Start()
    {
         instance = this;
         word.SetActive(true);

         StartCoroutine(DanceBattle());
    }

    public void NoteHit()
    {
        Debug.Log("Hit");
    }

    public void NoteMissed()
    {
        Debug.Log("Missed");
    }

    IEnumerator DanceBattle() 
    {
        yield return new WaitForSeconds(3);

        word.SetActive(false);

        startPlaying = true;
        beatScroller.hasStarted = true;

        theMusic.Play();
    }
}
